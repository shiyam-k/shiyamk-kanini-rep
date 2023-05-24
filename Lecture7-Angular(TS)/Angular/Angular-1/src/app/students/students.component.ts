import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';


@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {
  sDepartment : string = 'CSE'
  sGrade : string = 'A';
  Students : any[] = []
  Grades : any[] = []
  Departments : any[] = []
  constructor(private _studentServices : StudentService){  
  }
  ngOnInit(): void {
    this._studentServices.GetStudent().subscribe(data => this.Students = data)
    this._studentServices.GetGrades().subscribe(data => this.Grades = data)
    this._studentServices.GetDepartment().subscribe(data => this.Departments = data)
    
  }
  
}
