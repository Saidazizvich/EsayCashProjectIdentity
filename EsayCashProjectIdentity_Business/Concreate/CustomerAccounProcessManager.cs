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
    public class CustomerAccounProcessManager : ICustomerAccountProcess
    {
        private readonly ICustomerAccountProcessDal _processDal;

        public CustomerAccounProcessManager(ICustomerAccountProcessDal processDal)
        {
            _processDal = processDal;
        }

        public AccountProcess GetById(int id)
        {
            return _processDal.GetById(id); 
        }

        public List<AccountProcess> GetListAll()
        {
            return new List<AccountProcess>().ToList();
        }

        public void TDelete(AccountProcess t)
        {
            _processDal.Delete(t);
        }

        public void TInsert(AccountProcess t)
        {
            _processDal.Insert(t);  
        }

        public List<AccountProcess> TMyLastProcess(int id)
        {
            return _processDal.MyLastProcess(id);
        }

        public void TUpdate(AccountProcess t)
        {
            _processDal.Update(t);  
        }
    }
}
