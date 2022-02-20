using System.ComponentModel.DataAnnotations;

namespace Model.ValidationAttributes
{
    internal class SumPriceAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is decimal sum && sum != 0)
                return true;
            else
                return false;
        }
    }
}
