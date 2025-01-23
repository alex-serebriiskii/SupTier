using MessagePack;
namespace SupTier.Shared.Models;

 [MessagePackObject]
 public class Tier
{
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public string Description { get; set; }
}