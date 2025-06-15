using System.Data;
using BO;
using DO;


namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer item)
    {
        try
        {
            if (item == null || item.Id == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            if (IsCustomerExist(item.Id))
                throw new BlIdExists("הלקוח כבר קיים במערכת");
            return _dal.Customer.Create(item.CastCustomerToDO());
        }
        catch (DO.DalIdExists e)
        {
            throw new BlIdExists(e.Message, e);
        }
    }

    public void Delete(int id)
    {
        try
        {
            if (id == 0 || id == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            _dal.Customer.Delete(id);
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public bool IsCustomerExist(int id)
    {
        try
        {
            if(_dal.Customer.ReadAll().FirstOrDefault(c => c.id == id) == null)
                return false;
            return true;
        }
        catch (Exception e) 
        {
            throw e;
        }
    }

    public BO.Customer? Read(int id)
    {
        try
        {
            return _dal.Customer.Read(id).CastCustomerToBO();
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try
        {
            return _dal.Customer.Read(c => filter(c.CastCustomerToBO())).CastCustomerToBO();
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }

    }

    public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        try
        {
            if(filter == null)
                return _dal.Customer.ReadAll().Select(c => c.CastCustomerToBO()).ToList();
            return _dal.Customer.ReadAll(c => filter(c.CastCustomerToBO())).Select(c => c.CastCustomerToBO()).ToList();
        } 
        catch (Exception e) 
        {
            throw e;
        }
    }

    public void Update(BO.Customer item)
    {
        try
        {
            if (item == null || item.Id == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            _dal.Customer.Update(item.CastCustomerToDO());
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }
}
