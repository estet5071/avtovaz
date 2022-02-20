using System.ComponentModel;

namespace Model.Enums
{
    public enum AccessLevels
    {

        [Description("админ")] //для теста, все разделы доступны
        Admin,
        [Description("менеджер по продажам")]
        SalesManager,
        [Description("менеджер по персоналу")]
        PersonnelManager
    }
}
