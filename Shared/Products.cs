using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//тут хранятся модели 
namespace Ecomm.Shared
{
    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] //for adding decimal field to db
        public decimal Price { get; set; }
    }
}
