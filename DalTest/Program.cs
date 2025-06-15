using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace DalTest
{
    internal class Program
    {
        private static readonly IDal s_dal = DalApi.Factory.Get;

        private static int PrintMainMenu()
        {
            string temp;
            int chooseEntity;
            Console.WriteLine("main menu\n to exit print 0  \n " +
                "for product actions print 1\n " +
                "for customer actions print 2 \n " +
                "for sale actions print 3 \n" +
                "for delete log file print 4");
            temp = Console.ReadLine();
            int.TryParse(temp, out chooseEntity);
            return chooseEntity;
        }

        private static int PrintSeconderyMenue(string entity)
        {
            string temp;
            int chooseAction;
            Console.WriteLine($"secondery menue \n for add {entity} print 1 \n" +
                $"for show {entity} print 2 \n for show all {entity}s print 3 \n" +
                $"for update {entity} print 4 \n for delete {entity} print 5");
            temp = Console.ReadLine();
            int.TryParse(temp, out chooseAction);
            return chooseAction;
        }

        private static Sale GetDataSale()
        {
            string temp;
            int barcode, amount, startDay, startMounth, startYear,
                endDay, endMounth, endYear;
            double price;
            bool isClub;
            Console.WriteLine("enter barcode product on sale");
            temp = Console.ReadLine();
            int.TryParse(temp, out barcode);
            Console.WriteLine("enter product quantity and price");
            temp = Console.ReadLine();
            int.TryParse(temp, out amount);
            temp = Console.ReadLine();
            double.TryParse(temp, out price);
            Console.WriteLine("If the offer is for club members only, press 1, otherwise press 0");
            temp = Console.ReadLine();
            if(temp == "1")
                isClub = true;
            else
                isClub = false;
            Console.WriteLine("enter the start date of the sale\n enter day");
            temp = Console.ReadLine();
            int.TryParse(temp, out startDay);
            Console.WriteLine("enter nonth");
            temp = Console.ReadLine();
            int.TryParse(temp, out startMounth);
            Console.WriteLine("enter year");
            temp = Console.ReadLine();
            int.TryParse(temp, out startYear);
            DateTime startDate = new DateTime(startYear, startMounth, startDay);
            Console.WriteLine("enter the end date of the sale\n enter day");
            temp = Console.ReadLine();
            int.TryParse(temp, out endDay);
            Console.WriteLine("enter nonth");
            temp = Console.ReadLine();
            int.TryParse(temp, out endMounth);
            Console.WriteLine("enter year");
            temp = Console.ReadLine();
            int.TryParse(temp, out endYear);
            DateTime endDate = new DateTime(endYear, endMounth, endDay);
            return new Sale(0, barcode, amount, price, isClub, startDate, endDate);
        }

        private static Product GetDataProduct()
        {
            string temp, name;
            int amount;
            category categorya;
            double price;
            Console.WriteLine("enter product name");
            name = Console.ReadLine();
            Console.WriteLine("enter a category: for cabinets and bookcases print 0 \n for beds print 1 \n for sofas and armchairs print 2\n for tables and chairs print 3\n for desks and beehives print 4\n ");
            temp = Console.ReadLine();
            category.TryParse(temp, out categorya);
            Console.WriteLine("print price");
            temp = Console.ReadLine();
            double.TryParse(temp, out price);
            Console.WriteLine("enter the product's stock quantity.");
            temp = Console.ReadLine();
            int.TryParse(temp, out amount);
            return new Product(0, name, categorya, price, amount);
        }

        private static Customer GetDataCustomer()
        {
            string temp, name, address, numberPhone;
            int id;
            Console.WriteLine("enter identity");
            temp = Console.ReadLine();
            int.TryParse(temp, out id);
            Console.WriteLine("enter first name and last name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
            Console.WriteLine("enter phon number");
            numberPhone = Console.ReadLine();
            return new Customer(id, name, address, numberPhone);
        }

        private static void CreateSale()
        {
            s_dal.Sale.Create(GetDataSale());
        }

        private static void UpdateSale()
        {
            try
            {
                string temp;
                int code;
                Console.WriteLine("הכנס קוד מבצע לעידכון");
                temp = Console.ReadLine();
                int.TryParse(temp, out code);
                Sale s = GetDataSale();
                s_dal.Sale.Update(new Sale(code, s.barcode, s.amount, s.price, s.isClub, s.startDate, s.endDate));
            }
            catch (DalIdNoFound e) 
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
                Console.WriteLine(e.ToString()); 
            }
        }

        private static void CreateProduct()
        {            
                s_dal.Product.Create(GetDataProduct());
        }

        private static void UpdateProduct()
        {
            try
            {
                Console.WriteLine("הכנס ברקוד מוצר לעידכון");
                string temp = Console.ReadLine();
                int barcode;
                int.TryParse(temp, out barcode);
                Product p = GetDataProduct();
                s_dal.Product.Update(new Product
                (barcode, p.name, p.category, p.price, p.amount));
            }
            catch (DalIdNoFound e) 
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
                Console.WriteLine(e.ToString());
            }
        }

        private static void CreateCustomer()
        {
            try
            {
                s_dal.Customer.Create(GetDataCustomer());
            }
            catch (DalIdExists e) 
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
                Console.WriteLine(e.ToString());
            }
        }

        private static void UpdateCustomer()
        {
            try
            {
                s_dal.Customer.Update(GetDataCustomer());
            }
            catch (DalIdNoFound e) 
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
                Console.WriteLine(e.ToString());
            }
        }

        private static void Read<T>(ICrud<T> crud)
        {
            try
            {
                string temp;
                int code;
                Console.WriteLine("הכנס קוד להצגה");
                temp = Console.ReadLine();
                int.TryParse(temp, out code);
                Console.WriteLine(crud.Read(code));
            }
            catch(DalIdNoFound e) 
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
                Console.WriteLine(e.ToString()); 
            }
        }

        private static void ReadAll<T>(ICrud<T> crud)
        {
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }

        private static void Deleat<T>(ICrud<T> crud) 
        {
            try
            {
                string temp;
                int code;
                Console.WriteLine("הכנס קוד למחיקה");
                temp = Console.ReadLine();
                int.TryParse(temp, out code);
                crud.Delete(code);
            }
            catch (DalIdNoFound e) 
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
                Console.WriteLine(e.ToString()); 
            }
        }            

        private static void MainSwitch(int choose)
        {
            switch (choose)
            {
                case 1:
                    ProductSwitch();
                    break;
                case 2:
                    CustomerSwitch();
                    break;
                case 3:
                    SaleSwitch();
                    break;
                case 4:
                    LogManager.DeleteLog();
                    break;
            }
        }

        private static void CustomerSwitch()
        {
            int chooseAction = PrintSeconderyMenue("customer");
            switch (chooseAction) { 
                case 1:
                    CreateCustomer();
                    break;
                case 2:
                    Read<Customer>(s_dal.Customer); 
                    break;
                case 3:
                    ReadAll<Customer>(s_dal.Customer);
                    break;
                case 4:
                    UpdateCustomer();
                    break;
                case 5:
                    Deleat<Customer>(s_dal.Customer);
                    break;
            }
        }

        private static void ProductSwitch()
        {
            int chooseAction = PrintSeconderyMenue("product");
            switch (chooseAction)
            {
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    Read<Product>(s_dal.Product);
                    break;
                case 3:
                    ReadAll<Product>(s_dal.Product);
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    Deleat<Product>(s_dal.Product);
                    break;
            }
        }

        private static void SaleSwitch()
        {
            int chooseAction = PrintSeconderyMenue("sale");
            switch (chooseAction)
            {
                case 1:
                    CreateSale();
                    break;
                case 2:
                    Read<Sale>(s_dal.Sale);
                    break;
                case 3:
                    ReadAll<Sale>(s_dal.Sale);
                    break;
                case 4:
                    UpdateSale();
                    break;
                case 5:
                    Deleat<Sale>(s_dal.Sale);
                    break;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int chooseEntity;
                //Initialization.Initialize();
                chooseEntity = PrintMainMenu();
                while (chooseEntity != 0)
                {
                    MainSwitch(chooseEntity);
                    chooseEntity = PrintMainMenu();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.ToString());
            }
        }
    }
}