import { Component, inject, input, output, signal } from '@angular/core';
import { Approval } from '../../../types/Approval';
import { approvalService } from '../../../apiService/approvalService';
import { ApprovalRequest } from '../../../types/ApprovalRequest';
import { FormsModule } from '@angular/forms';

@Component({
  imports: [FormsModule],
  selector: 'app-approval-dialog',
  styleUrl: './approval-dialog.css',
  templateUrl: './approval-dialog.html',
})
export class ApprovalDialog {
  readonly service = inject(approvalService);
  visible = input(false);

  closed = output<void>();

  selectedApproval = input<Approval[]>([]);
  approve = input(false);
  reason = signal('');
  isSubmitting = signal(false);
  onSuccessAction = output<number>();
  onFailureAction = output<void>();
  close(): void {
    this.closed.emit();
  }
  submit() {
    const request: ApprovalRequest = {
      approvalIds: this.selectedApproval().map((app) => app.id),
      isApproved: this.approve(),
      approveReason: this.reason(),
    };
    this.isSubmitting.set(true);
    this.service.ApproveRequest(request).subscribe({
      next: (res) => {
this.isSubmitting.set(false);
this.reason.set('');
        this.onSuccessAction.emit(res);
      },
      error: (error) => {
        console.error(error);
        this.isSubmitting.set(false);
        this.reason.set('');
        this.onFailureAction.emit();
      },
    });
  }
}
