import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ProfileComponent } from '../profile/profile.component';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  
  loginUserName : string = ""
  loginPassword : string = ""
  res :string = ""
  constructor(private router: Router){
  }
  
  goToPage(){

    // if(this.loginPassword == "Qwe!@#123" && this.loginUserName == "shiyam"){
    //   this.router.navigate([`home`]);
    // }
    // else if(this.loginUserName !== "shiyam"){
    //   this.res = this.loginUserName
    // }
    // else if(this.loginPassword !== "Qwe!@#123"){
    //   this.res = "Incorrect Password"
    // }
    this.res = this.loginPassword
    
  }
}
