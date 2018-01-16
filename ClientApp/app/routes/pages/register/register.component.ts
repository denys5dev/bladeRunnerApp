import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../../core/auth.service';

@Component({
    selector: 'registration-app',
    templateUrl: 'register.component.html',
    styleUrls: ['./register.component.scss']
})

export class RegisterComponent implements OnInit {

    registerForm: FormGroup;

    constructor(private _fb: FormBuilder, private _authService: AuthService, private _router: Router) {
      
    }

    ngOnInit() { 
        this.registerForm = this._fb.group({
            contact: this._fb.group({
                name: ['', [Validators.minLength(2), Validators.required]],
                lastName: ['', [Validators.minLength(2), Validators.required]],
                email: ['', [Validators.email, Validators.required]],
                phone: ['', [Validators.minLength(4), Validators.required]],
            }),
            password: ['', [Validators.minLength(6), Validators.required]],
            confimPassword: ['', [Validators.required, this.passwordConfirming]]
        });
    }

    onSubmitRegisterForm(form: any) {
        this._authService.registerUser(form.value).subscribe(user => {
            this._router.navigate(['/home']);
        }, (error) => {
            alert(error);
        });
    }

    passwordConfirming(c: AbstractControl): any {
        if (!c.parent || !c) return;
        const pwd = c.parent.get('password');
        const cpwd = c.parent.get('confimPassword');

        if (!pwd || !cpwd) return;
        if (pwd.value !== cpwd.value) {
            return { invalid: true };

        }
    }
}