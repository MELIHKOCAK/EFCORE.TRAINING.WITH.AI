namespace EFCORE.TRAINING.WITH.AI.EFCORE.Entity;

public class Library
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AddressId { get; set; }

    //Navigation Property
    public Address Address { get; set; }

    public ICollection<Book> Books { get; set; }
}

