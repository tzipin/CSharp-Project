namespace BO;

public class Order
{
    public bool? IsClub { get; set; }
    public List<ProductInOrder>? Products { get; set; }
    public double? FinalyPrice { get; set; }

    public Order(bool? isClub, List<ProductInOrder>? products, double? finalyPrice)
    {
        this.IsClub = isClub;
        this.Products = products;
        this.FinalyPrice = finalyPrice;
    }

    public override string ToString() => this.ToStringProperty();
}
