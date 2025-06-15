namespace UI
{
    partial class NewClub
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
            addBtn = new Button();
            nametextBox = new TextBox();
            numberphontextBox = new TextBox();
            addresstextBox = new TextBox();
            idtextBox = new TextBox();
            namelabel = new Label();
            label2 = new Label();
            numberphonlabel = new Label();
            idlabel = new Label();
            ClubLabel = new Label();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(243, 327);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(86, 31);
            addBtn.TabIndex = 18;
            addBtn.Text = "הוספה";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(341, 151);
            nametextBox.Margin = new Padding(3, 4, 3, 4);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(114, 27);
            nametextBox.TabIndex = 17;
            // 
            // numberphontextBox
            // 
            numberphontextBox.Location = new Point(341, 265);
            numberphontextBox.Margin = new Padding(3, 4, 3, 4);
            numberphontextBox.Name = "numberphontextBox";
            numberphontextBox.Size = new Size(114, 27);
            numberphontextBox.TabIndex = 16;
            // 
            // addresstextBox
            // 
            addresstextBox.Location = new Point(341, 208);
            addresstextBox.Margin = new Padding(3, 4, 3, 4);
            addresstextBox.Name = "addresstextBox";
            addresstextBox.Size = new Size(114, 27);
            addresstextBox.TabIndex = 15;
            // 
            // idtextBox
            // 
            idtextBox.Location = new Point(341, 93);
            idtextBox.Margin = new Padding(3, 4, 3, 4);
            idtextBox.Name = "idtextBox";
            idtextBox.Size = new Size(114, 27);
            idtextBox.TabIndex = 14;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(481, 161);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(77, 20);
            namelabel.TabIndex = 13;
            namelabel.Text = "שם הלקוח";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 219);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 12;
            label2.Text = "כתובת";
            // 
            // numberphonlabel
            // 
            numberphonlabel.AutoSize = true;
            numberphonlabel.Location = new Point(485, 276);
            numberphonlabel.Name = "numberphonlabel";
            numberphonlabel.Size = new Size(71, 20);
            numberphonlabel.TabIndex = 11;
            numberphonlabel.Text = "מס' טלפון";
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(523, 104);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(31, 20);
            idlabel.TabIndex = 10;
            idlabel.Text = "ת\"ז";
            // 
            // ClubLabel
            // 
            ClubLabel.AutoSize = true;
            ClubLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ClubLabel.Location = new Point(324, 34);
            ClubLabel.Name = "ClubLabel";
            ClubLabel.Size = new Size(148, 25);
            ClubLabel.TabIndex = 19;
            ClubLabel.Text = "הצטרפות למועדון";
            // 
            // NewClub
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClubLabel);
            Controls.Add(addBtn);
            Controls.Add(nametextBox);
            Controls.Add(numberphontextBox);
            Controls.Add(addresstextBox);
            Controls.Add(idtextBox);
            Controls.Add(namelabel);
            Controls.Add(label2);
            Controls.Add(numberphonlabel);
            Controls.Add(idlabel);
            Name = "NewClub";
            Text = "NewClub";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox nametextBox;
        private TextBox numberphontextBox;
        private TextBox addresstextBox;
        private TextBox idtextBox;
        private Label namelabel;
        private Label label2;
        private Label numberphonlabel;
        private Label idlabel;
        private Label ClubLabel;
    }
}