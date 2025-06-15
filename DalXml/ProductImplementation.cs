using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal;

internal class ProductImplemention : IProduct
{
    static string file_path = @"..\xml\products.xml";
    static XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
    public int Create(Product item)
    {       
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create product");
        List<Product> products = new List<Product>();
        item = item with { barcode = Config.indexBarcode };
        using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            products = serializer.Deserialize(fs) as List<Product>;
            products.Add(item);
            fs.Position = 0;
            serializer.Serialize(fs, products);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create product");
        return item.barcode;        
    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start delete product");
        List<Product> products = new List<Product>();
        using (FileStream fs = new FileStream(file_path, FileMode.Open))
        {
            products = serializer.Deserialize(fs) as List<Product>;
        }
        Product p = Read(id);
        if(products == null || p == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "barcode is not found");
            throw new DalIdNoFound("ERROR! \t barcode is not found");
        }
        products.Remove(p);
        using(FileStream fs = new FileStream(file_path, FileMode.Create))
        {
            serializer.Serialize(fs, products);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start delete product");
    }

    public Product? Read(int id)
    {         
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read product");
        Product product;
        using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.Read))
        {
            product = (serializer.Deserialize(fs) as List<Product>).SingleOrDefault(p => p.barcode == id);
        }
        if (product == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "barcode is not found");
            throw new DalIdNoFound("ERROR! \t barcode is not found");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read product");
        return product;
    }

    public Product? Read(Func<Product, bool> filter)
    {
         
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read genery product");
        Product product;
        using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.Read))
        {
            product = (serializer.Deserialize(fs) as List<Product>).First(p => filter(p));
                
        }
        if (product == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "No items found matching your search");
            throw new DalIdNoFound("ERROR! \t No items found matching your search");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read genery product");
        return product;
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {       
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start readall product");
        List<Product> products = new List<Product>();
        using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.Read))
        {
            products = serializer.Deserialize(fs) as List<Product>;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end readall product");

        if (filter == null)
        {
            return products;
        }
        return products.Where(filter).ToList();        
    }

    public void Update(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start update product");
        List<Product> products = new List<Product>();
        using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            products = serializer.Deserialize(fs) as List<Product>;
        }
        if (products == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product is no fuond");
            throw new DalIdNoFound("product is no fuond");
        }
        Product product = products.SingleOrDefault(p => p.barcode == item.barcode);
        if (product == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product is no fuond");
            throw new DalIdNoFound("product is no fuond");
        }
        products.Remove(product);
        products.Add(item);
        using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            serializer.Serialize(fs, products);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end update product");
    }
}
