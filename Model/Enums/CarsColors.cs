using System.ComponentModel;

namespace Model.Enums
{
    internal enum VestaColors : byte
    {
        [Description("Красный 'Сердолик' (195)")]
        Red,
        [Description("Коричневый 'Ангкор' (246)")]
        Brown,
        [Description("Ярко-синий 'Дайвинг' (476)")]
        Blue,
        [Description("Серо-голубой 'Фантом' (496)")]
        Grey,
        [Description("Черный 'Маэстро' (653)")]
        Black,
        [Description("Серебристый 'Платина' (691)")]
        Silver,
        [Description("Белый 'Ледниковый' (221)")]
        White



    }

    internal enum GrantaColors : byte
    {
        [Description("Красный 'Сердолик' (195)")]
        Red,
        [Description("Ярко-синий 'Голубая планета' (418)")]
        Blue,
        [Description("Серебристый 'Рислинг' (610)")]
        Silver,
        [Description("Серебристо-серый 'Техно' (618)")]
        SilverGrey,
        [Description("Серебристо-темно-серый 'Борнео' (633)")]
        SilverBlack,
        [Description("Золотисто-коричневый 'Кориандр' (790)")]
        GoldBrown,
        [Description("Белый 'Белое облако' (240)")]
        White,
        [Description("Черный 'Пантера' (672)")]
        Black

    }



}
