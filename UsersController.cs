using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class UsersController : Controller
    {
        private readonly YourDbContext _context;

        public UsersController(YourDbContext context)
        {
            _context = context;
        }
    }
}
