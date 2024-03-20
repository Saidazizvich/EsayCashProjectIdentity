using EsayCashIdentityProject_Data.Concreate;
using EsayCashProjectIdentity_Business.Abstract;
using EsayCashProjectIdentity_Entity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EsayCashProjectIdentity_Pretation.Controllers
{
    public class AccountListForCopyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountService _customerAccountService;

        public AccountListForCopyController(UserManager<AppUser> userManager, ICustomerAccountService customerAccountService)
        {
            _userManager = userManager;
            _customerAccountService = customerAccountService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context(); 
            var valu = _customerAccountService.TGetCustomerList(user.Id);

             valu = context.CustomerAccounts.Where(z=>z.CustomerAccountId == user.Id).ToList(); 

            return View(valu);
        }
    }
}
