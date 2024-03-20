using EsayCashProjectIdentity_Dto.Dtos.AppUsersDto;
using EsayCashProjectIdentity_Entity.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EsayCashProjectIdentity_Pretation.Controllers
{
    [Authorize]
    public class MyAccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyAccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();   
            appUserEditDto.SurName = values.SurName;
            appUserEditDto.Name = values.Name;  
            appUserEditDto.City = values.City;  
            appUserEditDto.Email = values.Email;
            appUserEditDto.Phone = values.PhoneNumber;
            appUserEditDto.Image = values.ImageUrl;
            appUserEditDto.District = values.District;  

            return View(appUserEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDto appUserEditDto)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.PhoneNumber = appUserEditDto.Phone;
            user.Name = appUserEditDto.Name;    
            user.City = appUserEditDto.City;
            user.Email = appUserEditDto.Email;
            user.SurName = appUserEditDto.SurName;  
            user.District = appUserEditDto.District;
            user.ImageUrl = "Dene";
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,appUserEditDto.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");   
            }
            return View();
        }
    }
}
