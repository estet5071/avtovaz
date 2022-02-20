namespace Model.Enums
{
    internal static class CarModels
    {

        internal readonly static ICarModel[] Values = new ICarModel[] { new Granta(), new Vesta()}; //При добавлении новой машины изменять только данный массив и ComboBox. При этом порядок машин должел быть одинаковым(для совпадения индексов).

    }
}
