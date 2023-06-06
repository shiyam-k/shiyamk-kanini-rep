import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InternNavbarLoginComponent } from './intern-navbar-login.component';

describe('InternNavbarLoginComponent', () => {
  let component: InternNavbarLoginComponent;
  let fixture: ComponentFixture<InternNavbarLoginComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [InternNavbarLoginComponent]
    });
    fixture = TestBed.createComponent(InternNavbarLoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
