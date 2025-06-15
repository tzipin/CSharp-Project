using BlApi;
using BO;
using DO;
using static BO.Tools;

namespace BlImplementation;

internal class OrderImplementation : BlApi.IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int quantity)
    {
        try
        {
            if (order == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            DO.Product p = _dal.Product.Read(id);
            BO.ProductInOrder product = order.Products?.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                
                if (p.amount >= quantity + product.Amount)
                    product.Amount = quantity + product.Amount;
                else
                    throw new BlOutOfStock("There are not enough in stock");
            }
            else
            {
                product = p.CastProductToProductInOrder();
                product.Amount = quantity;
                if (p.amount >= quantity)
                    order.Products?.Add(product);
                else
                    throw new BlOutOfStock("There are not enough in stock");
            }
            SearchSaleForProduct(product, order.IsClub);
            List<BO.SaleInProduct> salse = CalcTotalPriceForProduct(product);
            CalcTotalPrice(order);
            return salse;
        }
        catch (DalIdNoFound e)
        {
            throw new BlIdNoFound(e.Message, e);
        }
    }
    
    public void CalcTotalPrice(BO.Order order)
    {
        try
        {
            order.FinalyPrice = order.Products?.Sum(p => p.FinalyPrice);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<BO.SaleInProduct> CalcTotalPriceForProduct(BO.ProductInOrder product)
    {
        try
        {
            if (product == null || product.Id == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            int? count = product.Amount;
            List<BO.SaleInProduct> sales = new List<BO.SaleInProduct>();
            foreach (var sale in product.Sales)
            {
                if (sale.Amount <= count)
                {
                    product.FinalyPrice += count / sale.Amount * sale.Price;
                    count = count % sale.Amount;
                    sales.Add(sale);
                }
                else
                    throw new BlOutOfStock("There are not enough in stock");
            }
            if (count > 0)
            {
                product.FinalyPrice = product.BasicPrice * count;
            }
            else if (count < 0)
            {                
                throw new BlNegativeQuantity("אי אפשר לקנות כמות שלילית");                
            }
            else
            {
                product.FinalyPrice = 0;
                
            }
            return sales;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void DoOrder(BO.Order order)
    {
        try
        {
            if (order == null)
                throw new BlInvalidInput("ERROR! \t invalid input");
            foreach (var product in order.Products)
            {
                DO.Product p = _dal.Product.Read(product.Id);
                int quantity = (int)(p.amount - product.Amount);
                DO.Product updateProduct = new() { barcode = p.barcode, name = p.name, category = p.category, price = p.price, amount = quantity };
                _dal.Product.Update(updateProduct);
            }
        }
        catch (DO.DalIdExists e)
        {
            throw new BlIdExists(e.Message, e);
        }
    }

    public void SearchSaleForProduct(BO.ProductInOrder product, bool? isClub)
    {
        try
        {
            List<DO.Sale>p = _dal.Sale.ReadAll();
            product.Sales = (from sale in _dal.Sale.ReadAll()
                             where sale.barcode == product.Id &&
                             sale.startDate <= DateTime.Now && sale.endDate >= DateTime.Now &&
                             (sale.isClub == false || sale.isClub == isClub) &&
                             sale.amount <= product.Amount
                             orderby sale.price / sale.amount
                             select sale.CastSaleToSaleInProduct()).ToList();
            foreach (var item in product.Sales)
            {
                item.ToString();
            }
        }
        
        catch (Exception e)
        {
            throw e;
        }
    }
} 

