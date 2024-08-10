using Microsoft.AspNetCore.Mvc;
using firstlearning.Data;
using firstlearning.Models;
using Microsoft.EntityFrameworkCore;

namespace firstlearning.Controllers
{
    public class MenuController : Controller
    {
        private readonly MenuContext _context;
        public MenuController(MenuContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Dishes.ToListAsync());
        }
    }
}
