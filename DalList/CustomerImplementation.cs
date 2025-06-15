using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace Dal;

internal class CustomerImplementation:ICustomer
{
    public int Create(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start create customer");
        if(DataSource.Customers.FirstOrDefault(c => c.id == item.id) != null)            
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "this customer exists");
                throw new DalIdExists("ERROR! \t this customer exists");
            }
        
        DataSource.Customers.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end create customer");

        return item.id;
        
    }
    public Customer? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read customer");
        try
        {
            Customer customer = DataSource.Customers.Single<Customer>(c => c.id == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read customer");
            return customer;
        }
        catch 
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id is not found");
            throw new DalIdNoFound("ERROR! \t id is not found");
        }

    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start read genery customer");
            Customer cust = DataSource.Customers.First(c => filter(c));
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end read genery customer");

            return cust;
        }
        catch
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "id is not found");
            throw new DalIdNoFound("ERROR! \t id is not found");
        }
    }
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start readall customer");
        List<Customer> cust = DataSource.Customers.Where<Customer>(filter).ToList();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end readall customer");
        return cust;
    }
    public void Update(Customer item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start update customer");
        Delete(item.id);
        DataSource.Customers.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end update customer");
    }
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start delete customer");
        DataSource.Customers.Remove(Read(id));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end delete customer");
    }


}
