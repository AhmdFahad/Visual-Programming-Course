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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string name;
        public static int num;
        private void Form3_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Form1.n; i++)
                listBox1.Items.Add(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            num = listBox1.SelectedIndex;
            Close();
        }
    }
}
