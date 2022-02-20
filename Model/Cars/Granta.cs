using System.Collections.Generic;

namespace Model.Enums
{
    internal class Granta : ICarModel
    {
        public List<string> GetAllCarBodys()
        {
            return EnumService.GetAllDescriptions(typeof(GrantaCarBodys));


        }

        public List<string> GetAllColors()
        {
            return EnumService.GetAllDescriptions(typeof(GrantaColors));
        }
    }
}
