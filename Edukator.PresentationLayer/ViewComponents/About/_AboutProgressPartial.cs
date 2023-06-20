using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutProgressPartial : ViewComponent
    {
        private readonly IProgressService _progressService;
        private readonly ICourseService _courseService;

        public _AboutProgressPartial(IProgressService progressService, ICourseService courseService)
        {
            _progressService = progressService;
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            ViewBag.CourseName1 = context.Courses.Where(x => x.CourseID == 1).Select(y => y.Title).FirstOrDefault();
            ViewBag.CoursePercent1 = 76;

            ViewBag.CourseName2 = context.Courses.Where(x => x.CourseID == 2).Select(y => y.Title).FirstOrDefault();
            ViewBag.CoursePercent2 = 80;

            ViewBag.CourseName3 = context.Courses.Where(x => x.CourseID == 3).Select(y => y.Title).FirstOrDefault();
            ViewBag.CoursePercent3 = 96;

            ViewBag.CourseName4 = context.Courses.Where(x => x.CourseID == 4).Select(y => y.Title).FirstOrDefault();
            ViewBag.CoursePercent4 = 78;

            var values = _progressService.TGetList();
            return View(values);
        }
    }
}
