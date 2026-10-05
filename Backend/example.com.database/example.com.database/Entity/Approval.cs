using System.ComponentModel.DataAnnotations;

namespace example.com.database.Entity;

public class Approval
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsPending { get; set; }
    public string ApproveStatus { get; set; }
    public DateTime? ApproveDate { get; set; }
    public string ApproveBy { get; set; }
    public string Reason { get; set; }
    public string? ApproveReason { get; set; }
    public DateTime RequestDate { get; set; }
    public string RequestBy { get; set; }
}