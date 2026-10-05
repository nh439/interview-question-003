import { Component, input, output } from '@angular/core';
import { Approval } from '../../../types/Approval';
import { format } from 'date-fns';

@Component({
  imports: [],
  selector: 'app-detail-dialog',
  styleUrl: './detail-dialog.css',
  templateUrl: './detail-dialog.html',
})
export class DetailDialog {
  visible = input(false);
  closed = output<void>();
  approval = input<Approval| null>(null);

  close(){
    this.closed.emit();
  }

  formatDate(input : Date | null | undefined){
    if(input)
      return format(input,'dd MMMM yyyy HH:mm:ss');
    return '';
  }
}
