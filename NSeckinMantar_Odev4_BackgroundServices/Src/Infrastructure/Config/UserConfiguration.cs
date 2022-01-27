using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(x => x.CustomerNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.CreationTime)
               .IsRequired();

            builder.Property(x => x.Status)
               .IsRequired();
        }
    }
}
