import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClickRenderComponent } from './click-render.component';

describe('ClickRenderComponent', () => {
  let component: ClickRenderComponent;
  let fixture: ComponentFixture<ClickRenderComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ClickRenderComponent]
    });
    fixture = TestBed.createComponent(ClickRenderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
