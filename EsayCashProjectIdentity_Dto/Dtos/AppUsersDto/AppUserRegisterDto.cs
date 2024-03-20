using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Dto.Dtos.AppUsersDto
{
    public class AppUserRegisterDto
    {
        
        //[Required(ErrorMessage ="You must write name!! ")]
        //[Display(Name="Name")]
        //[MaxLength(30,ErrorMessage ="Please you write character 30")]
        public string Name { get; set; }

        public string SurName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
