using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI;

public partial class NewClub : Form
{
    private static IBl bl = BlApi.Factory.Get;

    public NewClub(string id)
    {
        InitializeComponent();
        idtextBox.Text = id;
    }

    private void addBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (idtextBox.Text == "" || nametextBox.Text == "" || addresstextBox.Text == "" || numberphontextBox.Text == "")
            {
                MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(idtextBox.Text);
            string name = nametextBox.Text;
            string address = addresstextBox.Text;
            string numberPhone = numberphontextBox.Text;
            idtextBox.Clear();
            nametextBox.Clear();
            addresstextBox.Clear();
            numberphontextBox.Clear();
            bl.Customer.Create(new BO.Customer(id, name, address, numberPhone));
            MessageBox.Show("הצטרפת בהצלחה למועדון!!!!", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Permission permission = new Permission();
        //permission.Show();
        this.Close();
    }
}
