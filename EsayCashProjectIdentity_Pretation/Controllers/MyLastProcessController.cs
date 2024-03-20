using EsayCashIdentityProject_Data.Concreate;
using EsayCashProjectIdentity_Business.Abstract;
using EsayCashProjectIdentity_Entity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EsayCashProjectIdentity_Pretation.Controllers
{
    public class MyLastProcessController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcess _customerAccount;

        public MyLastProcessController(UserManager<AppUser> userManager, ICustomerAccountProcess customerAccount)
        {
            _userManager = userManager;
            _customerAccount = customerAccount;
        }

        public  async Task <IActionResult> Index(int id)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            int Id = context.CustomerAccounts.Where(x=>x.AppUserId== user.Id && x.CustomerAccountCurrency == "Dolar").Select(y=>y.CustomerAccountId).FirstOrDefault();
            var valu = _customerAccount.TMyLastProcess(user.Id); 

            return View(valu);
        }
    }
}
