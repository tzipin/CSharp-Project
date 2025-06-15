using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace Dal;

internal class SaleImplementation: ISale
{
    public int Create(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create sale");
        Sale s = item with { code = DataSource.Config.code };
        DataSource.Sales.Add(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create sale");
        return s.code;
    }
    public Sale? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read sale");
            Sale sale = DataSource.Sales.First<Sale>(s => s.barcode == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read sale");
            return sale;
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "code is not found");
            throw new DalIdNoFound("ERROR! \t code is not found");
        }
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        try { 
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read genery sale");
        Sale sale = DataSource.Sales.First(s => filter(s));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read genery sale");
        return sale;
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "code is not found");
            throw new DalIdNoFound("ERROR! \t code is not found");
        }
    }
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end raedall sale");
        if(filter == null)
            return new List<Sale?>(DataSource.Sales);
        List<Sale> sale = DataSource.Sales.Where<Sale>(s => filter(s)).ToList();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end readall sale");
        return sale;
    }
    public void Update(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start update sale");
        Delete(item.code);
        DataSource.Sales.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end update sale");
    }
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start delete sale");
        DataSource.Sales.Remove(Read(id));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end delete sale");
    }
}
