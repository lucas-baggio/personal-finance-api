using PersonalFinance.Domain.Common;

namespace PersonalFinance.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string ColorHex { get; set; } = "#FFFFFF";
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}