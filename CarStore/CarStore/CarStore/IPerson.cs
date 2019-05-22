namespace CarStore
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Adress { get; set; }

        string FullName();
    }
}
