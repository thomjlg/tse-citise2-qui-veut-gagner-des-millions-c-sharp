using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_C_sharp
{
    public partial class Form3 : Form
    {
        void palier_actuel()
        {

        }

        public Form3()
        {
            string value_palier = "←" ;
            InitializeComponent();
            label1.Text = "15.     1 000 000 €\n14.       300 000 €\n13.       150 000 €\n12.       100 000 €\n11.        72 000 €\n10.        48 000 €\n 9.        24 000 €\n 8.        12 000 €\n 7.         6 000 €\n 6.         3 000 €\n 5.         1 500 €\n 4.           800 €\n 3.           500 €\n 2.           300 €\n 1.           200 €\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
