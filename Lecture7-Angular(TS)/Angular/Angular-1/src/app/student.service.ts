import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Template } from './students';


@Injectable({
  providedIn: 'root'
})
export class StudentService  {
  private studentsURL = '/assets/data/students.json'
  private departmentsURL = '/assets/data/department.json'
  private gradeURL = '/assets/data/grade.json'

  
  constructor(private http : HttpClient) { }
  GetStudent(){
    return this.http.get<Template[]>(this.studentsURL)
  }
  GetGrades(){
    return this.http.get<Template[]>(this.gradeURL)

  }
  GetDepartment(){
    return this.http.get<Template[]>(this.departmentsURL)

  }


}
