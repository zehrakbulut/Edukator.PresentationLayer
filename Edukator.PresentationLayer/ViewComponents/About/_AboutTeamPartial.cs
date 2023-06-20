using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutTeamPartial : ViewComponent
    {
        private readonly ITeamService _teamService;

        public _AboutTeamPartial(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            ViewBag.teamTitle1 = context.Teams.Where(x => x.TeamID == 1).Select(y => y.Title1).FirstOrDefault();
            ViewBag.teamTitle2 = context.Teams.Where(x => x.TeamID == 1).Select(y => y.Title2).FirstOrDefault();
            var values = _teamService.TGetList();
            return View(values);
        }
    }
}
