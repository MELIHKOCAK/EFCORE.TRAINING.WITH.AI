namespace EFCORE.TRAINING.WITH.AI.EFCORE.Entity;

public class Address
{
    public int ID { get; set; }
    public string City { get; set; }
    public string Quarter { get; set; }
    public string Country { get; set; }
    public string Street { get; set; }
    public string BuildingNo { get; set; }
    public string ZipCode { get; set; }



    //Navigation Properties
    public Library Library { get; set; }
    public ICollection<User> Users { get; set; }
}

