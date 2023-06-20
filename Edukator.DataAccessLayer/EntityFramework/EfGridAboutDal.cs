using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfGridAboutDal:GenericRepository<AboutGrid>,IAboutGridDal
    {
        public List<AboutGrid> Get3AboutGrid()
        {
            Context context = new Context();
            return context.AboutGrids.OrderBy(x => x.AboutGridID).Take(3).ToList(); 
        }
    }
}
