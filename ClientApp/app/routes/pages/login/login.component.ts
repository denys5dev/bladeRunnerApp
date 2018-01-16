import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    selector: 'login-app',
    templateUrl: 'login.component.html',
    styleUrls: ['./login.component.scss']
})

export class LoginComponent implements OnInit {
    loginForm: FormGroup;

    constructor(private _fb: FormBuilder) { }

    ngOnInit() { 
        this.loginForm = this._fb.group({
            email: [null, Validators.required],
            password: [null, Validators.required]
        });
    }
}