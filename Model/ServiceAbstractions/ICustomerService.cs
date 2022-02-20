using Model.Entities;

namespace Model.ServiceAbstractions
{
    public interface ICustomerService : ISectionService<Customer>
    {
        bool PhoneIsUnique(string phone);

    }
}
