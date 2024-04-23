using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    public class TasksController : Controller
    {
        private readonly YourDbContext _context;

        public TasksController(YourDbContext context)
        {
            _context = context;
        }
    }
}
