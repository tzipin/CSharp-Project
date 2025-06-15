namespace BO;

public class Product
{
    public int Barcode { get; init; }
    public string? Name { get; init; }
    public category? Category { get; init; }
    public double? Price { get; init; }
    public int? Amount { get; init; }
    public List<SaleInProduct>? Sales { get; init; }

    public Product(int barcode, string? name, category? category, double? price, int? amount)
    {
        this.Barcode = barcode;
        this.Name = name;
        this.Category = category;
        this.Price = price;
        this.Amount = amount;
    }

    public override string ToString() => this.ToStringProperty();
}
