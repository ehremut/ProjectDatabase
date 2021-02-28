using System.Collections.Generic;

namespace ProjectDatabase
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        
        public string RecipeName { get; set; }
        
        public List<Product> RecipeProducts { get; set; }
    }
}