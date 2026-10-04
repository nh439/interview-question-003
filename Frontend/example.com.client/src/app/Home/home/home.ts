import { Component, inject, signal } from '@angular/core';
import { approvalService } from '../../apiService/approvalService';
import { PagedItem } from '../../types/PagedItem';
import { Approval } from '../../types/Approval';
import { FormsModule } from '@angular/forms';
import { ApprovalDialog } from '../../Dialog/approval-dialog/approval-dialog/approval-dialog';

@Component({
  imports: [FormsModule, ApprovalDialog],
  selector: 'app-home',
  styleUrl: './home.css',
  templateUrl: './home.html',
})
export class Home {
  readonly approvalService = inject(approvalService);
  loading = signal(true);
  approvals = signal<PagedItem<Approval> | undefined>(undefined);
  search = signal<string>('');
  currentPage = signal<number>(1);
  lastpage = signal(1);
  total = signal(1);
  showDialog = signal(false);
  approve = signal(true);
  selectedApproval = signal<Approval[]>([]);
  resultMessage = signal('');
  isSuccess = signal(true);
  processed = signal(false);


  ngOnInit(): void {

    this.loading.set(true);
    this.loadApprovals();
  }
  loadApprovals(): void {
    this.approvalService.ListApproval(this.search(), this.currentPage()).subscribe({
      next: (data) => {
        this.approvals.set(data);
        this.total.set(data.totalItems);
        this.lastpage.set(data.lastPage);
        this.loading.set(false);
      },
      error: (error) => {
        console.error(error);
        this.loading.set(false);
      },
    });
  }

  applySearch(): void {
    this.loading.set(true);
    this.currentPage.set(1);
    this.loadApprovals();
  }

  goToPage(page: number): void {
    this.currentPage.set(page);
    this.loading.set(true);
    this.loadApprovals();
  }

  getPaging() {
    const pageToDisplay: number[] = [];
    for (let i = -2; i <= 2; i++) {
      const destional: number = this.currentPage() + i;
      if (destional > 0 && destional <= this.lastpage()) pageToDisplay.push(destional);
    }
    return pageToDisplay;
  }

  openDialog(isApprove: boolean): void {
    this.showDialog.set(true);
    this.approve.set(isApprove);
  }
  closeDialog(): void {
    this.showDialog.set(false);
  }

  toggleApproval(item: Approval, checked: boolean): void {
    if (checked) {
      // ป้องกันข้อมูลซ้ำ
      this.selectedApproval.update((items) => {
        if (items.some((x) => x.id === item.id)) {
          return items;
        }

        return [...items, item];
      });
    } else {
      // เอา item ออกจาก selected
      this.selectedApproval.update((items) => items.filter((x) => x.id !== item.id));
    }
  }
  onSuccessAction(res: number) {
    this.resultMessage.set(`${this.approve() ? 'Approved' : 'Rejected'} ${res} Request Successful`);
    this.isSuccess.set(true);
    this.processed.set(true);
    this.showDialog.set(false);
    this.selectedApproval.set([]);
    this.loadApprovals();
  }
  onFailureAction() {
    this.resultMessage.set('Error While Submitting the approval');
    this.isSuccess.set(false);
    this.processed.set(true);
    this.showDialog.set(false);
    this.selectedApproval.set([]);
    this.loadApprovals();
  }
  closeAlert(): void {
    this.processed.set(false);
  }
}
