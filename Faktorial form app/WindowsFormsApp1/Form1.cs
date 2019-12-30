using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                long x = Convert.ToInt32(txtb1.Text);

               long w = Fakt(x);
               txtb2.Text = w.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Reqem daxil ele","Sehvvvvv",MessageBoxButtons.OK);
            }
            
        }

        static long Fakt(long i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                i *= Fakt(i - 1);
                return i;
            }
        }
    }
}
