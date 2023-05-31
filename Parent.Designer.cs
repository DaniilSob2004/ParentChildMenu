namespace ParentChildMenu
{
    partial class Parent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.parentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // parentTextBox
            // 
            this.parentTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.parentTextBox.Location = new System.Drawing.Point(73, 66);
            this.parentTextBox.Multiline = true;
            this.parentTextBox.Name = "parentTextBox";
            this.parentTextBox.Size = new System.Drawing.Size(272, 68);
            this.parentTextBox.TabIndex = 0;
            this.parentTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ParentTextBox_KeyUp);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(424, 202);
            this.Controls.Add(this.parentTextBox);
            this.Name = "Parent";
            this.Text = "Parent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox parentTextBox;
    }
}