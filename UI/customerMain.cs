using BlApi;
using BO;

namespace UI;

public partial class customerMain : Form
{
    private static IBl bl = BlApi.Factory.Get;
    BO.Customer customer;
    static List<Product>? products;
    static Order? order;
    public customerMain(Customer customer)
    {
        InitializeComponent();
        order = new Order(customer != null, new List<BO.ProductInOrder>(), 0);
        //this.Width = 800;
        //this.Height = 600;
        if (customer == null)
        {
            HelloLabel.Text = "שלום לקוח מזדמן";
        }
        else
        {
            HelloLabel.Text = $"שלום {customer.Name}";
        }
        //bl.Order.DoOrder(order);
        //panel1.Visible = false;
        products = bl.Product.ReadAll();
        var categories = products
            .GroupBy(p => p!.Category)
            .ToList();
        ProductTabControl.TabPages.Clear();
        //ProductsDataGridView.TabP
        foreach (var categoryGroup in categories)
        {
            TabPage? tab = new(categoryGroup.Key.ToString());
            DataGridView? ProductsDataGridView = new()
            {
                Size = new Size(500, 300),
                //Size = new Size(tab.Size.Width, tab.Size.Height),
                //MinimumSize = tab.Size,
                //MaximumSize = tab.Size,
                ColumnCount = 3,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
            };
            tab.BorderStyle = BorderStyle.None;            
            ProductsDataGridView.Columns[0].Name = "שם מוצר";
            ProductsDataGridView.Columns[0].ValueType = typeof(string);
            ProductsDataGridView.Columns[1].Name = "מחיר ליחידה";
            ProductsDataGridView.Columns[2].Name = "id";
            ProductsDataGridView.Columns[2].Visible = false;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoryGroup.ToList().ForEach(product => ProductsDataGridView.Rows.Add(product!.Name, product.Price, product.Barcode));
            //MessageBox.Show(ProductsDataGridView.Rows.Count.ToString());
            ProductsDataGridView.CellDoubleClick += (s, e) => SelectProduct(s, e, ProductsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            tab.Controls.Add(ProductsDataGridView);
            ProductTabControl.TabPages.Add(tab);
        }
        EndPayLabel.Text = "הסכום לתשלום: 0.0";
    }

    private void SelectProduct(Object s, DataGridViewCellEventArgs e, string code)
    {
        try
        {
            //MessageBox.Show(code);
            int id;
            int.TryParse(code, out id);
            BO.Product product = bl.Product.Read(id);
            SalesForProduct(id);
            int quantity = 0;
            string input = Microsoft.VisualBasic.Interaction.InputBox($"{product.Name}\nהכנס כמות רצויה");
            if (!int.TryParse(input, out quantity) || quantity == 0)
            {
                MessageBox.Show("הקלט אינו תקין. אנא נסה שוב.");
                return;
                //input = Microsoft.VisualBasic.Interaction.InputBox("הכנס כמות רצויה");
            }
            List<BO.SaleInProduct> sales = bl.Order.AddProductToOrder(order, id, quantity);
            BasketListBox.DataSource = order.Products.SelectMany(p => p.ToStringProperty().Split("\n").Append("🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺🧺")).ToList();
            bl.Order.CalcTotalPrice(order);
            EndPayLabel.Text = $"הסכום לתשלום: {order.FinalyPrice}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //BO.ProductInOrder productInOrder = product





    }

    private void SalesForProduct(int id)
    {
        //MessageBox.Show(bl.Order.SearchSaleForProduct())
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        bl.Order.DoOrder(order);
        MessageBox.Show("הזמנתך נקלטה בהצלחה");
    }
}
