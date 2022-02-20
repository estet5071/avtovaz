using System;


namespace Presentation.ViewInterfaces
{
    public interface ISectionView : IView
    {

        event Action Add;
        event Action<string> Edit;
        event Action<string> Remove;
        event Action InitialFilling;
        event Action<string> ChangeSelectionRow;

        int CountOfRow { get; set; }

        void AddToDataGrid(params string[] entityInfo);

        void UpdateDataGrid(params string[] entityInfo);

        void RemoveFromDataGrid();
    }
}
