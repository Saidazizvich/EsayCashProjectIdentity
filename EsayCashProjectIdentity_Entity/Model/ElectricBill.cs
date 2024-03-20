using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Entity.Model
{
    public class ElectricBill
    {
   
        public int ElectricBillId { get; set; }
        public string ContactNumber { get; set; }
        public string ContactName { get; set; }
        public DateTime BillingPeriod { get; set; }
        public DateTime PaymentDueDate { get; set; }

        public decimal Amount { get; set; }

        public bool PaidStatus { get; set; }


    }
}
