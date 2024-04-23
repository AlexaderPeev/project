using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class LocationsController : Controller
    {
        private readonly YourDbContext _context;

        public LocationsController(YourDbContext context)
        {
            _context = context;
        }
    }
}
