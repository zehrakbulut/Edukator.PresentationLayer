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
    public class ProgressManager : IProgressService
    {
        private readonly IProgressDal _progressDal;

        public ProgressManager(IProgressDal progressDal)
        {
            _progressDal = progressDal;
        }

        public void TDelete(Progress t)
        {
            _progressDal.Delete(t);
        }

        public Progress TGetByID(int id)
        {
            return _progressDal.GetByID(id);
        }

        public List<Progress> TGetList()
        {
            return _progressDal.GetList();
        }

        public void TInsert(Progress t)
        {
            _progressDal.Insert(t);
        }

        public void TUpdate(Progress t)
        {
            _progressDal.Update(t);
        }
    }
}
