using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Enums;
using Model.ServiceAbstractions;

namespace Model.Services
{
    public class OrderService : BaseSectionService<Order>, IOrderService
    {
        public Customer[] GetCustomers()
        {
            using AvtoVazContext context = new AvtoVazContext();
            return context.Customers.ToArray();
        }

        public Employee[] GetEmployees()
        {
            using AvtoVazContext context = new AvtoVazContext();
            return context.Employees.Where(e => e.Position == EmployeePositions.SalesManager.GetEnumDescription()).ToArray();
        }

        public Product[] GetAllProducts()
        {
            using AvtoVazContext context = new AvtoVazContext();
            return context.Products.Include(p => p.ProductPrices).ToArray();
        }

        public override void InitialLoad()
        {
            using AvtoVazContext context = new AvtoVazContext();
            DataForMainGrid = context.Orders.AsNoTracking().Include(o => o.Employee).Include(o => o.Customer).Include(o => o.OrderProducts).ToList();
        }


        public Customer FindCustomer(string name)
        {
            if (_context == null)
                _context = new AvtoVazContext();
            return _context.Customers.First(c => c.Name == name);
        }

        public Employee FindEmployee(string fullName)
        {

             string[] partsOfFullName = fullName.Split(' ');
             return  _context.Employees.First(e => e.LastName == partsOfFullName[0] && e.Name == partsOfFullName[1] && e.MiddleName == partsOfFullName[2]);
        }

        public List<Order> GetAll()
        {
            using AvtoVazContext context = new AvtoVazContext();
            return context.Orders.AsNoTracking().Include(o => o.Employee).Include(o => o.Customer).Include(o => o.OrderProducts).ToList();
        }

    }
}
