using System;


namespace Model.Entities
{
    public partial class ProductPrice : BaseEntity
    {
        public override int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DateChange { get; set; }
        public decimal Value { get; set; }

        public virtual Product Product { get; set; }
    }
}
