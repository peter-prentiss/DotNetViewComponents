using System.Linq;
using DotNetViewComponents.Models;
namespace DotNetViewComponents.ViewComponents
{
    public class PocoViewComponent
    {
        private ICityRepository repository;
        public PocoViewComponent(ICityRepository repo)
        {
            repository = repo;
        }
        public string Invoke()
        {
            return $"{repository.Cities.Count()} cities, "
            + $"{repository.Cities.Sum(c => c.Population)} people";
        }
    }
}