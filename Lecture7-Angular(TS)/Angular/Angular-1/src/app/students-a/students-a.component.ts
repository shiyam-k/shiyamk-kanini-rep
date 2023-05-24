import { Component } from '@angular/core';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-students-a',
  templateUrl: './students-a.component.html',
  styleUrls: ['./students-a.component.css']
})
export class StudentsAComponent {
  sDepartment : string = 'CSE'
  sGrade : string = 'A';
  constructor(private _studentServices : StudentService){

  }
  Students : any[] = this._studentServices.GetStudent()
  Departments : string[] = this._studentServices.GetDepartment();
  Grades : string[] = this._studentServices.GetGrades();

}
