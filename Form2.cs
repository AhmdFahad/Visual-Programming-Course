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

    public partial class Form2 : Form
    {
        public string LibName { get; set; } = "Test";

        public Form2()
        {
            InitializeComponent();
        }

        private static Form2 inst;
        public static Form2 GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Form2();
                return inst;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inst.LibName= textBox1.Text;
            textBox1.Clear();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
