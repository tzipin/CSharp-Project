using BO;
using DO;
using static BO.Tools;
namespace BlImplementation;

internal class SaleImplementation : BlApi.ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    
    public int Create(BO.Sale item)
    {
        try
        {
            if (item == null || item.Code == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            return _dal.Sale.Create(item.CastSaleToDO());
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _dal.Sale.Delete(id);
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public BO.Sale? Read(int id)
    {
        try
        {
            return _dal.Sale.Read(id).CastSaleToBO();
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.Sale.Read(s => filter(s.CastSaleToBO())).CastSaleToBO();
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Sale.ReadAll().Select(s => s.CastSaleToBO()).ToList();
            return _dal.Sale.ReadAll(s => filter(s.CastSaleToBO())).Select(s => s.CastSaleToBO()).ToList();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void Update(BO.Sale item)
    {
        try
        {
            if (item == null || item.Code == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            _dal.Sale.Update(item.CastSaleToDO());
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }
}
