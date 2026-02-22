namespace ITCS_3112_Lab_1_Checkout.Domain;

public class Borrower
{
    public string Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Borrower(string id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public override string ToString() => $"{Name} ({Email})";
}
