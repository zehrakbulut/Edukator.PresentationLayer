using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Review
    {
        public int ReviewID { get; set; }

        public string ReviewName { get; set; }

        public string ReviewTitle { get; set; }

        public string ReviewDescription { get; set; }
    }
}
