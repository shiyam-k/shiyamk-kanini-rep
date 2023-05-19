import { Component } from '@angular/core';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { SelectSPipe } from './pipes/product.pipe';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Angular-1';
  students: any[] = [
    {
        ID: 'std1001', Name: 'Nivin MMMM',
        DOB: '12/8/1988', Gender: 'Male', CourseFee: 1234.56
    },
    {
        ID: 'std1002', Name: 'MMMM YYYY', 
        DOB: '10/14/1989', Gender: 'Male', CourseFee: 6666.00
    }
];
studentId: string = "";
searchStudents(): void {
  
}
}
