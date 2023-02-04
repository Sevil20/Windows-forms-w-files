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
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text.Trim();
            string path = Directory.GetCurrentDirectory() + @"\..\..\..\..\" + filename + ".txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter streamWriter= new StreamWriter(fileStream);
            if (!String.IsNullOrEmpty(richTextBox1.Text))
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
            MessageBox.Show("Fayl uğurla yaradıldı","Uğurlu əməliyyat",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\..\..\..\..\" + textBox1.Text + ".txt";
            FileInfo fileInfo= new FileInfo(path);
            if (fileInfo.Exists)
                fileInfo.Delete();
            MessageBox.Show("Fayl uğurla silindi", "Uğurlu əməliyyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
