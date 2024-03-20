using EsayCashIdentityProject_Data.Abstract;
using EsayCashProjectIdentity_Business.Abstract;
using EsayCashProjectIdentity_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsayCashProjectIdentity_Business.Concreate
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public CustomerAccount GetById(int id)
        {
            return _customerAccountDal.GetById(id); 
        }

        public List<CustomerAccount> GetListAll()
        {
            return new List<CustomerAccount>().ToList(); 
        }

        public void TDelete(CustomerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public List<CustomerAccount> TGetCustomerList(int id)
        {
            return _customerAccountDal.GetCustomerList(id); 
        }

        public void TInsert(CustomerAccount t)
        {
            _customerAccountDal.Insert(t);  
        }

        public void TUpdate(CustomerAccount t)
        {
            _customerAccountDal.Update(t);  
        }
    }
}
