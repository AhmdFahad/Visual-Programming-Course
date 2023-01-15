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

        public static int n = 0;


        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void newLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2.GetForm.ShowDialog();
            add();
            

        }
        public void add() {
            listView1.Items.Add(Form2.GetForm.LibName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form2.GetForm.LibName);
        }

        private void deleteLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems) { 
                listView1.Items.Remove(item);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            listView1.ForeColor = colorDialog1.Color;
        }
        static int a=0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                a = listView1.SelectedIndices[0];
                MessageBox.Show("You select the "+a+" library ");
            }
            catch{ }
                checkedListBox1.Items.Clear();
            foreach (ListViewItem item in listView1.SelectedItems) {
                for(int i =1;i<item.SubItems.Count;i++) {
                    checkedListBox1.Items.Add( item.SubItems[i].Text);                        
                }
                
            }

                
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dublacteLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem t = new ListViewItem();
                t.Text = item.Text;
                listView1.Items.Add(t);
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    t.SubItems.Add(item.SubItems[i].Text);
                }
            }
        }

        private void addBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n = listView1.Items.Count;
            Form3 f = new Form3();
            f.ShowDialog();
            listView1.Items[Form3.num].SubItems.Add(Form3.name);

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
                MessageBox.Show("You delete the book " + listView1.Items[a].SubItems[checkedListBox1.SelectedIndex].ToString());
                listView1.Items[a].SubItems.RemoveAt(checkedListBox1.SelectedIndex);

            }
            catch
            {
            }

        }


    }
    }

