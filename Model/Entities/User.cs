namespace Model.Entities
{
    public partial class User : BaseEntity
    {
        public override int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public virtual Employee IdNavigation { get; set; }
    }
}
