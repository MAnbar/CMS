using Clinic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class ManageStock : Form
    {
        DBManager MyDBM = new DBManager();
        public ManageStock()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageStock_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemNameTB.Text == "" || ItemNameTB.Text == "New Item Name")
            {
                MessageBox.Show("Please Enter the Item Name");
                return;
            }
            if (PPITB.Text == "")
            {
                MessageBox.Show("Please Enter the Price Per Item");
                return;
            }
            int Quantity;
            if (QuantityTB.Text == "")
            {
                Quantity = 0;
            }
            else
            {
                Quantity = Convert.ToInt32(QuantityTB.Text);
            }

            MyDBM.AddStockItem(ItemNameTB.Text, Convert.ToInt32(PPITB.Text), Quantity);
            UpdateDataGrid();
        }
        private void UpdateDataGrid()
        {
            DataTable dt = MyDBM.GetAllStock();
            dt = MyDBM.GetAllStock();
            dataGrid.DataSource = dt;
            dataGrid.Refresh();
            this.dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value);

            MyDBM.DeleteStockItem(id);
            UpdateDataGrid();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int CurRow = dataGrid.CurrentRow.Index;
            int id = Convert.ToInt32(dataGrid.Rows[CurRow].Cells[0].Value);
            string ItemName = dataGrid.Rows[CurRow].Cells[1].Value.ToString();
            int PPI = Convert.ToInt32(dataGrid.Rows[CurRow].Cells[2].Value);
            int Quantity = Convert.ToInt32(dataGrid.Rows[CurRow].Cells[3].Value);

            MyDBM.UpdateStockItem(id, ItemName, PPI, Quantity);
        }
    }
}
