using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Linq;

namespace Project.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var locations = _context.Locations.ToList();
            return View(locations);
        }
    }
}
