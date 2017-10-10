using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework_WF
{
    public partial class EditFileForm : Form
    {
        public string PathFile { get; set; }

        public EditFileForm(OpenFileForm openForm)
        {
            InitializeComponent();
        }
        public void InitTextBox(string data)
        {
            editFileTextBox.Text = data;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(PathFile, false);
            sw.WriteLine(editFileTextBox.Text);
            sw.Close();

            this.Visible = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            editFileTextBox.Text = null;
            this.Visible = false;
        }
    }
}
