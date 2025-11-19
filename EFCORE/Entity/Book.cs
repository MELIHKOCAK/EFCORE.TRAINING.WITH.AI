namespace EFCORE.TRAINING.WITH.AI.EFCORE.Entity;

public class Book
{
    public int Id { get; set; }
    public Guid ISBN { get; set; }
    public string Name { get; set; }
    public short PageCount { get; set; }
    public DateTime PublishedDate { get; set; }
}

