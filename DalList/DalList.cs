using DalApi;

namespace Dal;

internal sealed class DalList:IDal
{
    public static readonly DalList instance = new DalList();
    public static DalList Instance { get { return instance; } }
    public ICustomer Customer => new CustomerImplementation();
    public ISale Sale => new SaleImplementation();
    public IProduct Product => new ProductImplementation();

    private DalList()
    {

    }
}
