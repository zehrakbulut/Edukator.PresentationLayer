using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutJoinPartial : ViewComponent
    {
        private readonly IJoinService _joinService;

        public _AboutJoinPartial(IJoinService joinService)
        {
            _joinService = joinService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _joinService.TGetList();
            return View(values);
        }
    }
}
