using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CaclulateButton_Click(object sender, EventArgs e)
        {
            double input;
            double percent;
            
            if(Double.TryParse(TotalTextBox.Text, out input))
            {
                percent = Double.Parse(percentTipUpdown.Value.ToString());
                TipTextBox.Text = (input * (1 + percent/100)).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input(s)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
