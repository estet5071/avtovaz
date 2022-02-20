using Model.Entities;

namespace Model.ServiceAbstractions
{
    public interface IOrderService : ISectionService<Order>
    {

        Employee[] GetEmployees();

        Customer[] GetCustomers();

        Product[] GetAllProducts();

        Employee FindEmployee(string fullName);

        Customer FindCustomer(string name);

       
    }
}
