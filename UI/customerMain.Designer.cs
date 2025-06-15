namespace UI
{
    partial class customerMain
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
            ProductsDataGridView = new DataGridView();
            ProductTabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            HelloLabel = new Label();
            BasketListBox = new ListBox();
            PayButton = new Button();
            EndPayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ProductTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.BackgroundColor = Color.White;
            ProductsDataGridView.BorderStyle = BorderStyle.None;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(0, -31);
            ProductsDataGridView.MaximumSize = new Size(1000, 1000);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowHeadersWidth = 51;
            ProductsDataGridView.Size = new Size(550, 304);
            ProductsDataGridView.TabIndex = 0;
            // 
            // ProductTabControl
            // 
            ProductTabControl.Controls.Add(tabPage1);
            ProductTabControl.Controls.Add(tabPage2);
            ProductTabControl.Location = new Point(645, 98);
            ProductTabControl.MaximumSize = new Size(1000, 1000);
            ProductTabControl.Name = "ProductTabControl";
            ProductTabControl.SelectedIndex = 0;
            ProductTabControl.Size = new Size(477, 254);
            ProductTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ProductsDataGridView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(469, 226);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(469, 226);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Font = new Font("HoloLens MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HelloLabel.Location = new Point(541, 24);
            HelloLabel.MaximumSize = new Size(875, 375);
            HelloLabel.MinimumSize = new Size(44, 15);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(114, 27);
            HelloLabel.TabIndex = 2;
            HelloLabel.Text = "HelloLabel";
            // 
            // BasketListBox
            // 
            BasketListBox.FormattingEnabled = true;
            BasketListBox.ItemHeight = 15;
            BasketListBox.Location = new Point(77, 65);
            BasketListBox.Margin = new Padding(3, 2, 3, 2);
            BasketListBox.Name = "BasketListBox";
            BasketListBox.Size = new Size(378, 349);
            BasketListBox.TabIndex = 3;
            // 
            // PayButton
            // 
            PayButton.Location = new Point(288, 493);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(75, 23);
            PayButton.TabIndex = 11;
            PayButton.Text = "תשלום";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += AddButton_Click;
            // 
            // EndPayLabel
            // 
            EndPayLabel.AutoSize = true;
            EndPayLabel.Font = new Font("Segoe UI", 10.8F);
            EndPayLabel.Location = new Point(309, 448);
            EndPayLabel.MaximumSize = new Size(875, 375);
            EndPayLabel.Name = "EndPayLabel";
            EndPayLabel.Size = new Size(85, 20);
            EndPayLabel.TabIndex = 13;
            EndPayLabel.Text = "תשלום סופי";
            // 
            // customerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1202, 618);
            Controls.Add(EndPayLabel);
            Controls.Add(PayButton);
            Controls.Add(BasketListBox);
            Controls.Add(HelloLabel);
            Controls.Add(ProductTabControl);
            Name = "customerMain";
            Text = "customerMain";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ProductTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private TabControl ProductTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label HelloLabel;
        private ListBox BasketListBox;
        private Button PayButton;
        private Label EndPayLabel;
    }
}