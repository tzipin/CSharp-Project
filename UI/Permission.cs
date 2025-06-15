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

namespace UI
{
    public partial class Permission : Form
    {
        private static IBl bl = BlApi.Factory.Get;
        public Permission()
        {
            InitializeComponent();
        }

        private void managerBtn_Click(object sender, EventArgs e)
        {
            ManagerMenu form = new ManagerMenu();
            form.Show();
        }
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("הכנס תז");
            int id = 0;
            if (input != "")
                id = int.Parse(input);
            BO.Customer c = null;
            if (bl.Customer.IsCustomerExist(id))
            {
                c = bl.Customer.Read(id);
                customerMain customermain = new customerMain(c);
                customermain.Show();
            }
            else
            {
                DialogResult clubNew = MessageBox.Show("האם ברצונך להצטרף למועדון?","הודעה",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(clubNew == DialogResult.Yes)
                {
                    NewClub newClub = new NewClub(input);
                    newClub.Show();
                }
                else
                {
                    customerMain customermain = new customerMain(c);
                    customermain.Show();
                }
            }

        }
    }
}
