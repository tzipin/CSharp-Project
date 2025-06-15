namespace BO;

public class Customer
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Address { get; init; }
    public string? Number_phone { get; init; }

    public Customer(int id, string? name, string? address, string? number_phone)
    {
        this.Id = id;
        this.Name = name;
        this.Address = address;
        this.Number_phone = number_phone;
    }

    public override string ToString() => this.ToStringProperty();
}
