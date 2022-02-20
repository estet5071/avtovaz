using System;
using System.Drawing;

namespace Presentation.ViewInterfaces
{
    public interface ISectionViewWithSecondGrid : ISectionView
    {

        public event Action ToggleClick;

        Size SizeOfMainGridWithSecond{ get; }
        Size SizeOfMainGridWithoutSecond { get; }
        bool ToggleState { get; }

        
        void AddDataToSecondGrid(params string[] entityInfo);
        void ClearSecondGrid();

        void RemoveFromSecondGrid();

        void ChangeSecondGridVisible(bool IsVisible);

        void ChangeSizeOfMainGrid(Size size);

    }
}
