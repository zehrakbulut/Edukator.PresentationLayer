using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutAboutPartial : ViewComponent
    {
        private readonly IAboutGridService _aboutGridService;

        public _AboutAboutPartial(IAboutGridService aboutGridService)
        {
            _aboutGridService = aboutGridService;
        }

        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            ViewBag.aboutTitle = context.AboutGrids.OrderByDescending(x => x.AboutGridID).Select(y =>y.Title).FirstOrDefault();
            ViewBag.aboutDescription = context.AboutGrids.OrderByDescending(x => x.AboutGridID).Select(y => y.Description).FirstOrDefault();
            return View();
        }
        
    }
}
