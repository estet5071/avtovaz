using Model.Entities;
using System.Collections.Generic;

namespace Model.ServiceAbstractions
{
    public interface IProductService : ISectionService<Product>
    {

       List<string> GetCarColors(int carIndex);
       List<string> GetCarBodys(int carIndex);

    }
}
