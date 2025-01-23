using MessagePack;

namespace SupTier.Shared.Models;

[MessagePackObject]
public class Supplement
{
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public string Name { get; set; }
}