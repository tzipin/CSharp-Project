

using System.Reflection;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal;
internal class CustomerImplementation : ICustomer
{
    static string file_path = @"..\xml\customers.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
    public int Create(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create customer");
        List<Customer> customers = new List<Customer>();
        using (FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            customers = serializer.Deserialize(fs) as List<Customer>;
            if(customers != null && customers.Contains(item))
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer are exists");
                throw new DalIdExists("customer are exists");
            }
            customers.Add(item);
            fs.Position = 0;
            serializer.Serialize(fs, customers);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create customer");
        return item.id;
    }
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start delete customer");
        List<Customer> customers = new List<Customer>();
        using (FileStream fs = new FileStream(file_path, FileMode.Open))
        {
            customers = serializer.Deserialize(fs) as List<Customer>;
        }
        if (customers == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer is not exists");
            throw new DalIdNoFound("customer is not exists");
        }
        Customer customer = customers.SingleOrDefault(c => c.id == id);
        if (customer == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer is not exists");
            throw new DalIdNoFound("customer is not exists");
        }
        customers.Remove(customer);
        using (FileStream fs = new FileStream(file_path, FileMode.Create))
        {
            serializer.Serialize(fs, customers);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end delete customer");
    }
    public Customer? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read customer");
        Customer customer;
        using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.Read))
        {
            customer = (serializer.Deserialize(fs) as List<Customer>).SingleOrDefault(c => c.id == id);
        }
        if (customer == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "customer is not exists");
            throw new DalIdNoFound("customer is not exists");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read customer");
        return customer;
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read genery customer");
        Customer customer;
        using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.Read))
        {
            customer = (serializer.Deserialize(fs) as List<Customer>).First(c => filter(c));
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read genery customer");
        return customer;
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start readall customer");
        List<Customer> customers = new List<Customer>();
        using (FileStream fs = new FileStream(file_path, FileMode.Open, FileAccess.Read))
        {
            customers = serializer.Deserialize(fs) as List<Customer>;
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end readall customer");
        if(filter == null)
            return customers;
        return customers.Where(filter).ToList();
    }
    public void Update(Customer item) 
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start update customer");
        List<Customer> customers = new List<Customer>();
        using (FileStream fs = new FileStream(file_path, FileMode.Open))
        {
            customers = serializer.Deserialize(fs) as List<Customer>;
        }
        Customer customer = customers.SingleOrDefault(c => c.id == item.id);
        if (customer == null)
            throw new DalIdNoFound("הלקוח לא רשום אצלינו");
        customers.Remove(customer);
        customers.Add(item);
        using (FileStream fs = new FileStream(file_path, FileMode.Create)) 
        {
            serializer.Serialize(fs, customers);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end update customer");
    }
}
