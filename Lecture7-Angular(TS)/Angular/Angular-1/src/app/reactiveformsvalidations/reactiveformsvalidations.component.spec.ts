import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReactiveformsvalidationsComponent } from './reactiveformsvalidations.component';

describe('ReactiveformsvalidationsComponent', () => {
  let component: ReactiveformsvalidationsComponent;
  let fixture: ComponentFixture<ReactiveformsvalidationsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ReactiveformsvalidationsComponent]
    });
    fixture = TestBed.createComponent(ReactiveformsvalidationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
