using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _CoursePartial:ViewComponent
    {
        private readonly ICourseService _courseSersvice;

        public _CoursePartial(ICourseService courseSersvice)
        {
            _courseSersvice = courseSersvice;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseSersvice.TGetCourseWithCategories();
            return View(values);
        }
    }
}
