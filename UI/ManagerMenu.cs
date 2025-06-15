using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
namespace UI
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.Show();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            LogManager.DeleteLog();
            MessageBox.Show( "הלוגים נמחקו בהצלחה","הודעה",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
