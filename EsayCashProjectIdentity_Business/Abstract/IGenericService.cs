using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Business.Abstract
{
     public interface ICustomerAccountService<T> where T : class 
     {
        void TInsert(T t);
        void TUpdate(T t);
        void TDelete(T t);

        T GetById(int id);

        List<T> GetListAll();
     }
    
}
