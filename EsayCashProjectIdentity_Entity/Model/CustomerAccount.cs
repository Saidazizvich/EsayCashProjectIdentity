using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Entity.Model
{
    public class CustomerAccount
    {
        public int CustomerAccountId { get; set; }

        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set; }
        public double CustomerAccountBalans { get; set; }
        public string BankBranch  { get; set; }

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public List<AccountProcess> AccountSender { get; set; }
        public List<AccountProcess> AccountReceiver { get; set; }

  


    }
}
