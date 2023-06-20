using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrete
{
    public class JoinManager : IJoinService
    {
        private readonly IJoinDal _joinDal;

        public JoinManager(IJoinDal joinDal)
        {
            _joinDal = joinDal;
        }

        public void TDelete(Join t)
        {
            _joinDal.Delete(t);
        }

        public Join TGetByID(int id)
        {
            return _joinDal.GetByID(id);
        }

        public List<Join> TGetList()
        {
            return _joinDal.GetList();
        }

        public void TInsert(Join t)
        {
            _joinDal.Insert(t);
        }

        public void TUpdate(Join t)
        {
            _joinDal.Update(t);
        }
    }
}
