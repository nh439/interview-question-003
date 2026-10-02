export interface Approval {
  id: number;
  name: string;
  isPending: boolean;
  approveStatus: string;
  approveDate: Date | null;
  approveBy: string;
  reason: string;
  approveReason: string | null;
  requestDate: Date;
  requestBy: string;
}
