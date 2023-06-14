import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable, catchError, map, throwError } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class EmployeedataService {
  private GetURL : string = "https://localhost:7044/Employee/actions"
  private GetByIdURL : string = "https://localhost:7044/Employee/actions/id?id"
  //private PostURL : string = 
  constructor(private http : HttpClient) { }
  getEmployeeData(): Observable<any> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Cache-Control': 'no-cache',
        'Pragma': 'no-cache'
      }),
      observe: 'response' as 'body'
    };  
    return this.http.get<any>(this.GetURL, httpOptions).pipe(
      map((response: HttpResponse<any>) => response.body.employeeRequest),
      catchError(this.handleError)
    );
  }
  
  getEmployeeById(employeeId: string): Observable<any> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Cache-Control': 'no-cache',
        'Pragma': 'no-cache'
      }),
      observe: 'response' as 'body'
    };
    const url = `${this.GetByIdURL}=${employeeId}`;
    console.log(this.http.get<any>(url, httpOptions).pipe(
      map((response: HttpResponse<any>) => response.body.employeeRequest)))
    return this.http.get<any>(url, httpOptions).pipe(
      map((response: HttpResponse<any>) => response.body.employeeRequest),
      catchError(this.handleError));
  }

  createEmployee(employee: any): Observable<any> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Cache-Control': 'no-cache',
        'Pragma': 'no-cache'
      }),
      observe: 'response' as 'body'
    };
  
    return this.http.post<any>(this.GetURL, employee, httpOptions).pipe(
      map((response: HttpResponse<any>) => response.body),
      catchError(this.handleError)
    );
  }


  updateEmployee(employee : any, eId : string) : Observable<any> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Cache-Control': 'no-cache',
        'Pragma': 'no-cache'
      }),
      observe: 'response' as 'body'
    };
    const url = `${this.GetByIdURL}=${eId}`;
    return this.http.put<any>(url, employee).pipe(
      map((response: HttpResponse<any>) => response.body),
      catchError(this.handleError)
    );
  }

  deleteEmployee(employee : any, eId : string) : Observable<any>{
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Cache-Control': 'no-cache',
        'Pragma': 'no-cache'
      }),
      observe: 'response' as 'body'
    };
    const url = `${this.GetByIdURL}=${eId}`;
    console.log(url)
    return this.http.delete<any>(url, employee);
  }

  private extractData(response: any): any {
    return response.body;
  }

  private handleError(error: any): Observable<never> {
    console.error('An error occurred:', error);
    return throwError('Something went wrong. Please try again later.');
  }
}
