namespace BO;

public class SaleInProduct
{
    public int Id { get; init; }
    public int? Amount { get; init; }
    public double? Price { get; init; }
    public bool? IsForAll { get; init; }
    public SaleInProduct(int id, int? amount, double? price, bool? isForAll)
    {
        this.Id = id;
        this.Amount = amount;
        this.Price = price;
        this.IsForAll = isForAll;
    }

    public override string ToString() => this.ToStringProperty();
}
