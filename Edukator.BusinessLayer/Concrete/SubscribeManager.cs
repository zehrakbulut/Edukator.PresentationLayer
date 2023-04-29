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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public void TDelete(Subscribe t)
        {
            _subscribeDal.Delete(t);
        }

        public Subscribe TGetByID(int id)
        {
            return _subscribeDal.GetByID(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeDal.Update(t);
        }
    }
}
