import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserData } from '../models/UserData';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginUserData:UserData= new UserData();
  constructor(private _auth:AuthService,private _route:Router) { }

  ngOnInit(): void {
  }
  loginUser(){
   this._auth.loginUser(this.loginUserData).subscribe(res=>{localStorage.setItem('token',res.token);
   if (res.isAdmin)
   this._route.navigate(['dashboard'])
   else
   this._route.navigate(['/account']);
  }, err => console.log(err));
  }

}
