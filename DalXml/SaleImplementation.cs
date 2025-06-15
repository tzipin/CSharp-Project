using System.Reflection;
using System.Xml.Linq;
using DalApi;
using DO;
using Tools;

namespace Dal;

internal class SaleImplemention : ISale
{
    private const string SALE = "sale";
    private const string CODE = "code";
    private const string BARCODE = "barcode";
    private const string AMOUNT = "amount";
    private const string PRICE = "price";
    private const string ISCLUB = "isClub";
    private const string STARTDATE = "startDate";
    private const string ENDDATE = "endDate";
    private const string ARRYOFSALES = "ArrayOfSale";


    static string file_path = @"..\xml\sales.xml";
    XElement xel = XElement.Load(file_path);
    List<Sale> sales = new List<Sale>();
    public int Create(Sale item)
    {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create sale");
            Sale s = item with { code = Config.indexCode };
            xel.Add(new XElement(SALE,
                    new XElement(CODE, s.code),
                    new XElement(BARCODE, s.barcode),
                    new XElement(AMOUNT, s.amount),
                    new XElement(PRICE, s.price),
                    new XElement(ISCLUB, s.isClub),
                    new XElement(STARTDATE, s.startDate),
                    new XElement(ENDDATE, s.endDate)
            ));
            xel.Save(file_path);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create sale");
            return s.code;
    }

    public void Delete(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start delete sale");
            var p = xel.Elements().FirstOrDefault(s => int.Parse(s.Element(CODE).Value) == id);
            if (p == null)
                throw new DalIdNoFound("הלקוח לא קיים אצלינו");
            p.Remove();
            xel.Save(file_path);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end delete sale");
        }
        catch (Exception ex)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "faild delete customer from xml");
            throw new Exception("faild delete sale from xml", ex);
        }
    }

    public Sale? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read sale");
            XElement sale = xel.Descendants(SALE).FirstOrDefault(s => int.Parse(s.Element(CODE).Value) == id);
            if (sale != null)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read sale");
                return new Sale
                {
                    code = int.Parse(sale.Element(CODE).Value),
                    barcode = int.Parse(sale.Element(BARCODE).Value),
                    amount = int.Parse(sale.Element(AMOUNT).Value),
                    price = double.Parse(sale.Element(PRICE).Value),
                    isClub = bool.Parse(sale.Element(ISCLUB).Value),
                    startDate = DateTime.Parse(sale.Element(STARTDATE).Value),
                    endDate = DateTime.Parse(sale.Element(ENDDATE).Value)
                };
            }
            else
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id not found");
                throw new DO.DalIdNoFound("id not found");
            }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read genery sale");
        try
        { 
        List<Sale> sales = xel.Element(SALE).Elements()
            .Select(s => new Sale()
            {
                code = int.Parse(s.Element(CODE).Value),
                barcode = int.Parse(s.Element(BARCODE).Value),
                amount = int.Parse(s.Element(AMOUNT).Value),
                price = double.Parse(s.Element(PRICE).Value),
                isClub = bool.Parse(s.Element(ISCLUB).Value),
                startDate = DateTime.Parse(s.Element(STARTDATE).Value),
                endDate = DateTime.Parse(s.Element(ENDDATE).Value)
            }).ToList();
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read genery sale");
            return sales.Where(s => filter(s)).FirstOrDefault();
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "code is not found");
            throw new DalIdNoFound("ERROR! \t code is not found");
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start readAll sale");
        List<Sale> sales = xel.Elements(SALE)
            .Select(s => new Sale()
            {
                code = int.Parse(s.Element(CODE).Value),
                barcode = int.Parse(s.Element(BARCODE).Value),
                amount = int.Parse(s.Element(AMOUNT).Value),
                price = double.Parse(s.Element(PRICE).Value),
                isClub = bool.Parse(s.Element(ISCLUB).Value),
                startDate = DateTime.Parse(s.Element(STARTDATE).Value),
                endDate = DateTime.Parse(s.Element(ENDDATE).Value)
            }).ToList();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end readAll sale");
        if (filter == null)
        {
            return sales;   
        }
        return sales.Where(filter).ToList();
    }

    public void Update(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start update sale");
                    Delete(item.code);
            xel.Add(new XElement(SALE,
                new XElement(CODE, item.code),
                new XElement(BARCODE, item.barcode),
                new XElement(AMOUNT, item.amount),
                new XElement(PRICE, item.price),
                new XElement(ISCLUB, item.isClub),
                new XElement(STARTDATE, item.startDate),
                new XElement(ENDDATE, item.endDate)));
            xel.Save(file_path);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end update sale"); 
    }
}
