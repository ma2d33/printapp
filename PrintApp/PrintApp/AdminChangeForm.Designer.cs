namespace PrintApp
{
    partial class AdminChangeForm
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
            this.adminChangeBox = new System.Windows.Forms.ComboBox();
            this.confirmAdminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminChangeBox
            // 
            this.adminChangeBox.FormattingEnabled = true;
            this.adminChangeBox.Items.AddRange(new object[] {
            "Ира",
            "Янис\t",
            "Александр",
            "Дмитрий"});
            this.adminChangeBox.Location = new System.Drawing.Point(79, 32);
            this.adminChangeBox.Name = "adminChangeBox";
            this.adminChangeBox.Size = new System.Drawing.Size(121, 21);
            this.adminChangeBox.TabIndex = 0;
            this.adminChangeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // confirmAdminButton
            // 
            this.confirmAdminButton.Location = new System.Drawing.Point(205, 74);
            this.confirmAdminButton.Name = "confirmAdminButton";
            this.confirmAdminButton.Size = new System.Drawing.Size(75, 23);
            this.confirmAdminButton.TabIndex = 1;
            this.confirmAdminButton.Text = "OK";
            this.confirmAdminButton.UseVisualStyleBackColor = true;
            this.confirmAdminButton.Click += new System.EventHandler(this.confirmAdminButton_Click);
            // 
            // AdminChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 109);
            this.Controls.Add(this.confirmAdminButton);
            this.Controls.Add(this.adminChangeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AdminChangeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox adminChangeBox;
        private System.Windows.Forms.Button confirmAdminButton;
    }
}