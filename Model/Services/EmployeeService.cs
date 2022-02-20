using System.Collections.Generic;
using Model.ServiceAbstractions;
using Model.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model.Enums;

namespace Model.Services
{
    public class EmployeeService : BaseSectionService<Employee>, IEmployeeService
    {
        public List<string> GetAccessLevels()
        {
           return EnumService.GetAllDescriptions(typeof(AccessLevels));
        }

        public List<string> GetEmployeePositions()
        {
            return EnumService.GetAllDescriptions(typeof(EmployeePositions));
        }

        public string GetHashPassword(string password)
        {
            if (PasswordHasher.IsHashSupported(password))
                return password;

            return PasswordHasher.Hash(password);
        }

        public (decimal result, decimal tax) GetResultAndTax(decimal DaySalary, double PrizeRatio, int WorkDays, decimal TaxDeduction)
        {
            if(DaySalary == 0 || WorkDays == 0)
                return (0,0);

            decimal ndflPercent = 0.13m;
            decimal salaryWithoutTax = (DaySalary + (decimal)PrizeRatio * DaySalary) * WorkDays;
            decimal ndfl = (salaryWithoutTax - TaxDeduction) * ndflPercent;
            decimal result = salaryWithoutTax - ndfl;
            return (result, ndfl);

        }

        public override void InitialLoad()
        {
            using AvtoVazContext context = new AvtoVazContext();
            DataForMainGrid = context.Employees.AsNoTracking().Include(e => e.User).ToList();
        }

        public bool LoginIsUnique(string login)
        {
            using AvtoVazContext context = new AvtoVazContext();
            if (context.Users.FirstOrDefault(u => u.Login == login) == null)
            {
                return true;
            }
            return false;
        }

        public bool PhoneIsUnique(string phone)
        {
            using AvtoVazContext context = new AvtoVazContext();
            if (context.Employees.FirstOrDefault(e => e.Phone == phone) == null)
            {
                return true;
            }
            return false;
        }
    }
}
