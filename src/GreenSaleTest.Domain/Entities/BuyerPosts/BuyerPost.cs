using GreenSaleTest.Domain.Enums.BuyerPosts;

namespace GreenSaleTest.Domain.Entities.BuyerPosts;

public class BuyerPost : Auditable
{
    public long UserId { get; set; }
    public long CategoryID { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Capacity { get; set; }
    public string CapacityMeasure { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public BuyerPostEnum Status { get; set; }
}
