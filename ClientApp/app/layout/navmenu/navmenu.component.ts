import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { AuthService } from '../../routes/pages/auth.service';

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html',
    styleUrls: ['./navmenu.component.css']
})
export class NavMenuComponent {

    constructor(private _router: Router, private _authService: AuthService) {
        
    }
    login() {
        this._router.navigate(['/login']);
    }
    register() {
        this._router.navigate(['/register']);   
    }
}
