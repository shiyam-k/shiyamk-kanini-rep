import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';


@Component({
  selector: 'app-students-a',
  templateUrl: './students-a.component.html',
  styleUrls: ['./students-a.component.css']
})
export class StudentsAComponent implements OnInit {
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
