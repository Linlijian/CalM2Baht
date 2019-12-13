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
    public partial class TableForm : Form
    {        
        public TableForm(decimal m, decimal r)
        {
            InitializeComponent();
          
            decimal _range = "60.0".AsDecimal();
            decimal _up = "10.0".AsDecimal();
            decimal _m = m - _range;

            m += _range;

            while (true)
            {
                labelBaht.Text += Convert.ToInt32((_m * r)).ToString() + " Baht\n"; //convert2int
                labelM.Text += Convert.ToInt32(((_m * r) / r)).ToString() + " M\n"; //convert2int
                _m += _up;

                if (_m == m)
                    break;
            }

            labelRate.Text = "Rate: " + r;
        }

        private void TableForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                //Do something
                e.Handled = true;
                this.Close();
            }
        }
    }
}
