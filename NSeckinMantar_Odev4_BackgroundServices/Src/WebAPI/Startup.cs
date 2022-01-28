using Hangfire;
using Hangfire.PostgreSql;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Text.Json.Serialization;
using WebAPI.Jobs;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //For Database Connection With Postgre
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("ApplicationDbContext")));

            //For Database Connection Between Postgre and hangfire
            services.AddHangfire(config =>config.UsePostgreSqlStorage(Configuration.GetConnectionString("HangfireConnection")));

            services.AddHangfireServer();

            //For AutoMapper Configuration
            services.AddAutoMapper(typeof(Startup));

            //Dependency Injection for Infrastructure
            services.AddInfraServices();

            //For Json data Serializer
            services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //For Hangfire Dashboard Configuration


            app.UseHangfireDashboard();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            RecurringJob.AddOrUpdate<InsertData>(x => x.DoJob(),Cron.MinuteInterval(15));

           // BackgroundJob.Schedule<StatusChanger>(x => x.DoJobUpdate(),TimeSpan.FromSeconds(5));


            BackgroundJob.Schedule<StatusChanger>(x => x.DoJobUpdate(),TimeSpan.FromTicks(21));

        }
    }
}
