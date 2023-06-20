﻿using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface IAboutGridDal:IGenericDal<AboutGrid>
    {
        List<AboutGrid> Get3AboutGrid();
    }
}
