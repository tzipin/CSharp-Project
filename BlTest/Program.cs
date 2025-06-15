﻿
namespace BlTest;
internal class Program
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get;
    public static void AddProduct(BO.Order order)
    {
        string temp;
        Console.WriteLine("insert id of product");
        temp = Console.ReadLine();
        int id;
        int.TryParse(temp, out id);
        Console.WriteLine("insert quantity");
        temp = Console.ReadLine();
        int quantity;
        int.TryParse(temp, out quantity);

        List<BO.SaleInProduct> salse =  s_bl.Order.AddProductToOrder(order, id, quantity);
        //salse.ToString();
        Console.WriteLine(string.Join(' ', salse));
        Console.WriteLine(order.FinalyPrice);
    }

    public static bool getId()
    {
        Console.WriteLine("insert id of customer");
        string id = Console.ReadLine();
        if (id == "0")
            return false;
        return true;
    }

    public static void test()
    {
        string newOrder = "1";
        BO.Order order = null;
        while (newOrder == "1") { 
            order = new BO.Order(getId(), null, 0);
            string newProduct = "1";
            while (newProduct == "1")
            {
                AddProduct(order);

                Console.WriteLine("to add product insert 1, to end order insert 0");
                newProduct = Console.ReadLine();
            }
            Console.WriteLine($"{order.FinalyPrice}");
            Console.WriteLine("to add order insert 1, to exit insert 0");
            newOrder = Console.ReadLine();
        }
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("to Initialize press 1, not Initialize press other");
        int init;
        int.TryParse(Console.ReadLine(), out init);
        if (init == 1)
            DalTest.Initialization.Initialize();
        test();
    }
}