using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahemd_Fahad_Aub_hamdaha_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f =new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
