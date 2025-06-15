namespace BlImplementation;

internal class Bl : BlApi.IBl
{
    public BlApi.IProduct Product => new ProductImplementation();

    public BlApi.ICustomer Customer => new CustomerImplementation();

    public BlApi.ISale sale => new SaleImplementation();

    public BlApi.IOrder Order => new OrderImplementation();
}
