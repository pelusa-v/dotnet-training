namespace use_case_1;

public class PurchaseProcess
{
    public int Id { get; set; } = default;
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public decimal Ammount { get; set; } = default;
    public DateTime TimeStamp { get; set; } = DateTime.Now;
    public bool Error { get; set; } = false;
}
