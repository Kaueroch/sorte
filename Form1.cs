using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licao9
{
    public partial class Form1 : Form
    {
        int num1, num2, i ;

        private void txtfim_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtfim.Text);
        }

        private void txtinicio_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtinicio.Text);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (i = num1; i <= num2; i++)
            {
                s = s + 1;
            }
            MessageBox.Show("Somatoria: " + s);
        }
    }
}
