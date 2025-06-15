using BlApi;
using BO;

namespace UI;

public partial class Products : Form
{
    private static IBl bl = BlApi.Factory.Get;
    public Products()
    {
        InitializeComponent();
        AllProducts();
        foreach (var cat in Enum.GetValues(typeof(BO.category)))
        {
            CategoryComboBox.Items.Add(cat);
            CategoryUpdateComboBox.Items.Add(cat);
            FilterComboBox.Items.Add(cat);
        }
        FilterComboBox.Items.Add("הכל");
    }
    public void AllProducts()
    {
        ProductsListBox.Items.Clear();
        List<BO.Product> products = bl.Product.ReadAll();
        foreach (var p in products)
        {
            OneProduct(p);
        }
    }
    public void OneProduct(BO.Product p)
    {
        ProductsListBox.Items.Add("מזהה: " + p.Barcode);
        ProductsListBox.Items.Add("שם המוצר: " + p.Name);
        ProductsListBox.Items.Add("מחיר למוצר אחד: " + p.Price);
        ProductsListBox.Items.Add("כמות: " + p.Amount);
        ProductsListBox.Items.Add("קטגוריה: " + p.Category);
        ProductsListBox.Items.Add("---------------------------");
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
            int barcode = int.Parse(IdDeleteTextBox.Text);
            IdDeleteTextBox.Clear();
            bl.Product.Delete(barcode);
            AllProducts();
        }
        catch (BlIdNoFound ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (NameTextBox.Text == "" || PriceTextBox.Text == "" || AmountTextBox.Text == string.Empty || CategoryComboBox.Text == string.Empty)
        {
            MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        string name = NameTextBox.Text;
        int price = int.Parse(PriceTextBox.Text);
        int amount = int.Parse(AmountTextBox.Text);
        BO.category cat = (BO.category)Enum.Parse(typeof(BO.category), CategoryComboBox.Text);
        NameTextBox.Clear();
        PriceTextBox.Clear();
        AmountTextBox.Clear();
        bl.Product.Create(new BO.Product(0, name, cat, price, amount));
        AllProducts();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (IdUpdateTextBox.Text == "" || NameUpdateTextBox.Text == "" || PriceUpdateTextBox.Text == "" || AmountUpdateTextBox.Text == string.Empty || CategoryUpdateComboBox.Text == string.Empty)
            {
                MessageBox.Show("!כל השדות חובה", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int barcode = int.Parse(IdUpdateTextBox.Text);
            string name = NameUpdateTextBox.Text;
            int price = int.Parse(PriceUpdateTextBox.Text);
            int amount = int.Parse(AmountUpdateTextBox.Text);
            BO.category cat = (BO.category)Enum.Parse(typeof(BO.category), CategoryUpdateComboBox.Text);
            IdUpdateTextBox.Clear();
            NameUpdateTextBox.Clear();
            PriceUpdateTextBox.Clear();
            AmountUpdateTextBox.Clear();
            bl.Product.Update(new BO.Product(barcode, name, cat, price, amount));
            AllProducts();
        }
        catch (BlIdNoFound ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

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
            int code = int.Parse(ReadTextBox.Text);
            ReadTextBox.Clear();
            BO.Product p = bl.Product.Read(code);
            ProductListBox.Items.Add("מזהה: " + p.Barcode);
            ProductListBox.Items.Add("שם המוצר: " + p.Name);
            ProductListBox.Items.Add("מחיר למוצר אחד: " + p.Price);
            ProductListBox.Items.Add("כמות: " + p.Amount);
            ProductListBox.Items.Add("קטגוריה: " + p.Category);
        }
        catch (BlIdNoFound ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FilterButton_Click(object sender, EventArgs e)
    {
        try
        {
            string category = FilterComboBox.Text;
            if (category == "הכל")
            {
                AllProducts();
                return;
            }
            ProductsListBox.Items.Clear();
            List<BO.Product> products = bl.Product.ReadAll(p => p.Category.ToString() == category);
            foreach (var p in products)
            {
                OneProduct(p);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
