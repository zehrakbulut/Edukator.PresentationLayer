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
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDal _reviewDal;

        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public void TDelete(Review t)
        {
            _reviewDal.Delete(t);
        }

        public Review TGetByID(int id)
        {
            return _reviewDal.GetByID(id);
        }

        public List<Review> TGetList()
        {
            return _reviewDal.GetList();
        }

        public void TInsert(Review t)
        {
            _reviewDal.Insert(t);
        }

        public void TUpdate(Review t)
        {
            _reviewDal.Update(t);
        }
    }
}
