import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentsAComponent } from './students-a.component';

describe('StudentsAComponent', () => {
  let component: StudentsAComponent;
  let fixture: ComponentFixture<StudentsAComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [StudentsAComponent]
    });
    fixture = TestBed.createComponent(StudentsAComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
