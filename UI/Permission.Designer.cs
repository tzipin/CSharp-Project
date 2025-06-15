namespace UI
{
    partial class Permission
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
            managerBtn = new Button();
            CustomerBtn = new Button();
            SuspendLayout();
            // 
            // managerBtn
            // 
            managerBtn.BackColor = Color.FromArgb(64, 64, 64, 80);
            managerBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managerBtn.ForeColor = Color.Black;
            managerBtn.Location = new Point(137, 21);
            managerBtn.Name = "managerBtn";
            managerBtn.Size = new Size(236, 115);
            managerBtn.TabIndex = 0;
            managerBtn.Text = "מנהל";
            managerBtn.UseVisualStyleBackColor = false;
            managerBtn.Click += managerBtn_Click;
            // 
            // CustomerBtn
            // 
            CustomerBtn.BackColor = Color.FromArgb(64, 64, 64, 80);
            CustomerBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerBtn.ForeColor = Color.Black;
            CustomerBtn.Location = new Point(477, 21);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.Size = new Size(237, 115);
            CustomerBtn.TabIndex = 1;
            CustomerBtn.Text = "לקוח";
            CustomerBtn.UseVisualStyleBackColor = false;
            CustomerBtn.Click += CustomerBtn_Click;
            // 
            // Permission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._76215cdf3a12ab7c6a64baabcf0aa3291;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomerBtn);
            Controls.Add(managerBtn);
            Name = "Permission";
            Text = "Permission";
            ResumeLayout(false);
        }

        #endregion

        private Button managerBtn;
        private Button CustomerBtn;
    }
}