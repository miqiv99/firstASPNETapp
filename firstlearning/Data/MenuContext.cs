using firstlearning.Models;
using Microsoft.EntityFrameworkCore;

namespace firstlearning.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientID
            });
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientID);
            modelBuilder.Entity<Dish>().HasData(
                new Dish { id = 1, Name = "Braised Sea Brass", Price = 7.5, ImageUrl = "https://img2.baidu.com/it/u=132226737,2986947579&fm=253&fmt=auto&app=138&f=JPEG?w=800&h=1067" }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Soy Sauce" },
                new Ingredient { Id = 2, Name = "Sea Brass" }
                );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientID = 1 },
                new DishIngredient { DishId = 1, IngredientID = 2 }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}
