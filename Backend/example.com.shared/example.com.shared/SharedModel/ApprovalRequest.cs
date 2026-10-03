namespace example.com.shared.SharedModel;

public class ApprovalRequest
{
    public long[] ApprovalIds { get; set; }
    public bool IsApproved { get; set; }
    public string? ApproveReason  { get; set; }
}