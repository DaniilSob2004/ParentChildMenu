namespace ParentChildMenu
{
    partial class Child
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
            this.childTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // childTextBox
            // 
            this.childTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.childTextBox.Location = new System.Drawing.Point(73, 66);
            this.childTextBox.Multiline = true;
            this.childTextBox.Name = "childTextBox";
            this.childTextBox.Size = new System.Drawing.Size(272, 68);
            this.childTextBox.TabIndex = 1;
            this.childTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChildTextBox_KeyUp);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(424, 202);
            this.Controls.Add(this.childTextBox);
            this.Name = "Child";
            this.Text = "Child";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Child_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox childTextBox;
    }
}