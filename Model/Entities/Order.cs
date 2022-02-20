using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Model.ValidationAttributes;

#nullable disable

namespace Model.Entities
{
    public partial class Order : BaseEntity
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public override int  Id { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateClose { get; set; }
        public bool Status { get; set; }

        [SumPrice(ErrorMessage = "сумма товаров не может быть равной 0")]
        public decimal Sum { get; set; }

        [Required(ErrorMessage = "выберите клиента")]
        public virtual Customer Customer { get; set; }

        [Required(ErrorMessage = "выберите работника")]
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
