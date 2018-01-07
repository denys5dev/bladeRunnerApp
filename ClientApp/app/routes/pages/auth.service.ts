import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class AuthService {
    
    constructor(private http: Http) {
        
    }

    registerUser(body: any) {
        return this.http.post('/api/users', body).map(res => res.json());
    }

    isLoggedIn() {
        return localStorage.getItem('user') !== null;
    }

    logout() {
        localStorage.clear();
    }
}