import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ApprovalDialog } from './approval-dialog';

describe('ApprovalDialog', () => {
  let component: ApprovalDialog;
  let fixture: ComponentFixture<ApprovalDialog>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ApprovalDialog],
    }).compileComponents();

    fixture = TestBed.createComponent(ApprovalDialog);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
