using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class UpdateUserDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}