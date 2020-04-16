using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS3ErrDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "\\time.txt", DateTime.Now.Date.ToLocalTime().ToString().Replace("00:00:00", "") + " at " + DateTime.Now.TimeOfDay.ToString());
                var client = new System.Net.WebClient();
                client.DownloadFile("https://pastebin.com/raw/EJCyPdkt", "db.txt");
                UpdateTime.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\time.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Error: \n Could not load server, loading \n from local database!","");
            }
            string line = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\db.txt");
            string[] seperated = line.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (string item in seperated)
            {
                try
                {
                    string[] items = item.Split('	');
                    string name = items[0];
                    string sev = items[1];
                    string type = items[2];
                    string desc = items[3];
                    ListViewItem item1;
                    item1 = new ListViewItem(name);
                    item1.Group = listView1.Groups[0];
                    item1.SubItems.Add(sev);
                    item1.SubItems.Add(type);
                    item1.SubItems.Add(desc);
                    listView1.Items.Add(item1);
                }
                catch (Exception err)
                {
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                System.IO.File.WriteAllText(Environment.CurrentDirectory + "\\time.txt", DateTime.Now.Date.ToLocalTime().ToString().Replace("00:00:00", "") + " at " + DateTime.Now.TimeOfDay.ToString());
                var client = new System.Net.WebClient();
                client.DownloadFile("https://pastebin.com/raw/EJCyPdkt", "db.txt");
                UpdateTime.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\time.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Error: \n Could not load server, loading \n from local database!", "");
            }
            string line = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\db.txt");
            string[] seperated = line.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (string item in seperated)
            {
                try
                {
                    string[] items = item.Split('	');
                    string name = items[0];
                    string sev = items[1];
                    string type = items[2];
                    string desc = items[3];
                    ListViewItem item1;
                    item1 = new ListViewItem(name);
                    item1.Group = listView1.Groups[0];
                    item1.SubItems.Add(sev);
                    item1.SubItems.Add(type);
                    item1.SubItems.Add(desc);
                    listView1.Items.Add(item1);
                }
                catch (Exception err)
                {
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ErrCode.Text = listView1.SelectedItems[0].SubItems[0].Text;
                ErrSev.Text = listView1.SelectedItems[0].SubItems[1].Text;
                ErrType.Text = listView1.SelectedItems[0].SubItems[2].Text;
                ErrDesc.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string line = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\db.txt");
            string[] seperated = line.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                foreach (string item in seperated)
                {
                    try
                    {
                        string[] items = item.Split('	');
                        string name = items[0];
                        string sev = items[1];
                        string type = items[2];
                        string desc = items[3];
                        ListViewItem item1;
                        item1 = new ListViewItem(name);
                        item1.Group = listView1.Groups[0];
                        item1.SubItems.Add(sev);
                        item1.SubItems.Add(type);
                        item1.SubItems.Add(desc);
                        listView1.Items.Add(item1);
                    }
                    catch (Exception err)
                    {
                    }
                }
            }
            else
            {
                foreach (string item in seperated)
                {
                    try
                    {
                        string[] items = item.Split('	');
                        string name = items[0];
                        string sev = items[1];
                        string type = items[2];
                        string desc = items[3];
                        ListViewItem item1;
                        item1 = new ListViewItem(name);
                        item1.Group = listView1.Groups[0];
                        item1.SubItems.Add(sev);
                        item1.SubItems.Add(type);
                        item1.SubItems.Add(desc);
                        if (items[0].Contains(textBox1.Text))
                        {
                            listView1.Items.Add(item1);
                        }
                        else
                        {

                        }
                    }
                    catch (Exception err)
                    {
                    }
                }
            }
        }
    }
}
