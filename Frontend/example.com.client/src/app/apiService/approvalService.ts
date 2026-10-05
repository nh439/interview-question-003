import { inject, Service } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PagedItem } from '../types/PagedItem';
import { Approval } from '../types/Approval';
import { ApprovalRequest } from '../types/ApprovalRequest';
import { ConfigurationService } from '../configuration/configurationService';

@Service()
export class approvalService {
  private readonly http = inject(HttpClient);
  readonly config = inject(ConfigurationService);
  private readonly url = this.config.settings.api;

  ListApproval(search :string | undefined = undefined, page: number =1,pageSize :number = 10){
    return this.http.get<PagedItem<Approval>>(`${this.url}/approval?search=${search ?? ''}&page=${page}&pageSize=${pageSize}`);
  }

  ApproveRequest(request : ApprovalRequest) {
    return this.http.patch<number>(`${this.url}/approval/approve`, request);
  }

}
