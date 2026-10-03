import { Component, inject, input, output, signal } from '@angular/core';
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

  openDialog(isApprove : boolean): void {
    this.showDialog.set(true);
    this.approve.set(isApprove);
  }
  closeDialog(): void {
    this.showDialog.set(false);
  }
}
