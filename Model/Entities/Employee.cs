using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public partial class Employee : BaseEntity
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public override int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "заполните имя")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "заполните фамилию")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "заполните отчество")]
        public string MiddleName { get; set; }

        [Required]
        [ValidationAttributes.Phone(ErrorMessage = "неверно указан телефон")]
        public string Phone { get; set; }

       [EmailAddress(ErrorMessage = "неверно указана почта")]
        public string Email { get; set; }
        public string Adress { get; set; }
        public byte[] Photo { get; set; }
        public DateTime? Birthday { get; set; }

        [Required(ErrorMessage = "заполните должность")]
        public string Position { get; set; }

        public virtual User User { get; set; }
        public virtual Wage Wage { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
       

    }
}
