import { Component } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent {
  addNumbers(a: number, b: number): number {
    return a + b;
  }
  
  name : string ="shiyamk"
}
