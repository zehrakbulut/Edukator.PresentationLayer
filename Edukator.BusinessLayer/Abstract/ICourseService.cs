﻿using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Abstract
{
    public interface ICourseService:IGenericService<Course>
    {
        List<Course> TGetCourseWithCategory();

        List<Course> TGetCourseWithCategories();

        List<Course> TGetLast5Course();
    }
}
