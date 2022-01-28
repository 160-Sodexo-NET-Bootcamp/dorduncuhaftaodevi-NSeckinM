using System;

namespace WebAPI.DTOs
{
    public class CreateUserDTO
    {

        public string CustomerNumber { get; set; }

        public DateTimeOffset CreationTime { get; set; } = DateTimeOffset.Now;

        public bool Status { get; set; }

    }
}
