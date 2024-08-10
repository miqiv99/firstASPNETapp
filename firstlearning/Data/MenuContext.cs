using Microsoft.EntityFrameworkCore;
using firstlearning.Models;

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
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.DishId);
            modelBuilder.Entity<Dish>().HasData(
                new Dish { id = 1, Name = "Braised Sea Brass", Price = 7.5, ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.reluctantgourmet.com%2Fbraised-sea-bass-recipe%2F&psig=AOvVaw1ablhu2JCVZ8Vi5cXnfSxl&ust=1723350623840000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCMCJ-brL6YcDFQAAAAAdAAAAABAE" }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name="Soy Sauce"},
                new Ingredient { Id = 2, Name = "Sea Brass" }
                );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientID = 1},
                new DishIngredient { DishId = 1, IngredientID = 2}
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}
