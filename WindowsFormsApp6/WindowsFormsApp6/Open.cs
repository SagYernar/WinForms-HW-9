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
    public partial class OpenFileForm : Form
    {
        EditFileForm editForm;
        string fileName;
        string fileText;

        public OpenFileForm()
        {
            editForm = new EditFileForm(this);
            InitializeComponent();
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            fileName = openFileDialog.FileName;
            fileText = File.ReadAllText(fileName);
            
            loadFileTextBox.Text = fileText;
            editButton.Enabled = true;
        }

        private void EditFileButton_Click(object sender, EventArgs e)
        {
            editButton.Enabled = false;
            editForm.PathFile = fileName;
            editForm.InitTextBox(loadFileTextBox.Text);
            loadFileTextBox.Text = null;
            editForm.Show();
        }
    }
}
