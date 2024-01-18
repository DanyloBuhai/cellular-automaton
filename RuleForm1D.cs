using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class RuleForm1D : Form
    {
        public RuleForm1D()
        {
            InitializeComponent();
            var dgvOnForm = this.Controls.OfType<DataGridView>();
            foreach (var dgv in dgvOnForm)
            {
                dgv.RowTemplate.MinimumHeight = dgv.Size.Height;
                dgv.Rows.Add();
                dgv.Rows[0].Cells[0].Style.BackColor = Color.White;
            }
        }

        private void dataGridView13_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.ClearSelection();
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            else dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Black;
        }

        private void btnSaveRule1D_Click(object sender, EventArgs e)
        {
            int counter = 0;
            var dgvOnForm = this.Controls.OfType<DataGridView>();
            foreach (var dgv in dgvOnForm)
            {
                DataForms.state[counter] = dgv.Rows[0].Cells[0].Style.BackColor == Color.Black ? true : false;
                counter++; 
            }
        }
    }
}
