using MessagePack;

namespace SupTier.Shared.Models;

[MessagePackObject]
public class SupplementApplication
{
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public int SupplementId { get; set; }
    [Key(2)]
    public int ApplicationId { get; set; }
    [Key(3)]
    public int TierId { get; set; }
    [Key(4)]
    public string Info { get; set; }

    // Navigation properties
    [Key(5)]
    public virtual Supplement Supplement { get; set; }
    [Key(6)]
    public virtual Application Application { get; set; }
    [Key(7)]
    public virtual Tier Tier { get; set; }
    [Key(8)]
    public virtual ICollection<Evidence> EvidenceList { get; set; }
}