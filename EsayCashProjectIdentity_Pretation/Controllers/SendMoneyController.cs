using EsayCashIdentityProject_Data.Concreate;
using EsayCashProjectIdentity_Business.Abstract;
using EsayCashProjectIdentity_Business.Concreate;
using EsayCashProjectIdentity_Dto.Dtos.CustomerAccountDtos;
using EsayCashProjectIdentity_Entity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EsayCashProjectIdentity_Pretation.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountService _customerAccountService;

        

        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountService customerAccountService)
        {
            _userManager = userManager;
            _customerAccountService = customerAccountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public async Task <IActionResult>Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverAccountNumberId = context.CustomerAccounts.Where(x=>x.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber)
                .Select(y=>y.CustomerAccountId).FirstOrDefault();

            sendMoneyForCustomerAccountProcessDto.SenderId = user.Id;
            sendMoneyForCustomerAccountProcessDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            sendMoneyForCustomerAccountProcessDto.ProcessType = "Havale";
            sendMoneyForCustomerAccountProcessDto.ReceiverId = receiverAccountNumberId;

            var sendAccountNumberId = context.CustomerAccounts.Where(x => x.AppUserId == user.Id).Where(o => o.CustomerAccountCurrency == "Dinar")
                .Select(z => z.CustomerAccountId).FirstOrDefault();

            var values = new AccountProcess();
            values.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            values.SenderId = 1;
            values.ReceiverId = receiverAccountNumberId;
            values.Amount = sendMoneyForCustomerAccountProcessDto.Amount;
            values.Comment = sendMoneyForCustomerAccountProcessDto.Comment;
     
            //_customerAccountService.TInsert(values.AccountProcessId); 
              return RedirectToAction("Index","Deneme");
        }


    }
}
