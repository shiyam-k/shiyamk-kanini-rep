import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeDataViewComponent } from './employee-data-view/employee-data-view.component';


const routes: Routes = [
  { path: 'employee-data-view', component: EmployeeDataViewComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
