import { Injectable, inject, Service } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PagedItem } from '../types/PagedItem';
import { Approval } from '../types/Approval';
import { ApprovalRequest } from '../types/ApprovalRequest';

@Service()
export class approvalService {
  private readonly http = inject(HttpClient);
  private readonly url = 'http://localhost:5254';

  ListApproval(search :string | undefined = undefined, page: number =1,pageSize :number = 10){
    return this.http.get<PagedItem<Approval>>(`${this.url}/approval?search=${search ?? ''}&page=${page}&pageSize=${pageSize}`);
  }
  ApproveRequest(request : ApprovalRequest) {
    return this.http.put<number>(`${this.url}/approve`, request);
  }

}
