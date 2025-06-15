namespace UI
{
    partial class ManagerMenu
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
            productsBtn = new Button();
            Sales = new Button();
            customers = new Button();
            LogButton = new Button();
            SuspendLayout();
            // 
            // productsBtn
            // 
            productsBtn.Location = new Point(76, 30);
            productsBtn.Name = "productsBtn";
            productsBtn.Size = new Size(196, 84);
            productsBtn.TabIndex = 0;
            productsBtn.Text = "מוצרים";
            productsBtn.UseVisualStyleBackColor = true;
            productsBtn.Click += productsBtn_Click;
            // 
            // Sales
            // 
            Sales.Location = new Point(307, 30);
            Sales.Name = "Sales";
            Sales.Size = new Size(196, 84);
            Sales.TabIndex = 1;
            Sales.Text = "מבצעים";
            Sales.UseVisualStyleBackColor = true;
            Sales.Click += Sales_Click;
            // 
            // customers
            // 
            customers.Location = new Point(542, 30);
            customers.Name = "customers";
            customers.Size = new Size(196, 84);
            customers.TabIndex = 2;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // LogButton
            // 
            LogButton.Location = new Point(48, 367);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(90, 52);
            LogButton.TabIndex = 3;
            LogButton.Text = "ניקוי לוגים";
            LogButton.UseVisualStyleBackColor = true;
            LogButton.Click += LogButton_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.מעודכן;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(LogButton);
            Controls.Add(customers);
            Controls.Add(Sales);
            Controls.Add(productsBtn);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button productsBtn;
        private Button Sales;
        private Button customers;
        private Button LogButton;
    }
}