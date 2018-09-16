using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "พิมพ์ข้อความที่นี่...";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "พิมพ์ข้อความที่นี่...";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (.txt)|*.txt";
            openFileDialog1.Title = "Open File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (.txt)|*.txt";
            saveFileDialog1.Title = "Save File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document.Print();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Bold == false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Italic == false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Underline == false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog Text_col = new ColorDialog();
            if (Text_col.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = Text_col.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog bg_col = new ColorDialog();
            if (bg_col.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = bg_col.Color;
            }
        }
    }
}
