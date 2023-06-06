import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators, FormGroup } from '@angular/forms';
import userNameValidator from '../shared/custom-validator-reactive';
import { multipleValidator } from '../shared/custom-validator-reactive';


@Component({
  selector: 'app-reactiveformsvalidations',
  templateUrl: './reactiveformsvalidations.component.html',
  styleUrls: ['./reactiveformsvalidations.component.css']
})
export class ReactiveformsvalidationsComponent {
  constructor(private formBuilder: FormBuilder) { }

  // registerForm = this.formBuilder.group({
  //   userName : ['mayihs'],
  //   password : [''],
  //   confirmPassword : [''],
  //   address : this.formBuilder.group({
  //     doorNo : [''],
  //     streetName : [''],
  //     city : ['']
  //   })
  // })

}
  
