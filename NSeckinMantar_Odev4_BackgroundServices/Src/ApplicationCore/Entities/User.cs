using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class User
    {

        public int Id { get; set; }

        public string CustomerNumber { get; set; }

        public DateTimeOffset CreationTime { get; set; } = DateTimeOffset.Now;

        public bool Status { get; set; }



    }
}
