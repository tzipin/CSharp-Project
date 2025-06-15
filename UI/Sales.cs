using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Sales : Form
    {
        private static IBl bl = BlApi.Factory.Get;
        public Sales()
        {
            InitializeComponent();
            AllSales();
        }

        private void ProductTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BarcodeTextBox.Text == "" || AmountTextBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int barCode = int.Parse(BarcodeTextBox.Text);
            int amount = int.Parse(AmountTextBox.Text);
            int price = int.Parse(PriceTextBox.Text);
            bool isClub = IsClubCheckBox.Checked;
            DateTime startDate = DateTime.Parse(StartDatePicker.Text);
            DateTime endDate = DateTime.Parse(StartDatePicker.Text);

            BarcodeTextBox.Clear();
            AmountTextBox.Clear();
            PriceTextBox.Clear();
            StartDatePicker.Text = DateTime.Now.ToString();
            EndDatePicker.Text = DateTime.Now.ToString();

            bl.sale.Create(new BO.Sale(0, barCode, amount, price, isClub, startDate, endDate));
            AllSales();
        }

        private void AllSales()
        {
            SalesListBox.Items.Clear();
            List<BO.Sale> salse = bl.sale.ReadAll();
            foreach (var s in salse)
            {
                OneSale(s);
            }
        }

        private void OneSale(BO.Sale s)
        {
            SalesListBox.Items.Add("קוד המבצע: " + s.Code);
            SalesListBox.Items.Add("ברקוד המוצר: " + s.Barcode);
            SalesListBox.Items.Add("כמות: " + s.Amount);
            SalesListBox.Items.Add("במחיר: " + s.Price);
            SalesListBox.Items.Add("תאריך התחלה: " + s.StartDate);
            SalesListBox.Items.Add("תאריך סיום: " + s.EndDate);
            if (s.IsClub == true)
                SalesListBox.Items.Add("לחברי מועדון בלבד");
            SalesListBox.Items.Add("------------------------------");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodeUpdateTextBox.Text == "" || BarcodeUpdatetextBox.Text == "" || AmountUpdateTextBox.Text == "" || PriceUpdateTextBox.Text == "")
                {
                    MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int code = int.Parse(CodeUpdateTextBox.Text);
                int barCode = int.Parse(BarcodeUpdatetextBox.Text);
                int amount = int.Parse(AmountUpdateTextBox.Text);
                int price = int.Parse(PriceUpdateTextBox.Text);
                bool isClub = IsClubUpdateCheckBox.Checked;
                DateTime startDate = DateTime.Parse(StartUpdateDateTimePicker.Text);
                DateTime endDate = DateTime.Parse(EndUpdateDateTimePicker.Text);

                CodeUpdateTextBox.Clear();
                BarcodeUpdatetextBox.Clear();
                AmountUpdateTextBox.Clear();
                PriceUpdateTextBox.Clear();
                StartUpdateDateTimePicker.Text = DateTime.Now.ToString();
                EndUpdateDateTimePicker.Text = DateTime.Now.ToString();

                bl.sale.Update(new BO.Sale(code, barCode, amount, price, isClub, startDate, endDate));
                AllSales();
            }
            catch (BlIdNoFound ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdDeleteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdDeleteTextBox.Text == "")
                {
                    MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int code = int.Parse(IdDeleteTextBox.Text);
                IdDeleteTextBox.Clear();
                bl.sale.Delete(code);
                AllSales();
            }
            catch (BlIdNoFound ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReadTextBox.Text == "")
                {
                    MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ReadSaletListBox.Items.Clear();
                int code = int.Parse(ReadTextBox.Text);
                ReadTextBox.Clear();
                BO.Sale s = bl.sale.Read(code);
                ReadSaletListBox.Items.Add("קוד המבצע: " + s.Code);
                ReadSaletListBox.Items.Add("ברקוד המוצר: " + s.Barcode);
                ReadSaletListBox.Items.Add("כמות: " + s.Amount);
                ReadSaletListBox.Items.Add("במחיר: " + s.Price);
                ReadSaletListBox.Items.Add("תאריך התחלה: " + s.StartDate);
                ReadSaletListBox.Items.Add("תאריך סיום: " + s.EndDate);
                if (s.IsClub == true)
                    ReadSaletListBox.Items.Add("לחברי מועדון בלבד");
            }
            catch (BlIdNoFound ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            SalesListBox.Items.Clear();
            List<Sale> filterSalse = bl.sale.ReadAll(s => s.IsClub == FilterCheckBox.Checked);
            foreach (var s in filterSalse)
            {
                OneSale(s);
            }
        }

        private void AllSalesbBtton_Click(object sender, EventArgs e)
        {
            AllSales();
        }
    }
}
