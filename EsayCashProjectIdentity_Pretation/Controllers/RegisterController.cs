using EsayCashProjectIdentity_Dto.Dtos.AppUsersDto;
using EsayCashProjectIdentity_Entity.Model;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EsayCashProjectIdentity_Pretation.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]  
        public async Task <IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                Random random = new Random();
                int code;
                code = random.Next(100000, 1000000);

                AppUser appUser = new AppUser()
                {
                    Name = appUserRegisterDto.Name,
                    Email = appUserRegisterDto.Email,
                    SurName = appUserRegisterDto.SurName,
                    UserName = appUserRegisterDto.UserName,
                    City = "belvill hilss",
                    District = "Good",
                    ImageUrl = "world.png1",
                    ConfirmCode = code
                };

                var result = await _userManager.CreateAsync(appUser,appUserRegisterDto.Password);

                TempData["Mail"] = appUserRegisterDto.Email;


                if (result.Succeeded) 
                {
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddress = new MailboxAddress("Esay Cash Admin","developer8098@gmail.com");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                    mimeMessage.From.Add(mailboxAddress);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodyBuilder = new BodyBuilder();

                    bodyBuilder.TextBody = "Kayit islemini gerceklestirecek onay kodunuz :" + code;
                    mimeMessage.Body = bodyBuilder.ToMessageBody();

                    mimeMessage.Subject = "Esay Cash onay Kodu";

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Connect("smtp.gmail.com", 587, false);
                    smtpClient.Authenticate("developer8098@gmail.com", "");
                    smtpClient.Disconnect(true);

                    return RedirectToAction("Index","ConfirmMail");   
                }
                else 
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View();
        }
        
    }
}
