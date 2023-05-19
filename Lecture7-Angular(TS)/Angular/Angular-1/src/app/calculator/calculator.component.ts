import { Component } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
    n1 : number = 0;
    n2 : number = 0;
    res : number = 0
    Add(){
      this.res = this.n1 + this.n2
    }
    Sub(){
      this.res = this.n1 - this.n2
    }
    Mul(){
      this.res = this.n1 * this.n2
    }
    Div(){
      this.res = this.n1 / this.n2
    }
}
