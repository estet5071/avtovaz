using System;
using System.Collections.Generic;

namespace Model.Enums
{
    internal static class EnumService
    {

        public static List<string> GetAllDescriptions(Type enumType)
        {
            List<string> strings = new List<string>();
            var values = Enum.GetValues(enumType);
            foreach (var item in values)
            {
                strings.Add(((Enum)item).GetEnumDescription());
            }
            return strings;

        }


    }
}
