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
            return View(new CityViewModel
            {
                Cities = repository.Cities.Count(),
                Population = repository.Cities.Sum(c => c.Population)
            });
        }
    }
}