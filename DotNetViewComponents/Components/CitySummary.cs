using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotNetViewComponents.Models;

namespace DotNetViewComponents.Components
{
    public class CitySummary : ViewComponent
    {
        private ICityRepository repository;

        public CitySummary(ICityRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return Content("This is a <h3><i>string</i></h3>");
        }
    }
}