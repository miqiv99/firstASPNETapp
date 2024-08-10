namespace firstlearning.Models
{
    public class DishIngredient
    {
        public int DishId { get; set; }
        public int IngredientID { get; set; }
        public Ingredient ingredient { get; set; }
        public Dish Dish { get; set; }
    }
}
