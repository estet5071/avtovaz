using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace UI
{
    internal class BaseSectionView : MetroForm
    {

        private DataGridViewRow[] _rowsForSearch;

        public event Action InitialFilling;
        public event Action Add;
        public event Action<string> Edit;
        public event Action<string> Remove;
        public event Action<string> ChangeSelectionRow;

        virtual protected byte ComboBoxIndex { get; }
        virtual protected string SearchText { get; }
        virtual protected DataGridView MainGrid { get; }

        public void AddToDataGrid(params string[] entityInfo)
        {
            MainGrid.Rows.Add(entityInfo);
        }

        public void UpdateDataGrid(params string[] entityInfo)
        {
            int index = MainGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            MainGrid.Rows.RemoveAt(index);
            MainGrid.Rows.Insert(index, entityInfo);
        }

        public void RemoveFromDataGrid()
        {
            int index = MainGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            MainGrid.Rows.RemoveAt(index);
        }


        protected void Form_Load(object sender, EventArgs e)
        {
            InitialFilling?.Invoke();
            SetAllRows();

        }

      
        protected void AddButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count == 0)
                return;
            Edit?.Invoke((string)MainGrid.SelectedRows[0].Cells[0].Value);
        }

        protected void RemoveButton_Click(object sender, EventArgs e)
        {
            Remove?.Invoke((string)MainGrid.SelectedRows[0].Cells[0].Value);
        }

        
        protected void Grid_SelectionChanged(object sender, EventArgs e)
        {
          
            if (MainGrid.SelectedRows.Count > 0)
               ChangeSelectionRow?.Invoke((string)MainGrid.SelectedRows[0].Cells[0].Value);
            else
                ChangeSelectionRow?.Invoke(0.ToString());
        }


        protected void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

            MainGrid.Rows.Clear();

            if (string.IsNullOrEmpty(SearchText))
            {
                foreach (var item in _rowsForSearch)
                {
                    MainGrid.Rows.Add(item);
                }
                return;
            }

            var newRows = Search(SearchText, ComboBoxIndex);
            foreach (var item in newRows)
            {
                MainGrid.Rows.Add(item);
            }

        }

        private DataGridViewRow[] Search(string searchString, byte NumberOfCell)
        {
            return _rowsForSearch.Where(r => r.Cells[NumberOfCell].Value.ToString().ToLower().Contains(searchString.ToLower())).ToArray();

        }

        private void SetAllRows()
        {
            _rowsForSearch = new DataGridViewRow[MainGrid.Rows.Count];
            MainGrid.Rows.CopyTo(_rowsForSearch, 0);
        }

    }
}
