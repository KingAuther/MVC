using System.ComponentModel.DataAnnotations.Schema;

namespace MvcSportsStore.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime ReleaseDate { get; set; }
        public string Catergory { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }

}

