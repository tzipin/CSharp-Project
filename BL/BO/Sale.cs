namespace BO;

public class Sale
{
    public int Code { get; init; }
    public int Barcode { get; init; }
    public int? Amount { get; init; }
    public double? Price { get; init; }
    public bool? IsClub { get; init; }
    public DateTime? StartDate { get; init; }
    public DateTime? EndDate { get; init; }

    public Sale(int code, int barcode, int? amount, double? price, bool? isClub, DateTime? startDate, DateTime? endDate)
    {
        this.Code = code;
        this.Barcode = barcode;
        this.Amount = amount;
        this.Price = price;
        this.IsClub = isClub;
        this.StartDate = startDate;
        this.EndDate = endDate;
    }

    public override string ToString() => this.ToStringProperty();
}
