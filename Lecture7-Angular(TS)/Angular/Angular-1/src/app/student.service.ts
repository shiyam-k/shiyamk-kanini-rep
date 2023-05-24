import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  Grades : string[] = ['A', 'B', 'C', 'D', 'E', 'F']
  Departments :string[] = ['CSE', 'IT']
   

students:any[] = [
    {
      Name : "Student1",
      Department: "CSE",
      Grade : "A",
    },
    {
      Name : "Student2",
      Department: "CSE",
      Grade : "B"
    },
    {
      Name : "Student3",
      Department: "IT",
      Grade : "C"
    },
    {
      Name : "Student44",
      Department: "IT",
      Grade : "A"
    },
    {
      Name : "Student5",
      Department: "CSE",
      Grade : "A"
    },
    {
      Name : "Student6",
      Department: "IT",
      Grade : "C"
    },
    {
      Name : "Student7",
      Department: "IT",
      Grade : "F"
    }
  ] 
  GetStudent(){
    return this.students
  }
  GetGrades(){
    return this.Grades
  }
  GetDepartment(){
    return this.Departments
  }
  constructor() { }
}
