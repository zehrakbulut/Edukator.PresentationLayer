using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.Contact
{
    public class _ContactConnectionPartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _ContactConnectionPartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
