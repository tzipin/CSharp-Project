using System.Reflection;
using System.Text;

namespace BO;

public static class Tools
{
    public static string ToStringProperty<T>(this T obj, string prefix = "")
    {
        StringBuilder sb = new StringBuilder();
        Type t = obj?.GetType() ?? throw new Exception("Obj is NULL");
        foreach (PropertyInfo prop in t.GetProperties())
        {
            if(prop.PropertyType.IsPointer == false)
                sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
            else
                sb.Append($"{prefix}{prop.Name} =\n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
        }
        return sb.ToString();
    }

    public static BO.Customer CastCustomerToBO(this DO.Customer customer)
    {
        return new BO.Customer(customer.id, customer.name, customer.address, customer.number_phone);
    }
    public static DO.Customer CastCustomerToDO(this BO.Customer customer)
    {
        return new DO.Customer(customer.Id, customer.Name, customer.Address, customer.Number_phone);
    }
    public static BO.Product CastProductToBO(this DO.Product product)
    {
        return new BO.Product(product.barcode, product.name, (BO.category)product.category, product.price, product.amount);
    }
    public static DO.Product CastProductToDO(this BO.Product product)
    {
        return new DO.Product(product.Barcode, product.Name, (DO.category)product.Category, product.Price, product.Amount);
    }
    public static BO.Sale CastSaleToBO(this DO.Sale sale)
    {
        return new BO.Sale(sale.code, sale.barcode, sale.amount, sale.price, sale.isClub, sale.startDate, sale.endDate);
    }
    public static DO.Sale CastSaleToDO(this BO.Sale sale)
    {
        return new DO.Sale(sale.Code, sale.Barcode, sale.Amount, sale.Price, sale.IsClub, sale.StartDate, sale.EndDate);
    }
    public static BO.SaleInProduct CastSaleToSaleInProduct(this DO.Sale sale)
    {
        BO.SaleInProduct s = new SaleInProduct(sale.code, sale.amount, sale.price, !sale.isClub);
        Console.WriteLine(s);
        return s;
    }
    public static BO.ProductInOrder CastProductToProductInOrder(this DO.Product product) => new(product.barcode, product.name, product.price, product.amount, new List<SaleInProduct>(), 0);

    public static BO.ProductInOrder CastBOProductToProductInOrder(this BO.Product product) => new(product.Barcode, product.Name, product.Price, product.Amount, new List<SaleInProduct>(), 0);

}
