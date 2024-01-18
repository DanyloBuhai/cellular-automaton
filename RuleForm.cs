using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class RuleForm : Form
    {
        public RuleForm()
        {
            InitializeComponent();
            var dgvOnForm = this.Controls.OfType<DataGridView>();
            foreach (var dgv in dgvOnForm)
            {
                dgv.RowTemplate.MinimumHeight = dgv.Size.Height / 2;
                dgv.Rows.Add();
                dgv.Rows.Add();
                dgv.Rows[0].Cells[0].Style.BackColor = Color.White;
                dgv.Rows[0].Cells[1].Style.BackColor = Color.White;
                dgv.Rows[1].Cells[0].Style.BackColor = Color.White;
                dgv.Rows[1].Cells[1].Style.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.ClearSelection();
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Black)
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            else dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Black;
        }

        private void btnSaveBlockRule_Click(object sender, EventArgs e)
        {
            int counter = 0;
            var dgvOnForm = this.Controls.OfType<DataGridView>();
            foreach (var dgv in dgvOnForm)
            {
                DataForms.RuleBlock[counter] = saveRule(dgv);
                counter++;
            }
        }

        Block saveRule(DataGridView dgv)
        {
            Block block = new Block();
            block.ul = dgv.Rows[0].Cells[0].Style.BackColor == Color.Black ? true : false;
            block.ur = dgv.Rows[0].Cells[1].Style.BackColor == Color.Black ? true : false;
            block.bl = dgv.Rows[1].Cells[0].Style.BackColor == Color.Black ? true : false;
            block.br = dgv.Rows[1].Cells[1].Style.BackColor == Color.Black ? true : false;
            return block;
        }
    }
}
