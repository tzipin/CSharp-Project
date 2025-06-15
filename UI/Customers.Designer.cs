namespace UI
{
    partial class Customers
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
            customersListBox = new ListBox();
            customerTabControl = new TabControl();
            AddtabPage = new TabPage();
            addBtn = new Button();
            nametextBox = new TextBox();
            numberphontextBox = new TextBox();
            addresstextBox = new TextBox();
            idtextBox = new TextBox();
            namelabel = new Label();
            label2 = new Label();
            numberphonlabel = new Label();
            idlabel = new Label();
            deleteTabPage = new TabPage();
            deleteButton = new Button();
            IdDeleteTextBox = new TextBox();
            idDeleteLabel = new Label();
            updatetabPage = new TabPage();
            Updatebutton = new Button();
            NameUpdateTextBox = new TextBox();
            NumberPhoneTextBox = new TextBox();
            AddressUpdateTextBox = new TextBox();
            IdUpdateTextBox = new TextBox();
            NameUpdateLabel = new Label();
            AddressUpdateLabel = new Label();
            NumberPhoneUpdateLabel = new Label();
            IdUpdateLabel = new Label();
            singletabPage = new TabPage();
            CustomerListBox = new ListBox();
            ReadButton = new Button();
            ReadTextBox = new TextBox();
            ReadLabel = new Label();
            FilterTextBox = new TextBox();
            FilterLabel = new Label();
            FilterButton = new Button();
            customerTabControl.SuspendLayout();
            AddtabPage.SuspendLayout();
            deleteTabPage.SuspendLayout();
            updatetabPage.SuspendLayout();
            singletabPage.SuspendLayout();
            SuspendLayout();
            // 
            // customersListBox
            // 
            customersListBox.FormattingEnabled = true;
            customersListBox.ItemHeight = 20;
            customersListBox.Location = new Point(12, 81);
            customersListBox.Margin = new Padding(3, 4, 3, 4);
            customersListBox.Name = "customersListBox";
            customersListBox.Size = new Size(376, 504);
            customersListBox.TabIndex = 0;
            // 
            // customerTabControl
            // 
            customerTabControl.Controls.Add(AddtabPage);
            customerTabControl.Controls.Add(deleteTabPage);
            customerTabControl.Controls.Add(updatetabPage);
            customerTabControl.Controls.Add(singletabPage);
            customerTabControl.Location = new Point(469, 45);
            customerTabControl.Margin = new Padding(3, 4, 3, 4);
            customerTabControl.Name = "customerTabControl";
            customerTabControl.SelectedIndex = 0;
            customerTabControl.Size = new Size(414, 504);
            customerTabControl.TabIndex = 1;
            // 
            // AddtabPage
            // 
            AddtabPage.Controls.Add(addBtn);
            AddtabPage.Controls.Add(nametextBox);
            AddtabPage.Controls.Add(numberphontextBox);
            AddtabPage.Controls.Add(addresstextBox);
            AddtabPage.Controls.Add(idtextBox);
            AddtabPage.Controls.Add(namelabel);
            AddtabPage.Controls.Add(label2);
            AddtabPage.Controls.Add(numberphonlabel);
            AddtabPage.Controls.Add(idlabel);
            AddtabPage.Location = new Point(4, 29);
            AddtabPage.Margin = new Padding(3, 4, 3, 4);
            AddtabPage.Name = "AddtabPage";
            AddtabPage.Padding = new Padding(3, 4, 3, 4);
            AddtabPage.Size = new Size(406, 471);
            AddtabPage.TabIndex = 0;
            AddtabPage.Text = "הוספה";
            AddtabPage.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(29, 287);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(86, 31);
            addBtn.TabIndex = 9;
            addBtn.Text = "הוספה";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(127, 111);
            nametextBox.Margin = new Padding(3, 4, 3, 4);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(114, 27);
            nametextBox.TabIndex = 8;
            // 
            // numberphontextBox
            // 
            numberphontextBox.Location = new Point(127, 225);
            numberphontextBox.Margin = new Padding(3, 4, 3, 4);
            numberphontextBox.Name = "numberphontextBox";
            numberphontextBox.Size = new Size(114, 27);
            numberphontextBox.TabIndex = 6;
            // 
            // addresstextBox
            // 
            addresstextBox.Location = new Point(127, 168);
            addresstextBox.Margin = new Padding(3, 4, 3, 4);
            addresstextBox.Name = "addresstextBox";
            addresstextBox.Size = new Size(114, 27);
            addresstextBox.TabIndex = 5;
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(127, 53);
            idtextBox.Margin = new Padding(3, 4, 3, 4);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(114, 27);
            idtextBox.TabIndex = 4;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(267, 121);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(77, 20);
            namelabel.TabIndex = 3;
            namelabel.Text = "שם הלקוח";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 179);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "כתובת";
            // 
            // numberphonlabel
            // 
            numberphonlabel.AutoSize = true;
            numberphonlabel.Location = new Point(271, 236);
            numberphonlabel.Name = "numberphonlabel";
            numberphonlabel.Size = new Size(71, 20);
            numberphonlabel.TabIndex = 1;
            numberphonlabel.Text = "מס' טלפון";
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(309, 64);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(31, 20);
            idlabel.TabIndex = 0;
            idlabel.Text = "ת\"ז";
            // 
            // deleteTabPage
            // 
            deleteTabPage.Controls.Add(deleteButton);
            deleteTabPage.Controls.Add(IdDeleteTextBox);
            deleteTabPage.Controls.Add(idDeleteLabel);
            deleteTabPage.Location = new Point(4, 29);
            deleteTabPage.Margin = new Padding(3, 4, 3, 4);
            deleteTabPage.Name = "deleteTabPage";
            deleteTabPage.Padding = new Padding(3, 4, 3, 4);
            deleteTabPage.Size = new Size(406, 471);
            deleteTabPage.TabIndex = 1;
            deleteTabPage.Text = "מחיקה";
            deleteTabPage.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(165, 160);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 31);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "מחיקה";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // IdDeleteTextBox
            // 
            IdDeleteTextBox.Location = new Point(123, 73);
            IdDeleteTextBox.Margin = new Padding(3, 4, 3, 4);
            IdDeleteTextBox.Name = "IdDeleteTextBox";
            IdDeleteTextBox.Size = new Size(114, 27);
            IdDeleteTextBox.TabIndex = 6;
            // 
            // idDeleteLabel
            // 
            idDeleteLabel.AutoSize = true;
            idDeleteLabel.Location = new Point(311, 84);
            idDeleteLabel.Name = "idDeleteLabel";
            idDeleteLabel.Size = new Size(31, 20);
            idDeleteLabel.TabIndex = 5;
            idDeleteLabel.Text = "ת\"ז";
            // 
            // updatetabPage
            // 
            updatetabPage.Controls.Add(Updatebutton);
            updatetabPage.Controls.Add(NameUpdateTextBox);
            updatetabPage.Controls.Add(NumberPhoneTextBox);
            updatetabPage.Controls.Add(AddressUpdateTextBox);
            updatetabPage.Controls.Add(IdUpdateTextBox);
            updatetabPage.Controls.Add(NameUpdateLabel);
            updatetabPage.Controls.Add(AddressUpdateLabel);
            updatetabPage.Controls.Add(NumberPhoneUpdateLabel);
            updatetabPage.Controls.Add(IdUpdateLabel);
            updatetabPage.Location = new Point(4, 29);
            updatetabPage.Margin = new Padding(3, 4, 3, 4);
            updatetabPage.Name = "updatetabPage";
            updatetabPage.Size = new Size(406, 471);
            updatetabPage.TabIndex = 2;
            updatetabPage.Text = "עידכון";
            updatetabPage.UseVisualStyleBackColor = true;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(30, 271);
            Updatebutton.Margin = new Padding(3, 4, 3, 4);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(86, 31);
            Updatebutton.TabIndex = 18;
            Updatebutton.Text = "עידכון";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // NameUpdateTextBox
            // 
            NameUpdateTextBox.Location = new Point(128, 96);
            NameUpdateTextBox.Margin = new Padding(3, 4, 3, 4);
            NameUpdateTextBox.Name = "NameUpdateTextBox";
            NameUpdateTextBox.Size = new Size(114, 27);
            NameUpdateTextBox.TabIndex = 17;
            // 
            // NumberPhoneTextBox
            // 
            NumberPhoneTextBox.Location = new Point(128, 211);
            NumberPhoneTextBox.Margin = new Padding(3, 4, 3, 4);
            NumberPhoneTextBox.Name = "NumberPhoneTextBox";
            NumberPhoneTextBox.Size = new Size(114, 27);
            NumberPhoneTextBox.TabIndex = 16;
            // 
            // AddressUpdateTextBox
            // 
            AddressUpdateTextBox.Location = new Point(128, 149);
            AddressUpdateTextBox.Margin = new Padding(3, 4, 3, 4);
            AddressUpdateTextBox.Name = "AddressUpdateTextBox";
            AddressUpdateTextBox.Size = new Size(114, 27);
            AddressUpdateTextBox.TabIndex = 15;
            // 
            // IdUpdateTextBox
            // 
            IdUpdateTextBox.Location = new Point(128, 37);
            IdUpdateTextBox.Margin = new Padding(3, 4, 3, 4);
            IdUpdateTextBox.Name = "IdUpdateTextBox";
            IdUpdateTextBox.Size = new Size(114, 27);
            IdUpdateTextBox.TabIndex = 14;
            // 
            // NameUpdateLabel
            // 
            NameUpdateLabel.AutoSize = true;
            NameUpdateLabel.Location = new Point(269, 105);
            NameUpdateLabel.Name = "NameUpdateLabel";
            NameUpdateLabel.Size = new Size(77, 20);
            NameUpdateLabel.TabIndex = 13;
            NameUpdateLabel.Text = "שם הלקוח";
            // 
            // AddressUpdateLabel
            // 
            AddressUpdateLabel.AutoSize = true;
            AddressUpdateLabel.Location = new Point(290, 163);
            AddressUpdateLabel.Name = "AddressUpdateLabel";
            AddressUpdateLabel.Size = new Size(52, 20);
            AddressUpdateLabel.TabIndex = 12;
            AddressUpdateLabel.Text = "כתובת";
            // 
            // NumberPhoneUpdateLabel
            // 
            NumberPhoneUpdateLabel.AutoSize = true;
            NumberPhoneUpdateLabel.Location = new Point(272, 220);
            NumberPhoneUpdateLabel.Name = "NumberPhoneUpdateLabel";
            NumberPhoneUpdateLabel.Size = new Size(71, 20);
            NumberPhoneUpdateLabel.TabIndex = 11;
            NumberPhoneUpdateLabel.Text = "מס' טלפון";
            // 
            // IdUpdateLabel
            // 
            IdUpdateLabel.AutoSize = true;
            IdUpdateLabel.Location = new Point(310, 48);
            IdUpdateLabel.Name = "IdUpdateLabel";
            IdUpdateLabel.Size = new Size(31, 20);
            IdUpdateLabel.TabIndex = 10;
            IdUpdateLabel.Text = "ת\"ז";
            // 
            // singletabPage
            // 
            singletabPage.Controls.Add(CustomerListBox);
            singletabPage.Controls.Add(ReadButton);
            singletabPage.Controls.Add(ReadTextBox);
            singletabPage.Controls.Add(ReadLabel);
            singletabPage.Location = new Point(4, 29);
            singletabPage.Margin = new Padding(3, 4, 3, 4);
            singletabPage.Name = "singletabPage";
            singletabPage.Size = new Size(406, 471);
            singletabPage.TabIndex = 3;
            singletabPage.Text = "לקוח בודד";
            singletabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerListBox
            // 
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.ItemHeight = 20;
            CustomerListBox.Location = new Point(29, 251);
            CustomerListBox.Margin = new Padding(3, 4, 3, 4);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(361, 164);
            CustomerListBox.TabIndex = 10;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(64, 129);
            ReadButton.Margin = new Padding(3, 4, 3, 4);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(86, 31);
            ReadButton.TabIndex = 9;
            ReadButton.Text = "הצגה";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // ReadTextBox
            // 
            ReadTextBox.Location = new Point(126, 52);
            ReadTextBox.Margin = new Padding(3, 4, 3, 4);
            ReadTextBox.Name = "ReadTextBox";
            ReadTextBox.Size = new Size(114, 27);
            ReadTextBox.TabIndex = 8;
            // 
            // ReadLabel
            // 
            ReadLabel.AutoSize = true;
            ReadLabel.Location = new Point(296, 63);
            ReadLabel.Name = "ReadLabel";
            ReadLabel.Size = new Size(67, 20);
            ReadLabel.TabIndex = 7;
            ReadLabel.Text = "ת\"ז לקוח";
            // 
            // FilterTextBox
            // 
            FilterTextBox.Location = new Point(142, 40);
            FilterTextBox.Margin = new Padding(3, 4, 3, 4);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(114, 27);
            FilterTextBox.TabIndex = 5;
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Location = new Point(279, 40);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(109, 20);
            FilterLabel.TabIndex = 6;
            FilterLabel.Text = "הכנס שם לסינון";
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(27, 40);
            FilterButton.Margin = new Padding(3, 4, 3, 4);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(86, 31);
            FilterButton.TabIndex = 10;
            FilterButton.Text = "אישור";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(FilterButton);
            Controls.Add(FilterLabel);
            Controls.Add(FilterTextBox);
            Controls.Add(customerTabControl);
            Controls.Add(customersListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customers";
            Text = "Customers";
            customerTabControl.ResumeLayout(false);
            AddtabPage.ResumeLayout(false);
            AddtabPage.PerformLayout();
            deleteTabPage.ResumeLayout(false);
            deleteTabPage.PerformLayout();
            updatetabPage.ResumeLayout(false);
            updatetabPage.PerformLayout();
            singletabPage.ResumeLayout(false);
            singletabPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox customersListBox;
        private TabControl customerTabControl;
        private TabPage AddtabPage;
        private TabPage deleteTabPage;
        private TabPage updatetabPage;
        private TabPage singletabPage;
        private Label idlabel;
        private Label namelabel;
        private Label label2;
        private Label numberphonlabel;
        private TextBox idtextBox;
        private Button addBtn;
        private TextBox nametextBox;
        private TextBox numberphontextBox;
        private TextBox addresstextBox;
        private Button Updatebutton;
        private TextBox NameUpdateTextBox;
        private TextBox NumberPhoneTextBox;
        private TextBox AddressUpdateTextBox;
        private TextBox IdUpdateTextBox;
        private Label NameUpdateLabel;
        private Label AddressUpdateLabel;
        private Label NumberPhoneUpdateLabel;
        private Label IdUpdateLabel;
        private Button deleteButton;
        private TextBox IdDeleteTextBox;
        private Label idDeleteLabel;
        private ListBox CustomerListBox;
        private Button ReadButton;
        private TextBox ReadTextBox;
        private Label ReadLabel;
        private TextBox FilterTextBox;
        private Label FilterLabel;
        private Button FilterButton;
    }
}