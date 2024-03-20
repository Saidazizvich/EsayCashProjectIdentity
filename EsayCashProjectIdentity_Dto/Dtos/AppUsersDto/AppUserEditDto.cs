
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Dto.Dtos.AppUsersDto
{
    public class AppUserEditDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Image { get; set; }

        public string Email { get; set; }

             public string Phone { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

    }
}
