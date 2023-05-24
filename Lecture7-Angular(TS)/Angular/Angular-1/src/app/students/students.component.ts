import { Component } from '@angular/core';
import { StudentService } from '../student.service';


@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent {
  sDepartment : string = 'CSE'
  sGrade : string = 'A';
  constructor(private _studentServices : StudentService){

  }
  Students : any[] = this._studentServices.GetStudent()
  Departments : string[] = this._studentServices.GetDepartment();
  Grades : string[] = this._studentServices.GetGrades();
}
