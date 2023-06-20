using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutFeaturesPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutFeaturesPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetList();          
            return View(values);
        }
    }
}
