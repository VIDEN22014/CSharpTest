using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class CSparseMatrix {
            List<CSparseCell> data;
            int dim=1;
            int[] dimValues;
            string name= "SparseMatrix";
            double value=1;
        }
        class CSparseCell{
            int[] dimValues;
            double value=1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
