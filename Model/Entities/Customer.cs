using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Model.Entities
{
    public partial class Customer : BaseEntity
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public override int Id { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "введите название")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "введите телефон")]
        [ValidationAttributes.Phone(ErrorMessage = "неверный номер телефона")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "неверный email")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "введите адрес")]
        public string Adress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
