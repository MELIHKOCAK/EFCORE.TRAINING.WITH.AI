namespace EFCORE.TRAINING.WITH.AI.EFCORE.Entity;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public char Gender { get; set; }
    public string Mail { get; set; }
    public string PhoneNumber { get; set; }

    //Foreign Key
    public int AddressId { get; set; }

    //Navigation Property
    public Address Address { get; set; }
    public ICollection<Deposit> Deposits { get; set; }


}

