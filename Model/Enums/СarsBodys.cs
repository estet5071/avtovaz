using System.ComponentModel;

namespace Model.Enums
{
    internal enum VestaCarBodys       
    {
        Sedan,
        Cross,
        Sw,
        SwCross,
        CNG,
        Sport

    }

    internal enum GrantaCarBodys
    {
        Sedan,
        [Description("Лифтбек")]
        Liftback,
        [Description("Хэтчбек")]
        Hatchback,
        [Description("Универсал")]
        StationWagon,
        Cross,
        DriveActive

    }


}
