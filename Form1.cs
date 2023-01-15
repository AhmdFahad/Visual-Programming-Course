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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void newLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = Form2.GetForm;
            f.Show();
            
            listView1.Items.Add(f.LibName);


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("hello");

        }
    }
}
