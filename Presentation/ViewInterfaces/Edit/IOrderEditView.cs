using System;

namespace Presentation.ViewInterfaces.Edit
{
    public interface IOrderEditView : ISectionEditView
    {

       event Action AddProductToBasket;
       event Action RemoveProductFromBasket;

        bool OrderStatus { get; set; }
        DateTime DateCreate { get; set; }
        string Client { get; set; }
        string Employee { get; set; }
        decimal OrderSum { get; set; }

        void AddToBasketGrid(params string[] values);

        void ClearBasketGrid();

        int RemoveFromBasketGrid(out decimal productPrice);

        void AddToProductsGrid(params string[] values);
        void ClearProductGrid();

        void AddCustomersToComboBox(string[] values);

        void AddEmployeesToComboBox(string[] values);

        int[] GetIdOfProductsInBasket();

        string[] GetProductForAddToBasketGrid();

        void ClearItemsOfComboBoxs();
    }
}
