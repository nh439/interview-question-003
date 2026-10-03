export interface ApprovalRequest {
  approvalIds: number[];
  isApproved: boolean;
  approveReason?: string | null;
}
