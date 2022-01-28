using ApplicationCore.Entities;
using ApplicationCore.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Jobs
{
    public class StatusChanger
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatusChanger(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;

        }

        public void DoJobUpdate()
        {

          List<User> users = _unitOfWork.Users.GetAllUser();

            foreach (var item in users)
            {
                if (item.CreationTime.Hour > 08.00 && item.CreationTime.Hour < 18.00 && item.CreationTime.Day == DateTime.Now.Day)
                {
                    item.Status = true;
                    _unitOfWork.Users.UpdateAsync(item);
                    _unitOfWork.Complete();
                }
            }


        }



    }
}
