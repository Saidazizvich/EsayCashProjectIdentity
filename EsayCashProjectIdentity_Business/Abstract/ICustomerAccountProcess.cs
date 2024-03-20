using EsayCashProjectIdentity_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Business.Abstract
{
    public interface ICustomerAccountProcess : ICustomerAccountService<AccountProcess>
    {
        List<AccountProcess> TMyLastProcess(int id);
    }

}    
    
    
    
    
    