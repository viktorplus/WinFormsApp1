namespace WinFormsApp1
{
    partial class UserForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstSearchResults = new ListBox();
            lstReadingBooks = new ListBox();
            txtSearchCriteria = new TextBox();
            btnSearchBooks = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbSearchType = new ComboBox();
            SuspendLayout();
            // 
            // lstSearchResults
            // 
            lstSearchResults.FormattingEnabled = true;
            lstSearchResults.ItemHeight = 15;
            lstSearchResults.Location = new Point(12, 12);
            lstSearchResults.Name = "lstSearchResults";
            lstSearchResults.Size = new Size(360, 364);
            lstSearchResults.TabIndex = 0;
            // 
            // lstReadingBooks
            // 
            lstReadingBooks.FormattingEnabled = true;
            lstReadingBooks.ItemHeight = 15;
            lstReadingBooks.Location = new Point(395, 12);
            lstReadingBooks.Name = "lstReadingBooks";
            lstReadingBooks.Size = new Size(393, 94);
            lstReadingBooks.TabIndex = 1;
            // 
            // txtSearchCriteria
            // 
            txtSearchCriteria.Location = new Point(395, 137);
            txtSearchCriteria.Name = "txtSearchCriteria";
            txtSearchCriteria.Size = new Size(265, 23);
            txtSearchCriteria.TabIndex = 2;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(603, 281);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(75, 23);
            btnSearchBooks.TabIndex = 3;
            btnSearchBooks.Text = "button1";
            btnSearchBooks.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(512, 185);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(395, 185);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbSearchType
            // 
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "По названию", "По автору", "По жанру" });
            cmbSearchType.Location = new Point(667, 137);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(121, 23);
            cmbSearchType.TabIndex = 6;
            // 
            // UserForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSearchType);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSearchBooks);
            Controls.Add(txtSearchCriteria);
            Controls.Add(lstReadingBooks);
            Controls.Add(lstSearchResults);
            Name = "UserForm1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSearchResults;
        private ListBox lstReadingBooks;
        private TextBox txtSearchCriteria;
        private Button btnSearchBooks;
        private Button button2;
        private Button button3;
        private ComboBox cmbSearchType;
    }
}