using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFindId_Click(object sender, EventArgs e)
        {
            var a = new ShoesApp.Business.Manager();
            var c = int.Parse(tBid.Text);
            var n = tbName.Text;
            var b = a.SearchS(c, n);

            ShoesList.Rows.Clear();
            foreach (var item in b)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Title });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Description });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PriceClient });
                ShoesList.Rows.Add(row);
            }
        }
    }
}
