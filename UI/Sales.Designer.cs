namespace UI
{
    partial class Sales
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
            SaleTabControl = new TabControl();
            AddTabPage = new TabPage();
            EndDateLabel = new Label();
            StartDateLabel = new Label();
            EndDatePicker = new DateTimePicker();
            StartDatePicker = new DateTimePicker();
            IsClubCheckBox = new CheckBox();
            AddButton = new Button();
            AmountTextBox = new TextBox();
            PriceTextBox = new TextBox();
            BarcodeTextBox = new TextBox();
            AmountLabel = new Label();
            PriceLabel = new Label();
            BarcodeLabel = new Label();
            DeleteTabPage = new TabPage();
            DeleteBtn = new Button();
            IdDeleteTextBox = new TextBox();
            IdDeleteLabel = new Label();
            UpdateTabPage = new TabPage();
            CodeUpdateTextBox = new TextBox();
            CodeUpdateLabel = new Label();
            EndUpdateLabel = new Label();
            StartUpdateLabel = new Label();
            EndUpdateDateTimePicker = new DateTimePicker();
            StartUpdateDateTimePicker = new DateTimePicker();
            IsClubUpdateCheckBox = new CheckBox();
            UpdateButton = new Button();
            AmountUpdateTextBox = new TextBox();
            PriceUpdateTextBox = new TextBox();
            BarcodeUpdatetextBox = new TextBox();
            AmountUpdateLabel = new Label();
            PriceUpdatelabel = new Label();
            BarcodeUpdateLable = new Label();
            SingleTabPage = new TabPage();
            ReadSaletListBox = new ListBox();
            ReadButton = new Button();
            ReadTextBox = new TextBox();
            ReadLabel = new Label();
            SalesListBox = new ListBox();
            FilterCheckBox = new CheckBox();
            filterButton = new Button();
            AllSalesbBtton = new Button();
            SaleTabControl.SuspendLayout();
            AddTabPage.SuspendLayout();
            DeleteTabPage.SuspendLayout();
            UpdateTabPage.SuspendLayout();
            SingleTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // SaleTabControl
            // 
            SaleTabControl.Controls.Add(AddTabPage);
            SaleTabControl.Controls.Add(DeleteTabPage);
            SaleTabControl.Controls.Add(UpdateTabPage);
            SaleTabControl.Controls.Add(SingleTabPage);
            SaleTabControl.Location = new Point(490, 56);
            SaleTabControl.Margin = new Padding(3, 4, 3, 4);
            SaleTabControl.Name = "SaleTabControl";
            SaleTabControl.SelectedIndex = 0;
            SaleTabControl.Size = new Size(411, 487);
            SaleTabControl.TabIndex = 3;
            SaleTabControl.SelectedIndexChanged += ProductTabControl_SelectedIndexChanged;
            // 
            // AddTabPage
            // 
            AddTabPage.Controls.Add(EndDateLabel);
            AddTabPage.Controls.Add(StartDateLabel);
            AddTabPage.Controls.Add(EndDatePicker);
            AddTabPage.Controls.Add(StartDatePicker);
            AddTabPage.Controls.Add(IsClubCheckBox);
            AddTabPage.Controls.Add(AddButton);
            AddTabPage.Controls.Add(AmountTextBox);
            AddTabPage.Controls.Add(PriceTextBox);
            AddTabPage.Controls.Add(BarcodeTextBox);
            AddTabPage.Controls.Add(AmountLabel);
            AddTabPage.Controls.Add(PriceLabel);
            AddTabPage.Controls.Add(BarcodeLabel);
            AddTabPage.Location = new Point(4, 29);
            AddTabPage.Margin = new Padding(3, 4, 3, 4);
            AddTabPage.Name = "AddTabPage";
            AddTabPage.Padding = new Padding(3, 4, 3, 4);
            AddTabPage.Size = new Size(403, 454);
            AddTabPage.TabIndex = 0;
            AddTabPage.Text = "הוספה";
            AddTabPage.UseVisualStyleBackColor = true;
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Location = new Point(297, 277);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(82, 20);
            EndDateLabel.TabIndex = 15;
            EndDateLabel.Text = "תאריך סיום";
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Location = new Point(277, 221);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(103, 20);
            StartDateLabel.TabIndex = 14;
            StartDateLabel.Text = "תאריך התחלה";
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(6, 275);
            EndDatePicker.Margin = new Padding(3, 4, 3, 4);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(225, 27);
            EndDatePicker.TabIndex = 13;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(6, 223);
            StartDatePicker.Margin = new Padding(3, 4, 3, 4);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(225, 27);
            StartDatePicker.TabIndex = 12;
            // 
            // IsClubCheckBox
            // 
            IsClubCheckBox.AutoSize = true;
            IsClubCheckBox.Location = new Point(238, 339);
            IsClubCheckBox.Margin = new Padding(3, 4, 3, 4);
            IsClubCheckBox.Name = "IsClubCheckBox";
            IsClubCheckBox.Size = new Size(141, 24);
            IsClubCheckBox.TabIndex = 11;
            IsClubCheckBox.Text = "חברי מועדון בלבד";
            IsClubCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(21, 377);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(86, 31);
            AddButton.TabIndex = 10;
            AddButton.Text = "הוספה";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(117, 111);
            AmountTextBox.Margin = new Padding(3, 4, 3, 4);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(114, 27);
            AmountTextBox.TabIndex = 8;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(117, 167);
            PriceTextBox.Margin = new Padding(3, 4, 3, 4);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(114, 27);
            PriceTextBox.TabIndex = 7;
            // 
            // BarcodeTextBox
            // 
            BarcodeTextBox.Location = new Point(117, 55);
            BarcodeTextBox.Margin = new Padding(3, 4, 3, 4);
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.Size = new Size(114, 27);
            BarcodeTextBox.TabIndex = 6;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(337, 109);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(42, 20);
            AmountLabel.TabIndex = 3;
            AmountLabel.Text = "כמות";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(329, 165);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(50, 20);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "במחיר";
            // 
            // BarcodeLabel
            // 
            BarcodeLabel.AutoSize = true;
            BarcodeLabel.Location = new Point(287, 53);
            BarcodeLabel.Name = "BarcodeLabel";
            BarcodeLabel.Size = new Size(92, 20);
            BarcodeLabel.TabIndex = 0;
            BarcodeLabel.Text = "ברקוד המוצר";
            // 
            // DeleteTabPage
            // 
            DeleteTabPage.Controls.Add(DeleteBtn);
            DeleteTabPage.Controls.Add(IdDeleteTextBox);
            DeleteTabPage.Controls.Add(IdDeleteLabel);
            DeleteTabPage.Location = new Point(4, 29);
            DeleteTabPage.Margin = new Padding(3, 4, 3, 4);
            DeleteTabPage.Name = "DeleteTabPage";
            DeleteTabPage.Padding = new Padding(3, 4, 3, 4);
            DeleteTabPage.Size = new Size(403, 454);
            DeleteTabPage.TabIndex = 1;
            DeleteTabPage.Text = "מחיקה";
            DeleteTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(55, 224);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(86, 31);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "מחיקה";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // IdDeleteTextBox
            // 
            IdDeleteTextBox.Location = new Point(130, 75);
            IdDeleteTextBox.Margin = new Padding(3, 4, 3, 4);
            IdDeleteTextBox.Name = "IdDeleteTextBox";
            IdDeleteTextBox.Size = new Size(114, 27);
            IdDeleteTextBox.TabIndex = 1;
            IdDeleteTextBox.TextChanged += IdDeleteTextBox_TextChanged;
            // 
            // IdDeleteLabel
            // 
            IdDeleteLabel.AutoSize = true;
            IdDeleteLabel.Location = new Point(297, 75);
            IdDeleteLabel.Name = "IdDeleteLabel";
            IdDeleteLabel.Size = new Size(81, 20);
            IdDeleteLabel.TabIndex = 0;
            IdDeleteLabel.Text = "קוד המבצע";
            // 
            // UpdateTabPage
            // 
            UpdateTabPage.Controls.Add(CodeUpdateTextBox);
            UpdateTabPage.Controls.Add(CodeUpdateLabel);
            UpdateTabPage.Controls.Add(EndUpdateLabel);
            UpdateTabPage.Controls.Add(StartUpdateLabel);
            UpdateTabPage.Controls.Add(EndUpdateDateTimePicker);
            UpdateTabPage.Controls.Add(StartUpdateDateTimePicker);
            UpdateTabPage.Controls.Add(IsClubUpdateCheckBox);
            UpdateTabPage.Controls.Add(UpdateButton);
            UpdateTabPage.Controls.Add(AmountUpdateTextBox);
            UpdateTabPage.Controls.Add(PriceUpdateTextBox);
            UpdateTabPage.Controls.Add(BarcodeUpdatetextBox);
            UpdateTabPage.Controls.Add(AmountUpdateLabel);
            UpdateTabPage.Controls.Add(PriceUpdatelabel);
            UpdateTabPage.Controls.Add(BarcodeUpdateLable);
            UpdateTabPage.Location = new Point(4, 29);
            UpdateTabPage.Margin = new Padding(3, 4, 3, 4);
            UpdateTabPage.Name = "UpdateTabPage";
            UpdateTabPage.Size = new Size(403, 454);
            UpdateTabPage.TabIndex = 2;
            UpdateTabPage.Text = "עדכון";
            UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // CodeUpdateTextBox
            // 
            CodeUpdateTextBox.Location = new Point(126, 21);
            CodeUpdateTextBox.Margin = new Padding(3, 4, 3, 4);
            CodeUpdateTextBox.Name = "CodeUpdateTextBox";
            CodeUpdateTextBox.Size = new Size(114, 27);
            CodeUpdateTextBox.TabIndex = 29;
            // 
            // CodeUpdateLabel
            // 
            CodeUpdateLabel.AutoSize = true;
            CodeUpdateLabel.Location = new Point(309, 32);
            CodeUpdateLabel.Name = "CodeUpdateLabel";
            CodeUpdateLabel.Size = new Size(81, 20);
            CodeUpdateLabel.TabIndex = 28;
            CodeUpdateLabel.Text = "קוד המבצע";
            // 
            // EndUpdateLabel
            // 
            EndUpdateLabel.AutoSize = true;
            EndUpdateLabel.Location = new Point(306, 299);
            EndUpdateLabel.Name = "EndUpdateLabel";
            EndUpdateLabel.Size = new Size(82, 20);
            EndUpdateLabel.TabIndex = 27;
            EndUpdateLabel.Text = "תאריך סיום";
            // 
            // StartUpdateLabel
            // 
            StartUpdateLabel.AutoSize = true;
            StartUpdateLabel.Location = new Point(286, 245);
            StartUpdateLabel.Name = "StartUpdateLabel";
            StartUpdateLabel.Size = new Size(103, 20);
            StartUpdateLabel.TabIndex = 26;
            StartUpdateLabel.Text = "תאריך התחלה";
            // 
            // EndUpdateDateTimePicker
            // 
            EndUpdateDateTimePicker.Location = new Point(15, 295);
            EndUpdateDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            EndUpdateDateTimePicker.Name = "EndUpdateDateTimePicker";
            EndUpdateDateTimePicker.Size = new Size(225, 27);
            EndUpdateDateTimePicker.TabIndex = 25;
            // 
            // StartUpdateDateTimePicker
            // 
            StartUpdateDateTimePicker.Location = new Point(15, 240);
            StartUpdateDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            StartUpdateDateTimePicker.Name = "StartUpdateDateTimePicker";
            StartUpdateDateTimePicker.Size = new Size(225, 27);
            StartUpdateDateTimePicker.TabIndex = 24;
            // 
            // IsClubUpdateCheckBox
            // 
            IsClubUpdateCheckBox.AutoSize = true;
            IsClubUpdateCheckBox.Location = new Point(251, 352);
            IsClubUpdateCheckBox.Margin = new Padding(3, 4, 3, 4);
            IsClubUpdateCheckBox.Name = "IsClubUpdateCheckBox";
            IsClubUpdateCheckBox.Size = new Size(141, 24);
            IsClubUpdateCheckBox.TabIndex = 23;
            IsClubUpdateCheckBox.Text = "חברי מועדון בלבד";
            IsClubUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(30, 391);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(86, 31);
            UpdateButton.TabIndex = 22;
            UpdateButton.Text = "עידכון";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AmountUpdateTextBox
            // 
            AmountUpdateTextBox.Location = new Point(126, 131);
            AmountUpdateTextBox.Margin = new Padding(3, 4, 3, 4);
            AmountUpdateTextBox.Name = "AmountUpdateTextBox";
            AmountUpdateTextBox.Size = new Size(114, 27);
            AmountUpdateTextBox.TabIndex = 21;
            // 
            // PriceUpdateTextBox
            // 
            PriceUpdateTextBox.Location = new Point(126, 185);
            PriceUpdateTextBox.Margin = new Padding(3, 4, 3, 4);
            PriceUpdateTextBox.Name = "PriceUpdateTextBox";
            PriceUpdateTextBox.Size = new Size(114, 27);
            PriceUpdateTextBox.TabIndex = 20;
            // 
            // BarcodeUpdatetextBox
            // 
            BarcodeUpdatetextBox.Location = new Point(126, 76);
            BarcodeUpdatetextBox.Margin = new Padding(3, 4, 3, 4);
            BarcodeUpdatetextBox.Name = "BarcodeUpdatetextBox";
            BarcodeUpdatetextBox.Size = new Size(114, 27);
            BarcodeUpdatetextBox.TabIndex = 19;
            // 
            // AmountUpdateLabel
            // 
            AmountUpdateLabel.AutoSize = true;
            AmountUpdateLabel.Location = new Point(343, 139);
            AmountUpdateLabel.Name = "AmountUpdateLabel";
            AmountUpdateLabel.Size = new Size(42, 20);
            AmountUpdateLabel.TabIndex = 18;
            AmountUpdateLabel.Text = "כמות";
            // 
            // PriceUpdatelabel
            // 
            PriceUpdatelabel.AutoSize = true;
            PriceUpdatelabel.Location = new Point(336, 192);
            PriceUpdatelabel.Name = "PriceUpdatelabel";
            PriceUpdatelabel.Size = new Size(50, 20);
            PriceUpdatelabel.TabIndex = 17;
            PriceUpdatelabel.Text = "במחיר";
            // 
            // BarcodeUpdateLable
            // 
            BarcodeUpdateLable.AutoSize = true;
            BarcodeUpdateLable.Location = new Point(297, 85);
            BarcodeUpdateLable.Name = "BarcodeUpdateLable";
            BarcodeUpdateLable.Size = new Size(92, 20);
            BarcodeUpdateLable.TabIndex = 16;
            BarcodeUpdateLable.Text = "ברקוד המוצר";
            // 
            // SingleTabPage
            // 
            SingleTabPage.Controls.Add(ReadSaletListBox);
            SingleTabPage.Controls.Add(ReadButton);
            SingleTabPage.Controls.Add(ReadTextBox);
            SingleTabPage.Controls.Add(ReadLabel);
            SingleTabPage.Location = new Point(4, 29);
            SingleTabPage.Margin = new Padding(3, 4, 3, 4);
            SingleTabPage.Name = "SingleTabPage";
            SingleTabPage.Size = new Size(403, 454);
            SingleTabPage.TabIndex = 3;
            SingleTabPage.Text = "מוצר בודד";
            SingleTabPage.UseVisualStyleBackColor = true;
            // 
            // ReadSaletListBox
            // 
            ReadSaletListBox.FormattingEnabled = true;
            ReadSaletListBox.ItemHeight = 20;
            ReadSaletListBox.Location = new Point(21, 241);
            ReadSaletListBox.Margin = new Padding(3, 4, 3, 4);
            ReadSaletListBox.Name = "ReadSaletListBox";
            ReadSaletListBox.Size = new Size(361, 164);
            ReadSaletListBox.TabIndex = 14;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(56, 120);
            ReadButton.Margin = new Padding(3, 4, 3, 4);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(86, 31);
            ReadButton.TabIndex = 13;
            ReadButton.Text = "הצגה";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // ReadTextBox
            // 
            ReadTextBox.Location = new Point(118, 43);
            ReadTextBox.Margin = new Padding(3, 4, 3, 4);
            ReadTextBox.Name = "ReadTextBox";
            ReadTextBox.Size = new Size(114, 27);
            ReadTextBox.TabIndex = 12;
            // 
            // ReadLabel
            // 
            ReadLabel.AutoSize = true;
            ReadLabel.Location = new Point(288, 53);
            ReadLabel.Name = "ReadLabel";
            ReadLabel.Size = new Size(81, 20);
            ReadLabel.TabIndex = 11;
            ReadLabel.Text = "קוד המבצע";
            // 
            // SalesListBox
            // 
            SalesListBox.FormattingEnabled = true;
            SalesListBox.ItemHeight = 20;
            SalesListBox.Location = new Point(21, 108);
            SalesListBox.Margin = new Padding(3, 4, 3, 4);
            SalesListBox.Name = "SalesListBox";
            SalesListBox.Size = new Size(377, 464);
            SalesListBox.TabIndex = 2;
            // 
            // FilterCheckBox
            // 
            FilterCheckBox.AutoSize = true;
            FilterCheckBox.Location = new Point(194, 56);
            FilterCheckBox.Margin = new Padding(3, 4, 3, 4);
            FilterCheckBox.Name = "FilterCheckBox";
            FilterCheckBox.Size = new Size(204, 24);
            FilterCheckBox.TabIndex = 16;
            FilterCheckBox.Text = "מבצעים לחברי מועדון בלבד";
            FilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(104, 56);
            filterButton.Margin = new Padding(3, 4, 3, 4);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(72, 31);
            filterButton.TabIndex = 16;
            filterButton.Text = "אישור";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // AllSalesbBtton
            // 
            AllSalesbBtton.Location = new Point(21, 56);
            AllSalesbBtton.Margin = new Padding(3, 4, 3, 4);
            AllSalesbBtton.Name = "AllSalesbBtton";
            AllSalesbBtton.Size = new Size(63, 31);
            AllSalesbBtton.TabIndex = 17;
            AllSalesbBtton.Text = "הכל";
            AllSalesbBtton.UseVisualStyleBackColor = true;
            AllSalesbBtton.Click += AllSalesbBtton_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(AllSalesbBtton);
            Controls.Add(filterButton);
            Controls.Add(FilterCheckBox);
            Controls.Add(SaleTabControl);
            Controls.Add(SalesListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sales";
            Text = "Sales";
            SaleTabControl.ResumeLayout(false);
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

        private TabControl SaleTabControl;
        private TabPage AddTabPage;
        private Button AddButton;
        private TextBox AmountTextBox;
        private TextBox PriceTextBox;
        private TextBox BarcodeTextBox;
        private Label AmountLabel;
        private Label PriceLabel;
        private Label BarcodeLabel;
        private TabPage DeleteTabPage;
        private Button DeleteBtn;
        private TextBox IdDeleteTextBox;
        private Label IdDeleteLabel;
        private TabPage UpdateTabPage;
        private TabPage SingleTabPage;
        private ListBox SalesListBox;
        private CheckBox IsClubCheckBox;
        private Label EndDateLabel;
        private Label StartDateLabel;
        private DateTimePicker EndDatePicker;
        private DateTimePicker StartDatePicker;
        private ListBox ReadSaletListBox;
        private Button ReadButton;
        private TextBox ReadTextBox;
        private Label ReadLabel;
        private Label EndUpdateLabel;
        private Label StartUpdateLabel;
        private DateTimePicker EndUpdateDateTimePicker;
        private DateTimePicker StartUpdateDateTimePicker;
        private CheckBox IsClubUpdateCheckBox;
        private Button UpdateButton;
        private TextBox AmountUpdateTextBox;
        private TextBox PriceUpdateTextBox;
        private TextBox BarcodeUpdatetextBox;
        private Label AmountUpdateLabel;
        private Label PriceUpdatelabel;
        private Label BarcodeUpdateLable;
        private TextBox CodeUpdateTextBox;
        private Label CodeUpdateLabel;
        private CheckBox FilterCheckBox;
        private Button filterButton;
        private Button AllSalesbBtton;
    }
}