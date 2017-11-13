import { Router } from '@angular/router';
import { Component } from '@angular/core';

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html',
    styleUrls: ['./navmenu.component.css']
})
export class NavMenuComponent {

    constructor(private _router: Router) {
        
    }
    login() {
        this._router.navigate(['/login']);
    }
}
