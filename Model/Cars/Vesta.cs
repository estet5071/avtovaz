using System.Collections.Generic;

namespace Model.Enums
{
    internal class Vesta : ICarModel
    {
        public List<string> GetAllCarBodys()
        {
          return EnumService.GetAllDescriptions(typeof(VestaCarBodys));
            

        }

        public List<string> GetAllColors()
        {
            return EnumService.GetAllDescriptions(typeof(VestaColors));
        }
    }
}
