using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal s_dal;
    private static List<int> ProductCode = new List<int>();

    private static void CreateProduct()
    {
        ProductCode.Add(s_dal.Product.Create(new Product(0, "כסא משרדי", category.שולחנות_וכיסאות, 500, 50)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "ארון בגדים ארבע דלתות", category.ארונות_וסיפריות, 1500, 5)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "ספת שלושה מושבים מעור נפתחת לשתי מיטות", category.ספות_וכרוסאות, 3000, 15)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "מיטה משולשת comphort", category.מיטות, 2000, 2)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "ארון ספרים מעץ מלא ארבע עמודות ללא ויטרינה", category.ארונות_וסיפריות, 4520, 11)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "ארון ספרים מסנדויץ שלושה עמודות עם ויטרינה", category.ארונות_וסיפריות, 3500, 8)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "ארון משחקים לחדר ילדים בצבעים ורוד ותכלת", category.ארונות_וסיפריות, 1000, 34)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "מערכת ספות 2+3 בשלל צבעים", category.ספות_וכרוסאות, 5800, 7)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "שולחן כתיבה 1.8 מטר", category.שולחנות_כתיבה_וכוורות, 999.9, 12)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "כוורת מחולקת לשש בצבע ירוק", category.שולחנות_כתיבה_וכוורות, 520, 100)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "שולחן למחשב", category.שולחנות_כתיבה_וכוורות, 790, 1)));
        ProductCode.Add(s_dal.Product.Create(new Product(0, "שולחן לפינת אוכל מזכוכית + ארבע כסאות", category.שולחנות_וכיסאות, 790, 1)));
    }

    private static void CreateCustomer()
    {
        s_dal.Customer.Create(new Customer(214861478, "ציפי נויגרשל", "חזון איש 23", "0556718370"));
        s_dal.Customer.Create(new Customer(328189378, "בתי מנדל", "אבני נזר 32", "0548574418"));
        s_dal.Customer.Create(new Customer(218985315, "שני מנדל", "אבני נזר 32", "0534136996")); 
    }
    
    private static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(0, 1004, 2, 900, false, DateTime.Now, new DateTime(2025, 03, 20)));
        s_dal.Sale.Create(new Sale(0, 1007, 1, 1400, true, new DateTime(2024,11,11), new DateTime(2024, 11, 12)));
        s_dal.Sale.Create(new Sale(0, 1010, 1, 2950, false, new DateTime(2024, 11, 20), DateTime.Now));
        
    }

    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateCustomer();
        CreateProduct();        
        CreateSale();
    }
}
