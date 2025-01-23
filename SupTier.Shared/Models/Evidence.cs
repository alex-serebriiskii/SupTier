using MessagePack;

namespace SupTier.Shared.Models;
[MessagePackObject]
public class Evidence
{
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public int SupplementApplicationId { get; set; }
    [Key(2)]
    public string Link { get; set; }
}