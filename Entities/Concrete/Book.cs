namespace Entities.Concrete;

public class Book : BaseEntity
{
    public string BookName { get; set; }
    public int PageCount { get; set; }
    public int Scor { get; set; }
    public int AuthorId { get; set; }
    public int OperationId { get; set; }
    public int TypeId { get; set; }
    
    
}