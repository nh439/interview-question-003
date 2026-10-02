import { ChangeDetectionStrategy, Component, inject, signal } from '@angular/core';
import { approvalService } from '../../apiService/approvalService';
import { PagedItem } from '../../types/PagedItem';
import { Approval } from '../../types/Approval';

@Component({
  imports: [],
  selector: 'app-home',
  styleUrl: './home.css',
  templateUrl: './home.html'
})
export class Home {
  readonly approvalService = inject(approvalService);
  loading= signal(true);
  approvals = signal<PagedItem<Approval> | undefined> ( undefined);
  ngOnInit(): void {
    this.loading.set(true);
    this.approvalService.ListApproval().subscribe({
      next: (data) => {
        this.approvals.set(  data);
        this.loading.set(  false);

        console.log('loading:', this.loading);
        console.log('approvals:', this.approvals);
        },
      error: (error) =>{
        console.error(error);
        this.loading.set(  false);
        },
    });
  }
}
