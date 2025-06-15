using BO;
using DO;
using static BO.Tools;
namespace BlImplementation;

internal class ProductImplementation : BlApi.IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<BO.SaleInProduct> AllCurrentSales(int id, bool IsClubCustomer)
    {
        try
        {
           return _dal.Sale.ReadAll(s => s.barcode == id && s.startDate<=DateTime.Now && s.endDate>=DateTime.Now &&( s.isClub==false ||s.isClub==IsClubCustomer)).Select(s => s.CastSaleToSaleInProduct()).ToList();
        }
        catch (Exception e) 
        {
            throw e;
        }
    }

    public int Create(BO.Product item)
    {
        if (item == null || item.Barcode == null)
            throw new BlInvalidInput("ERROR! \t invalid input");
        return _dal.Product.Create(item.CastProductToDO());
    }

    public void Delete(int id)
    {
        try
        {
            if (id == 0 || id == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            _dal.Product.Delete(id);
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public BO.Product? Read(int id)
    {
        try
        {
            return _dal.Product.Read(id).CastProductToBO();
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try
        {
            return _dal.Product.Read(p => filter(p.CastProductToBO())).CastProductToBO();
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }

    public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Product.ReadAll().Select(p => p.CastProductToBO()).ToList();
            return _dal.Product.ReadAll(p => filter(p.CastProductToBO())).Select(p => p.CastProductToBO()).ToList();
        }
        catch (Exception e)
        {
           throw new BlIdNoFound("לא נמצאו פריטים תואמים");
        }
        
    }

    public void Update(BO.Product item)
    {
        try
        {
            if (item == null || item.Barcode == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            _dal.Product.Update(item.CastProductToDO());
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }
}
