import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InternNavbarComponent } from './intern-navbar.component';

describe('InternNavbarComponent', () => {
  let component: InternNavbarComponent;
  let fixture: ComponentFixture<InternNavbarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [InternNavbarComponent]
    });
    fixture = TestBed.createComponent(InternNavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
