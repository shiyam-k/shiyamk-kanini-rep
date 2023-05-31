import { AbstractControl, Validators } from "@angular/forms";

export default function userNameValidator (control: AbstractControl): { [key: string]: any } | null {
  const banned = /ishant/.test(control.value);
  return banned ? { 'BannedUser': { value: control.value } } : null;
};

export function multipleValidator (control: AbstractControl): { [key: string]: any } | null {
  const value = control.value;
  
  if (Validators.required(control) && Validators.minLength(3)(control)) {
    return null; // All validations pass, return null
  } else {
    return { 'customValidation': true }; // At least one validation fails
  }
};

