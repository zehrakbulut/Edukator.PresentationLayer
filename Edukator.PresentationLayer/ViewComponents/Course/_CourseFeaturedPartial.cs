using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Course
{
    public class _CourseFeaturedPartial : ViewComponent
    {
        private readonly ICourseService _courseService;

        public _CourseFeaturedPartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetCourseWithCategory();
            return View(values);
        }
    }
}
