namespace UI
{
    partial class Products
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
            ProductsListBox = new ListBox();
            ProductTabControl = new TabControl();
            AddTabPage = new TabPage();
            AddButton = new Button();
            CategoryComboBox = new ComboBox();
            AmountTextBox = new TextBox();
            PriceTextBox = new TextBox();
            NameTextBox = new TextBox();
            KategoryLabel = new Label();
            AmountLabel = new Label();
            PriceLabel = new Label();
            NameLabel = new Label();
            DeleteTabPage = new TabPage();
            DeleteBtn = new Button();
            IdDeleteTextBox = new TextBox();
            IdDeleteLabel = new Label();
            UpdateTabPage = new TabPage();
            UpdateButton = new Button();
            CategoryUpdateComboBox = new ComboBox();
            AmountUpdateTextBox = new TextBox();
            PriceUpdateTextBox = new TextBox();
            NameUpdateTextBox = new TextBox();
            IdUpdateTextBox = new TextBox();
            CategoryUpdateLabel = new Label();
            AmountUpdateLlabel = new Label();
            PriceUpdateLabel = new Label();
            IdUpdateLabel = new Label();
            NameUpdateLabel = new Label();
            SingleTabPage = new TabPage();
            ProductListBox = new ListBox();
            ReadButton = new Button();
            ReadTextBox = new TextBox();
            ReadLabel = new Label();
            FilterComboBox = new ComboBox();
            FilterLabel = new Label();
            FilterButton = new Button();
            ProductTabControl.SuspendLayout();
            AddTabPage.SuspendLayout();
            DeleteTabPage.SuspendLayout();
            UpdateTabPage.SuspendLayout();
            SingleTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(10, 58);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(339, 379);
            ProductsListBox.TabIndex = 0;
            // 
            // ProductTabControl
            // 
            ProductTabControl.Controls.Add(AddTabPage);
            ProductTabControl.Controls.Add(DeleteTabPage);
            ProductTabControl.Controls.Add(UpdateTabPage);
            ProductTabControl.Controls.Add(SingleTabPage);
            ProductTabControl.Location = new Point(430, 33);
            ProductTabControl.Name = "ProductTabControl";
            ProductTabControl.SelectedIndex = 0;
            ProductTabControl.Size = new Size(360, 365);
            ProductTabControl.TabIndex = 1;
            // 
            // AddTabPage
            // 
            AddTabPage.Controls.Add(AddButton);
            AddTabPage.Controls.Add(CategoryComboBox);
            AddTabPage.Controls.Add(AmountTextBox);
            AddTabPage.Controls.Add(PriceTextBox);
            AddTabPage.Controls.Add(NameTextBox);
            AddTabPage.Controls.Add(KategoryLabel);
            AddTabPage.Controls.Add(AmountLabel);
            AddTabPage.Controls.Add(PriceLabel);
            AddTabPage.Controls.Add(NameLabel);
            AddTabPage.Location = new Point(4, 24);
            AddTabPage.Name = "AddTabPage";
            AddTabPage.Padding = new Padding(3, 3, 3, 3);
            AddTabPage.Size = new Size(352, 337);
            AddTabPage.TabIndex = 0;
            AddTabPage.Text = "הוספה";
            AddTabPage.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(54, 272);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 10;
            AddButton.Text = "שליחה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(39, 221);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(190, 23);
            CategoryComboBox.TabIndex = 9;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(129, 160);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(100, 23);
            AmountTextBox.TabIndex = 8;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(129, 99);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 23);
            PriceTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(129, 38);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 6;
            // 
            // KategoryLabel
            // 
            KategoryLabel.AutoSize = true;
            KategoryLabel.Location = new Point(267, 221);
            KategoryLabel.Name = "KategoryLabel";
            KategoryLabel.Size = new Size(49, 15);
            KategoryLabel.TabIndex = 4;
            KategoryLabel.Text = "קטגוריה";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(284, 162);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(34, 15);
            AmountLabel.TabIndex = 3;
            AmountLabel.Text = "כמות";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(285, 103);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "מחיר";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(255, 44);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(60, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "שם המוצר";
            // 
            // DeleteTabPage
            // 
            DeleteTabPage.Controls.Add(DeleteBtn);
            DeleteTabPage.Controls.Add(IdDeleteTextBox);
            DeleteTabPage.Controls.Add(IdDeleteLabel);
            DeleteTabPage.Location = new Point(4, 24);
            DeleteTabPage.Name = "DeleteTabPage";
            DeleteTabPage.Padding = new Padding(3, 3, 3, 3);
            DeleteTabPage.Size = new Size(352, 337);
            DeleteTabPage.TabIndex = 1;
            DeleteTabPage.Text = "מחיקה";
            DeleteTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(47, 148);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "מחיקה";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // IdDeleteTextBox
            // 
            IdDeleteTextBox.Location = new Point(84, 53);
            IdDeleteTextBox.Name = "IdDeleteTextBox";
            IdDeleteTextBox.Size = new Size(100, 23);
            IdDeleteTextBox.TabIndex = 1;
            // 
            // IdDeleteLabel
            // 
            IdDeleteLabel.AutoSize = true;
            IdDeleteLabel.Location = new Point(257, 53);
            IdDeleteLabel.Name = "IdDeleteLabel";
            IdDeleteLabel.Size = new Size(52, 15);
            IdDeleteLabel.TabIndex = 0;
            IdDeleteLabel.Text = "קוד מוצר";
            // 
            // UpdateTabPage
            // 
            UpdateTabPage.Controls.Add(UpdateButton);
            UpdateTabPage.Controls.Add(CategoryUpdateComboBox);
            UpdateTabPage.Controls.Add(AmountUpdateTextBox);
            UpdateTabPage.Controls.Add(PriceUpdateTextBox);
            UpdateTabPage.Controls.Add(NameUpdateTextBox);
            UpdateTabPage.Controls.Add(IdUpdateTextBox);
            UpdateTabPage.Controls.Add(CategoryUpdateLabel);
            UpdateTabPage.Controls.Add(AmountUpdateLlabel);
            UpdateTabPage.Controls.Add(PriceUpdateLabel);
            UpdateTabPage.Controls.Add(IdUpdateLabel);
            UpdateTabPage.Controls.Add(NameUpdateLabel);
            UpdateTabPage.Location = new Point(4, 24);
            UpdateTabPage.Name = "UpdateTabPage";
            UpdateTabPage.Size = new Size(352, 337);
            UpdateTabPage.TabIndex = 2;
            UpdateTabPage.Text = "עדכון";
            UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(54, 266);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 21;
            UpdateButton.Text = "שליחה";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // CategoryUpdateComboBox
            // 
            CategoryUpdateComboBox.FormattingEnabled = true;
            CategoryUpdateComboBox.Location = new Point(39, 216);
            CategoryUpdateComboBox.Name = "CategoryUpdateComboBox";
            CategoryUpdateComboBox.Size = new Size(190, 23);
            CategoryUpdateComboBox.TabIndex = 20;
            // 
            // AmountUpdateTextBox
            // 
            AmountUpdateTextBox.Location = new Point(85, 174);
            AmountUpdateTextBox.Name = "AmountUpdateTextBox";
            AmountUpdateTextBox.Size = new Size(100, 23);
            AmountUpdateTextBox.TabIndex = 19;
            // 
            // PriceUpdateTextBox
            // 
            PriceUpdateTextBox.Location = new Point(85, 132);
            PriceUpdateTextBox.Name = "PriceUpdateTextBox";
            PriceUpdateTextBox.Size = new Size(100, 23);
            PriceUpdateTextBox.TabIndex = 18;
            // 
            // NameUpdateTextBox
            // 
            NameUpdateTextBox.Location = new Point(85, 90);
            NameUpdateTextBox.Name = "NameUpdateTextBox";
            NameUpdateTextBox.Size = new Size(100, 23);
            NameUpdateTextBox.TabIndex = 17;
            // 
            // IdUpdateTextBox
            // 
            IdUpdateTextBox.Location = new Point(85, 48);
            IdUpdateTextBox.Name = "IdUpdateTextBox";
            IdUpdateTextBox.Size = new Size(100, 23);
            IdUpdateTextBox.TabIndex = 16;
            // 
            // CategoryUpdateLabel
            // 
            CategoryUpdateLabel.AutoSize = true;
            CategoryUpdateLabel.Location = new Point(265, 215);
            CategoryUpdateLabel.Name = "CategoryUpdateLabel";
            CategoryUpdateLabel.Size = new Size(49, 15);
            CategoryUpdateLabel.TabIndex = 15;
            CategoryUpdateLabel.Text = "קטגוריה";
            // 
            // AmountUpdateLlabel
            // 
            AmountUpdateLlabel.AutoSize = true;
            AmountUpdateLlabel.Location = new Point(280, 174);
            AmountUpdateLlabel.Name = "AmountUpdateLlabel";
            AmountUpdateLlabel.Size = new Size(34, 15);
            AmountUpdateLlabel.TabIndex = 14;
            AmountUpdateLlabel.Text = "כמות";
            // 
            // PriceUpdateLabel
            // 
            PriceUpdateLabel.AutoSize = true;
            PriceUpdateLabel.Location = new Point(281, 133);
            PriceUpdateLabel.Name = "PriceUpdateLabel";
            PriceUpdateLabel.Size = new Size(33, 15);
            PriceUpdateLabel.TabIndex = 13;
            PriceUpdateLabel.Text = "מחיר";
            // 
            // IdUpdateLabel
            // 
            IdUpdateLabel.AutoSize = true;
            IdUpdateLabel.Location = new Point(254, 51);
            IdUpdateLabel.Name = "IdUpdateLabel";
            IdUpdateLabel.Size = new Size(60, 15);
            IdUpdateLabel.TabIndex = 12;
            IdUpdateLabel.Text = "קוד המוצר";
            // 
            // NameUpdateLabel
            // 
            NameUpdateLabel.AutoSize = true;
            NameUpdateLabel.Location = new Point(254, 92);
            NameUpdateLabel.Name = "NameUpdateLabel";
            NameUpdateLabel.Size = new Size(60, 15);
            NameUpdateLabel.TabIndex = 11;
            NameUpdateLabel.Text = "שם המוצר";
            // 
            // SingleTabPage
            // 
            SingleTabPage.Controls.Add(ProductListBox);
            SingleTabPage.Controls.Add(ReadButton);
            SingleTabPage.Controls.Add(ReadTextBox);
            SingleTabPage.Controls.Add(ReadLabel);
            SingleTabPage.Location = new Point(4, 24);
            SingleTabPage.Name = "SingleTabPage";
            SingleTabPage.Size = new Size(352, 337);
            SingleTabPage.TabIndex = 3;
            SingleTabPage.Text = "מוצר בודד";
            SingleTabPage.UseVisualStyleBackColor = true;
            // 
            // ProductListBox
            // 
            ProductListBox.FormattingEnabled = true;
            ProductListBox.ItemHeight = 15;
            ProductListBox.Location = new Point(20, 181);
            ProductListBox.Name = "ProductListBox";
            ProductListBox.Size = new Size(316, 124);
            ProductListBox.TabIndex = 6;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(29, 91);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(75, 23);
            ReadButton.TabIndex = 5;
            ReadButton.Text = "הצגה";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // ReadTextBox
            // 
            ReadTextBox.Location = new Point(101, 43);
            ReadTextBox.Name = "ReadTextBox";
            ReadTextBox.Size = new Size(100, 23);
            ReadTextBox.TabIndex = 4;
            // 
            // ReadLabel
            // 
            ReadLabel.AutoSize = true;
            ReadLabel.Location = new Point(249, 46);
            ReadLabel.Name = "ReadLabel";
            ReadLabel.Size = new Size(52, 15);
            ReadLabel.TabIndex = 3;
            ReadLabel.Text = "קוד מוצר";
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(83, 25);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(138, 23);
            FilterComboBox.TabIndex = 11;
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Location = new Point(245, 28);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(95, 15);
            FilterLabel.TabIndex = 11;
            FilterLabel.Text = "סינון לפי קטגוריה";
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(10, 25);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(56, 21);
            FilterButton.TabIndex = 11;
            FilterButton.Text = "אישור";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(FilterButton);
            Controls.Add(FilterLabel);
            Controls.Add(FilterComboBox);
            Controls.Add(ProductTabControl);
            Controls.Add(ProductsListBox);
            Name = "Products";
            Text = "Products";
            ProductTabControl.ResumeLayout(false);
            AddTabPage.ResumeLayout(false);
            AddTabPage.PerformLayout();
            DeleteTabPage.ResumeLayout(false);
            DeleteTabPage.PerformLayout();
            UpdateTabPage.ResumeLayout(false);
            UpdateTabPage.PerformLayout();
            SingleTabPage.ResumeLayout(false);
            SingleTabPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ProductsListBox;
        private TabControl ProductTabControl;
        private TabPage AddTabPage;
        private TabPage DeleteTabPage;
        private TabPage UpdateTabPage;
        private TabPage SingleTabPage;
        private Label NameLabel;
        private Label AmountLabel;
        private Label PriceLabel;
        private Label KategoryLabel;
        private TextBox AmountTextBox;
        private TextBox PriceTextBox;
        private TextBox NameTextBox;
        private ComboBox CategoryComboBox;
        private Button AddButton;
        private Label IdDeleteLabel;
        private TextBox IdDeleteTextBox;
        private Button DeleteBtn;
        private Button UpdateButton;
        private ComboBox CategoryUpdateComboBox;
        private TextBox AmountUpdateTextBox;
        private TextBox PriceUpdateTextBox;
        private TextBox NameUpdateTextBox;
        private TextBox IdUpdateTextBox;
        private Label CategoryUpdateLabel;
        private Label AmountUpdateLlabel;
        private Label PriceUpdateLabel;
        private Label IdUpdateLabel;
        private Label NameUpdateLabel;
        private Button ReadButton;
        private TextBox ReadTextBox;
        private Label ReadLabel;
        private ListBox ProductListBox;
        private ComboBox FilterComboBox;
        private Label FilterLabel;
        private Button FilterButton;
    }
}