using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCaptive
{
    public partial class Configure_AC : Form
    {
        private string config_file_path = (Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData) +  @"\AutoCaptive\accounts.txt");
        public Configure_AC()
        {
            InitializeComponent();
            loadinfo();
        }
        private void loadinfo()
        {
            if(File.Exists(config_file_path))
            {
                string[] arr = File.ReadLines(config_file_path).ToArray();
                int arrlen = arr.Length;
                if (arrlen == 0) return;
                String[] cred = arr[0].Split();
                textBox1.Text = cred[0];
                textBox2.Text = cred[1];
                arrlen--;

                if (arrlen == 0) return;
                cred = arr[1].Split();
                textBox3.Text = cred[0];
                textBox4.Text = cred[1];
                arrlen--;

                if (arrlen == 0) return;
                cred = arr[2].Split();
                textBox5.Text = cred[0];
                textBox6.Text = cred[1];
                arrlen--;

                if (arrlen == 0) return;
                cred = arr[3].Split();
                textBox7.Text = cred[0];
                textBox8.Text = cred[1];
                arrlen--;

                if (arrlen == 0) return;
                cred = arr[4].Split();
                textBox9.Text = cred[0];
                textBox10.Text = cred[1];
                arrlen--;

            }
            else
            {
                return;
            }
        }

        private void writeinfo()
        {
            String[] Account = new String[5];
            int counter = 0;
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                Account[counter] = textBox1.Text + " " + textBox2.Text;
                counter++;
            }

            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                Account[counter] = textBox3.Text + " " + textBox4.Text;
                counter++;
            }

            if (!string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
            {
                Account[counter] = textBox5.Text + " " + textBox6.Text;
                counter++;
            }

            if (!string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox8.Text))
            {
                Account[counter] = textBox7.Text + " " + textBox8.Text;
                counter++;
            }

            if (!string.IsNullOrWhiteSpace(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
            {
                Account[counter] = textBox9.Text + " " + textBox10.Text;
                counter++;
            }

            if(counter == 0)
            {
                MessageBox.Show("Enter atleast one account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Kill AutoCaptiveBase Process because it is also using the file
            foreach (Process proc in Process.GetProcessesByName("AutoCaptiveBase"))
            {
                proc.Kill();
                proc.WaitForExit();
            }

            Directory.CreateDirectory(Path.GetDirectoryName(config_file_path));

            FileStream faccount = File.Open(config_file_path, FileMode.Create);
            using (var sw = new StreamWriter(faccount))
            {
                for (int x = 0; x < counter; x++)
                {
                    sw.WriteLine(Account[x]);
                }
                sw.Close();
            }

            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            writeinfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
