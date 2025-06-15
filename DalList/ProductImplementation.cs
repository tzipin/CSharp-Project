using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create product");
        Product p = item with { barcode = DataSource.Config.barcode };
        DataSource.Products.Add(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create product");
        return p.barcode;
    }
    public Product? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read product");
            Product product = DataSource.Products.Single<Product>(p => p.barcode == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read product");
            return product;
        }
        catch 
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "barcode is not found");
            throw new DalIdNoFound("ERROR! \t barcode is not found");
        }
    }
    public Product? Read(Func<Product, bool> filter)
    {
        try { 
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read genery product");
        Product prod = DataSource.Products.First(p => filter(p));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read genery product");
        return prod;
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "barcode is not found");
            throw new DalIdNoFound("ERROR! \t barcode is not found");
        }
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start readall product");
        List<Product> prod = DataSource.Products.Where<Product>(filter).ToList();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end readall product");
        return prod;
    }
    public void Update(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start update product");
        Delete(item.barcode);
        DataSource.Products.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end update product");
    }
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start delete product");
        DataSource.Products.Remove(Read(id));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end delete product");
    }
}
