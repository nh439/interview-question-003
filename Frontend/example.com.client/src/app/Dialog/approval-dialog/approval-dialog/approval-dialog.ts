import { Component, Inject, input, output, signal } from '@angular/core';
import { Approval } from '../../../types/Approval';
import { approvalService } from '../../../apiService/approvalService';

@Component({
  imports: [],
  selector: 'app-approval-dialog',
  styleUrl: './approval-dialog.css',
  templateUrl: './approval-dialog.html',
})
export class ApprovalDialog {
  readonly service = Inject(approvalService);
  visible = input(false);

  closed = output<void>();

  approveRequest = signal<Approval[]>([]);
  approve = input(false);

  close(): void {
    this.closed.emit();
  }
}
