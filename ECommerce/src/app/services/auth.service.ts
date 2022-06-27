import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable()
export class AuthService {
  private _registerUrl = "https://localhost:44304//api/Login/register";
  private _loginurl = "https://localhost:44304//api/Login/login";

  constructor(private http: HttpClient,private _router:Router) { }

  registerUser(user: any) {
    return this.http.post<any>(this._registerUrl, user);
  }
  loginUser(user: any) {
    return this.http.post<any>(this._loginurl, user);
  }
  loggedIn(){
    return !localStorage.getItem('token')
  }
  logoutUser(){
    localStorage.removeItem('token');
    this._router.navigate(['/home']);
  }
}
