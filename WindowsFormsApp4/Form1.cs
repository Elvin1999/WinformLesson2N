using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label=new Label();
            Image image = Properties.Resources.wall;
            
            label.Size=new Size(800, 600);
            
            label.Image=image;
            this.Size = label.Size;

            this.Controls.Add(label);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nameTxtbox.Text);
        }

        private void nameTxtbox_TextChanged(object sender, EventArgs e)
        {
           // button2.Text = nameTxtbox.Text;
        }

        private void nameTxtbox_MouseEnter(object sender, EventArgs e)
        {
            nameTxtbox.BackColor = Color.AntiqueWhite;
        }

        private void nameTxtbox_MouseLeave(object sender, EventArgs e)
        {
            nameTxtbox.BackColor = Color.LightBlue;
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text=dateTimePicker1.Value.ToLongDateString();
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }
        public string Text { get; set; }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "C# Selected";
                this.BackColor = Color.SpringGreen;
            }
            else
            {
                checkBox1.Text = "C#";
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.ForeColor = Color.Yellow;
                radioButton2.ForeColor = Color.Black;
            }
            else
            {
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Yellow;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn=sender as Button;
            richTextBox1.Text = btn.Text;
        }
    }
}
