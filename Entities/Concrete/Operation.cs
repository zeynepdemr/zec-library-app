namespace Entities.Concrete;

public class Operation : BaseEntity
{
    public DateTime ReceivingDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    
    public int BookId { get; set; }
    public int StudentId { get; set; }
}