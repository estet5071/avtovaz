namespace Model.Entities
{
    public partial class Wage : BaseEntity
    {
        public override int Id { get; set; }
        public decimal DaySalary { get; set; }
        public double PrizeRatio { get; set; }
        public int WorkDays { get; set; }
        public decimal TaxDeduction { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
