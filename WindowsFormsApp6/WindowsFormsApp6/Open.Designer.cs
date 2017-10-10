namespace Homework_WF
{
    partial class OpenFileForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadFileTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // loadFileTextBox
            // 
            this.loadFileTextBox.Location = new System.Drawing.Point(12, 12);
            this.loadFileTextBox.Multiline = true;
            this.loadFileTextBox.Name = "loadFileTextBox";
            this.loadFileTextBox.ReadOnly = true;
            this.loadFileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loadFileTextBox.Size = new System.Drawing.Size(364, 196);
            this.loadFileTextBox.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(193, 224);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузить файл";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(274, 224);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(102, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt файлы|*.txt";
            // 
            // OpenFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 262);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.loadFileTextBox);
            this.Name = "OpenFileForm";
            this.Text = "Просмотр и Загрузка файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loadFileTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

