namespace CarStore
{
    public interface IStore
    {
        string StoreName { get; set; }
        StoreCitys City { get; set; }

        void EnterStore(IPerson person);
        Order Buy(string CarModel, IPerson person);
        void CancelOrder(Order order);

    }
}
