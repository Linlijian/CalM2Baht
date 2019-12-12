using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalM2Baht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal m = txtM.Text.AsDecimal();
                decimal r = txtRate.Text.AsDecimal();

                TableForm t = new TableForm(m, r);
                t.Show();
            }
            catch
            {
                MessageBox.Show("Please enter only numbers.");
            }
            finally
            {
                txtM.Text = null;
                txtRate.Text = null;
            }


        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtM.Text, "[^00-9.0]"))
            {
                MessageBox.Show("Please enter only numbers.");
                //txtM.Text = txtM.Text.Remove(txtM.Text.Length - 1);
                txtM.Text = null;
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRate.Text, "[^00-9.0]"))
            {
                MessageBox.Show("Please enter only numbers.");
                //txtM.Text = txtM.Text.Remove(txtM.Text.Length - 1);
                txtRate.Text = null;
            }
        }
    }
}
