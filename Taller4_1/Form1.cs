using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int i, num, total;
            num = Convert.ToInt32(txtNumero.Text);
            for (i = 1; i <= 10; i++)
            {
                total = i * num;
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[i - 1].Cells[0].Value = num;
                dataGridView1.Rows[i - 1].Cells[1].Value = i;
                dataGridView1.Rows[i - 1].Cells[2].Value = total;
            }
                
        }
    }
}
