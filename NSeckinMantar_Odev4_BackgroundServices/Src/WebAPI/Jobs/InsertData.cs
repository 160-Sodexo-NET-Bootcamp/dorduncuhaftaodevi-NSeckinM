using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces.UnitOfWork;
using Hangfire;

namespace WebAPI.Jobs
{
    public class InsertData
    {
        private readonly IUnitOfWork _unitOfWork;

        public InsertData(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public void DoJob()
        {
            Random rnd = new Random();
            string r = rnd.Next(0, 100000000).ToString("D8");
            User user = new();
            user.Status = false;
            user.CreationTime = DateTime.Now;
            user.CustomerNumber = r;

            _unitOfWork.Users.AddAsync(user);
            _unitOfWork.Complete();

        }

    }

}
