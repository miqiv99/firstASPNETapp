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
        public async Task<IActionResult> Details(int? id)
        {
            //include and theninclude functions retrieve related entities along with the main entitiy
            //in this identify, it means when fetching Dishes, it will also retrieve the DishIngredients entity
            //the same as then include will do(Ingredient  meanwhile DishIngredients)
            var dish = await _context.Dishes
                .Include(di => di.DishIngredients)
                .ThenInclude(i => i.ingredient)
                .FirstOrDefaultAsync(x => x.id == id);
            if (dish == null) 
            {
                return NotFound();
            }
            return View(dish);
        }
    }
}
