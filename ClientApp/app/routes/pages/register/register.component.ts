import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
    selector: 'registration-app',
    templateUrl: 'register.component.html',
    styleUrls: ['./register.component.scss']
})

export class RegisterComponent implements OnInit {
    
    registerForm: FormGroup;

    constructor(private _fb: FormBuilder) { 
        this.registerForm = this._fb.group({
            firstName: ['', [Validators.minLength(1), Validators.required]],
            lastName: ['', [Validators.minLength(1), Validators.required]],
            email: ['', [Validators.email, Validators.required]],
            password: ['', [Validators.minLength(6), Validators.required]],
            confimPassword: ['', [Validators.required]]
        });
    }

    ngOnInit() { }

    onSubmitRegisterForm(form: any) {
        console.log(form)
    }
}