
using BlApi;
using BO;

namespace UI;
public partial class Customers : Form
{

    private static IBl bl = BlApi.Factory.Get;
    public Customers()
    {
        InitializeComponent();
        AllCustomers();
    }


    public void AllCustomers()
    {
        customersListBox.Items.Clear();
        List<BO.Customer> customers = bl.Customer.ReadAll();
        foreach (var customer in customers)
        {
            OneCustomer(customer);
        }
    }

    private void OneCustomer(BO.Customer customer)
    {
        customersListBox.Items.Add("מזהה: " + customer.Id);
        customersListBox.Items.Add("שם: " + customer.Name);
        customersListBox.Items.Add("כתובת: " + customer.Address);
        customersListBox.Items.Add("מס' טלפון: " + customer.Number_phone);
        customersListBox.Items.Add("---------------------------");
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
            AllCustomers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Updatebutton_Click(object sender, EventArgs e)
    {
        try
        {
            if (IdUpdateTextBox.Text == "" || NameUpdateTextBox.Text == "" || AddressUpdateTextBox.Text == "" || NumberPhoneTextBox.Text == "")
            {
                MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(IdUpdateTextBox.Text);
            string name = NameUpdateTextBox.Text;
            string address = AddressUpdateTextBox.Text;
            string numberPhone = NumberPhoneTextBox.Text;
            IdUpdateTextBox.Clear();
            NameUpdateTextBox.Clear();
            AddressUpdateTextBox.Clear();
            NumberPhoneTextBox.Clear();
            bl.Customer.Update(new BO.Customer(id, name, address, numberPhone));
            AllCustomers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (IdDeleteTextBox.Text == "")
            {
                MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(IdDeleteTextBox.Text);
            IdDeleteTextBox.Clear();
            bl.Customer.Delete(id);
            AllCustomers();
        }
        catch (Exception ex)
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
            CustomerListBox.Items.Clear();
            int id = int.Parse(ReadTextBox.Text);
            ReadTextBox.Clear();
            BO.Customer customer = bl.Customer.Read(id);
            CustomerListBox.Items.Add("מזהה: " + customer.Id);
            CustomerListBox.Items.Add("שם: " + customer.Name);
            CustomerListBox.Items.Add("כתובת: " + customer.Address);
            CustomerListBox.Items.Add("מס' טלפון: " + customer.Number_phone);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FilterButton_Click(object sender, EventArgs e)
    {
        customersListBox.Items.Clear();
        List<BO.Customer> filterCustomers = bl.Customer.ReadAll(c => c.Name.Contains(FilterTextBox.Text));
        foreach (var customer in filterCustomers)
        {
            OneCustomer(customer);
        }
    }
}
