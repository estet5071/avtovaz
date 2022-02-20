using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ValidationAttributes
{
    internal class PhoneAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {

            string phoneNumber = value.ToString();

            if(phoneNumber.Length < 18)
                return false;
            
            for (int i = 4, phoneStringLength = 17; i < phoneStringLength; i++)
            {
                if (i == 7 || i == 8 || i == 12 || i == 15)
                    continue;

                if(!Char.IsDigit(phoneNumber[i]))
                    return false;

            }

            return true;
        }
    }
}
