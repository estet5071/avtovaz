using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ValidationAttributes
{
    internal class DateTimeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is DateTime dateTime)
            {
                return dateTime.ToShortDateString() != DateTime.Now.ToShortDateString();
            }
            return false;
        }
    }
}
