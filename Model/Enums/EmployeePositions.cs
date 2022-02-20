using System.ComponentModel;

namespace Model.Enums
{
    internal enum EmployeePositions : byte
    {
        [Description("менеджер по продажам")]
        SalesManager,
        [Description("инженер")]
        Engineer,
        [Description("администратор базы данных")]
        DatabaseAdministrator,
        [Description("менеджер по персоналу")]
        PersonnelManager,
        [Description("программист станков с ЧПУ")]
        MachineProgrammer,
        [Description("начальник смены")]
        ShiftSupervisor

    }
}
