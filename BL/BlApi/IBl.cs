namespace BlApi
{
    public interface IBl
    {
        public IProduct Product { get; }
        public ICustomer Customer { get; }
        public ISale sale { get; }
        public IOrder Order { get; }
    }
}
