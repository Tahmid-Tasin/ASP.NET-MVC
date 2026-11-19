using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Product
    {
   
        public int? id { get; set; }

        [Required(ErrorMessage ="Product name is required")]
        public string name { get; set; }

        [Required(ErrorMessage ="Product Price is required")]
        public double price { get; set; }

        [Required(ErrorMessage = "Product quantity is required")]
        public int quantity { get; set; }

        

    }
}
