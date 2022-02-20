using Microsoft.EntityFrameworkCore;
using Model.Enums;
using Model.Entities;
using Model.ServiceAbstractions;
using System.Collections.Generic;
using System.Linq;

namespace Model.Services
{
    public class ProductService : BaseSectionService<Product>, IProductService
    {
        public List<string> GetCarBodys(int carIndex)
        {
           return CarModels.Values[carIndex].GetAllCarBodys();
        }



        public List<string> GetCarColors(int carIndex)
        {
            return CarModels.Values[carIndex].GetAllColors();
        }



        public override void InitialLoad()
        {
            using AvtoVazContext context = new AvtoVazContext();
            DataForMainGrid = context.Products.AsNoTracking().ToList();
        }

        public List<Product> GetAll()
        {
            using AvtoVazContext context = new AvtoVazContext();
            return context.Products.AsNoTracking().Include(p => p.ProductPrices).Include(p => p.OrderProducts).ToList();
        }


    }
}
