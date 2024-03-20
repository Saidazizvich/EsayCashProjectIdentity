using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Entity.Model
{
    public class AccountProcess
    {
        public int AccountProcessId { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }

        public int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public CustomerAccount SunderCustomer { get; set; }

        public CustomerAccount ReceiverCustomer { get; set; }

        public string Comment { get; set; }
    }
}
