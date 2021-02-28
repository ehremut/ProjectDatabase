using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace ProjectDatabase
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
        
        public List<Product> CategoryProducts { get; set; }
    }
}