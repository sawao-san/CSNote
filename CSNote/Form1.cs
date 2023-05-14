using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "ファイルを選択してください";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               // mainTextBox.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存先のファイルを指定してください";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               // File.WriteAllText(dialog.FileName, mainTextBox.Text);
            }
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("メモ帳を修了します", "終了", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage1 = new TabPage();
            this.tabControl1.Controls.Add(tabPage1);
            TextBox mainTextBox = new TextBox();
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            //mainTextBox.Location = new System.Drawing.Point(3, 3);
            //mainTextBox.Size = new System.Drawing.Size(786, 359);
            //mainTextBox.TabIndex = 0;
            // this.mainTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            tabPage1.Controls.Add(mainTextBox);

        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
