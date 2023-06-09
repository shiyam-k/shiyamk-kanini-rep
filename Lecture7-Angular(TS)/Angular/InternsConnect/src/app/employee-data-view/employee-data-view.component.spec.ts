import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeDataViewComponent } from './employee-data-view.component';

describe('EmployeeDataViewComponent', () => {
  let component: EmployeeDataViewComponent;
  let fixture: ComponentFixture<EmployeeDataViewComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EmployeeDataViewComponent]
    });
    fixture = TestBed.createComponent(EmployeeDataViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
