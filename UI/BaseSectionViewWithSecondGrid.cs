using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    internal class BaseSectionViewWithSecondGrid : BaseSectionView
    {
       
        public event Action ToggleClick;

        protected virtual DataGridView SecondGrid { get; }

        public void AddDataToSecondGrid(params string[] entityInfo)
        {
            SecondGrid.Rows.Add(entityInfo);
        }

        public void ClearSecondGrid()
        {
            SecondGrid.Rows.Clear();
        }

        public void RemoveFromSecondGrid()
        {
            int index = SecondGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            SecondGrid.Rows.RemoveAt(index);
        }

        public void ChangeSizeOfMainGrid(Size size)
        {
            MainGrid.Size = size;
        }

        protected void Toggle_Click(object sender, EventArgs args)
        {
            ToggleClick?.Invoke();
        }



    }
}
