using EsayCashIdentityProject_Data.Abstract;
using EsayCashIdentityProject_Data.EntityFremwork;
using EsayCashProjectIdentity_Entity.Model;
using EsayCashProjectIdentity_Pretation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EsayCashProjectIdentity_Pretation.Controllers
{
	public class ConfirmMailController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public ConfirmMailController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task <IActionResult> Index()
		{
			var val = TempData["Mail"];
			ViewBag.v = val;
			//confirmMailViewModel.Mail = val.ToString(); 
			return View();
		}

		[HttpPost]

		public async Task <IActionResult> Index(ConfirmMailViewModel confirmMailViewModel)
		{
			var valu = TempData["Mail"];
			var user = await _userManager.FindByEmailAsync(confirmMailViewModel.Mail);
			if (user.ConfirmCode == confirmMailViewModel.ConfirmCode) 
			{
				user.EmailConfirmed = true;	
				await _userManager.UpdateAsync(user);
				return RedirectToAction("Index","Login");

			}
			return View();
		}


	}
}
