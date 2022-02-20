using Model.Entities;
using System.Collections.Generic;

namespace Model.ServiceAbstractions
{
    public interface IEmployeeService : ISectionService<Employee>
    {
        bool PhoneIsUnique(string phone);
        bool LoginIsUnique(string login);
        string GetHashPassword(string password);
        List<string> GetEmployeePositions();
        List<string> GetAccessLevels();
        (decimal result, decimal tax) GetResultAndTax(decimal DaySalary, double PrizeRatio, int WorkDays, decimal TaxDeduction);
    }
}
