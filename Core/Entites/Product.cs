

using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Product :BaseEntity
    {
        public required string Name  { get; set; }
        [Column(TypeName = "decimal(18,4)")] // <--
        public decimal Price { get; set; }
        public required string PictureUrl { get; set; }
        public required string Description { get; set; }
        public required ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public required ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }

    
    }

   
}