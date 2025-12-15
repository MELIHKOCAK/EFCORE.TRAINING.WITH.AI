namespace EFCORE.TRAINING.WITH.AI.EFCORE.Entity;

public class Book
{
    public int Id { get; set; }
    public Guid ISBN { get; set; }
    public string Name { get; set; }
    public short PageCount { get; set; }
    public DateOnly PublishedDate { get; set; }


    //Navigation Property
    public ICollection<Deposit> Deposit { get; set; }
    public ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    public ICollection<Author> Author { get; set; } 
    public ICollection<Library> Libraries { get; set; }
}

