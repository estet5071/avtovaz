using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.ServiceAbstractions;

namespace Model.Services
{
    public class CustomerService : BaseSectionService<Customer>, ICustomerService
    {
        public override void InitialLoad()
        {
            using AvtoVazContext context = new AvtoVazContext();
            DataForMainGrid = context.Customers.AsNoTracking().ToList();
        }

        
        public List<Customer> GetAll()
        {
            using AvtoVazContext context = new AvtoVazContext();
            return context.Customers.AsNoTracking().Include(c => c.Orders).ToList();
        }

        public bool PhoneIsUnique(string phone)
        {
            using AvtoVazContext context = new AvtoVazContext();
            if (context.Customers.FirstOrDefault(c => c.Phone == phone) == null)
            {
                return true;
            }
            return false;
        }
    }
}
