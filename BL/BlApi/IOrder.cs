namespace BlApi;

public interface IOrder
{
    List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id,  int quantity);
    List<BO.SaleInProduct> CalcTotalPriceForProduct(BO.ProductInOrder product);
    void CalcTotalPrice(BO.Order order);
    void DoOrder(BO.Order order);
    void SearchSaleForProduct(BO.ProductInOrder product, bool? isClub);
}


