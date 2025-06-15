namespace BO;

public class ProductInOrder
{
    public int Id { get; init; }
    public string? Name { get; set; }
    public double? BasicPrice { get; set; }
    public int? Amount { get; set; }
    public List<SaleInProduct>? Sales { get; set; }
    public double? FinalyPrice { get; set; }

    public ProductInOrder(int id, string? name, double? basicPrice, int? amount, List<SaleInProduct>? sales, double? FinalyPrice)
    {
        this.Id = id;
        this.Name = name;
        this.BasicPrice = basicPrice;
        this.Amount = amount;
        this.Sales = sales;
        this.FinalyPrice = FinalyPrice;
    }

    public override string ToString() => this.ToStringProperty();
}


