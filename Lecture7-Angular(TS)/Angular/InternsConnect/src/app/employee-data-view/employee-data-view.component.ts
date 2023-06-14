import { Component, OnInit } from '@angular/core';
import { EmployeedataService } from '../employeedata.service';
import * as $ from 'jquery';
@Component({
  selector: 'app-employee-data-view',
  templateUrl: './employee-data-view.component.html',
  styleUrls: ['./employee-data-view.component.css']
})
export class EmployeeDataViewComponent implements OnInit {

  employees: any = {};
  constructor(private employeedataService: EmployeedataService) { }
  empId : string = ""
  ngOnInit(): void {
    this.loadEmployeeData();
  }

  loadEmployeeData(): void {
    this.employeedataService.getEmployeeData().subscribe(
      (data: any[]) => {
        this.employees = data;
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  newEmployee: any = {};
  updateEmployee : any = {};
  GetEmployeeById(eId: string): void {
    this.empId = eId;
    this.employeedataService.getEmployeeById(eId).subscribe(
      (data: any) => {
        this.updateEmployee = data;
        
        //document.querySelector("#update")?.classList.replace('fade', 'show');
        //console.log(this.updateEmployee); // Log the updated object
      },
      (error: any) => {
        console.error(error);
      }
    );
  }

  createEmployee(): void {
    this.employeedataService.createEmployee(this.newEmployee).subscribe(
      (data: any) => {
        console.log('Employee created successfully:', data);
        this.newEmployee = {};
      },
      (error: any) => {
        console.error('Error creating employee:', error);
      }
    );
  }

  putEmployee(eId : string): void {
    this.employeedataService.updateEmployee(this.updateEmployee,eId).subscribe(
      (data: any) => {
        console.log('Employee updated successfully:', data);
      },
      (error: any) => {
        console.error('Error updating employee:', error.message);
      }
    );
  }
  //deleteEmployee : any = {}
  removeEmployee(eId : string): void {
    this.employeedataService.deleteEmployee(this.updateEmployee,eId).subscribe(
      (data: any) => {
        console.log('Employee Deleted successfully:', data);
      },
      (error: any) => {
        console.error('Error updating employee:', error.message);
      }
    );
  }


}
