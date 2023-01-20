using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public static int numberLibrary = 0;
        public static string[] arr;


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
            panel1.Hide();
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
               //MessageBox.Show("You select the "+a+" library ");
            }
            catch{
            }
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
            try
            {
                numberLibrary = listView1.Items.Count;
                arr = new string[numberLibrary];
                for (int i = 0; i < numberLibrary; i++)
                {
                    arr[i] = listView1.Items[i].Text;
                }
                Form3 f = Form3.GetForm;
                f.ShowDialog();
                listView1.Items[Form3.num].SubItems.Add(Form3.name);
            }
            catch {
                MessageBox.Show("choose library");
            }

            checkedListBox1.Items.Clear();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    checkedListBox1.Items.Add(item.SubItems[i].Text);
                }

            }
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

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void saveToFile(ListView lv)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        
                        foreach (ListViewItem item in lv.Items)
                        {
                            for (int i = 1; i < item.SubItems.Count; i++) {
                                sw.Write("{0}{1}{2}", item.SubItems[0].Text, " : ", item.SubItems[i].Text+" ");
                            }
                            sw.WriteLine(" ,");
                        }

                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Items[a].SubItems.RemoveAt(checkedListBox1.SelectedIndex+1);
            panel1.Hide();


            checkedListBox1.Items.Clear();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    checkedListBox1.Items.Add(item.SubItems[i].Text);
                }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveToFile(listView1);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string Name = toolStripTextBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                foreach (ListViewItem item in listView1.Items) {
                    for (int i = 1; i < item.SubItems.Count; i++) {
                        if (item.SubItems[i].Text == Name)
                        {
                            MessageBox.Show("Found n Library : " + item.Text+" is "+ i +"in the lsit");
                            return;
                        }
                    }
                
                }
                MessageBox.Show("not Found");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2 && listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].BeginEdit();
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.SelectedItems[0].BeginEdit();
            }
            catch { }
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lightThemeToolStripMenuItem.Checked == false)
            {
                lightThemeToolStripMenuItem.Checked = true;
                Form2 f = Form2.GetForm;
                f.BackColor= Color.FromArgb(34, 40, 49);
                this.BackColor = Color.FromArgb(34, 40, 49);
                f.label1.ForeColor= Color.FromArgb(238, 238, 238); ;
                label1.ForeColor= Color.FromArgb(238, 238, 238); ;
                label2.ForeColor= Color.FromArgb(238, 238, 238); ;

                Form3 f3 = Form3.GetForm;
                f3.label1.ForeColor = Color.FromArgb(238, 238, 238);
                f3.label2.ForeColor = Color.FromArgb(238, 238, 238);

            }
            else {
                lightThemeToolStripMenuItem.Checked = false;
                this.BackColor= Color.FromArgb(238, 238, 238); ; ;
                Form2 f = Form2.GetForm;
                f.BackColor = Color.FromArgb(238, 238, 238); ;
                f.label1.ForeColor = Color.Black;
                label1.ForeColor= Color.Black;
                label2.ForeColor= Color.Black;
                
                Form3 f3 = Form3.GetForm;
                f3.BackColor = Color.FromArgb(238, 238, 238);
                f3.label1.ForeColor = Color.Black;
                f3.label2.ForeColor = Color.Black;

            }
        }
    }
    }

