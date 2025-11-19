namespace EFCORE.TRAINING.WITH.AI.EFCORE.Entity;

public class Deposit
{
    public int Id { get; set; }
    public DateOnly DeliveryDate { get; set; }
    public DateOnly DepositDate { get; set; }

    //Foreign Key
    public int UserId { get; set; }

    //Navigation Property
    public User User { get; set; }

    public ICollection<Book> Books { get; set; }
}

