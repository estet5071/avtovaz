namespace Model.Entities
{
    public partial class OrderProduct : BaseEntity
    {
        public override int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
