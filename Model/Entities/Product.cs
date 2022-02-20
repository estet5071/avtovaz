using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Model.ValidationAttributes;



namespace Model.Entities
{
    public partial class Product : BaseEntity
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
            ProductPrices = new HashSet<ProductPrice>();
        }

        public override int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "выберите модель")]
        public string Model { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "выберите кузов")]
        public string BodyType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "выберите цвет")]
        public string Color { get; set; }
        public byte[] Photo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "выберите комплектацию")]
        public string Kit { get; set; }

       [DateTime(ErrorMessage = "выберите дату изготовления")]
        public DateTime DateCreate { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
