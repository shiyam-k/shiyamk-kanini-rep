import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestComponent } from './test.component';

describe('TestComponent', () => {
  let component: TestComponent;
  let fixture: ComponentFixture<TestComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TestComponent]
    });
    fixture = TestBed.createComponent(TestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should add two numbers correctly', () => {
    const a = 2;
    const b = 3;
    const c = 5;

    const result = component.addNumbers(a, b);

    expect(result).toEqual(c);
    
  });


  it('name is Equal', () => {
    

    const result = component.name

    expect(result).toEqual("shiyamk");



    
  });
});
