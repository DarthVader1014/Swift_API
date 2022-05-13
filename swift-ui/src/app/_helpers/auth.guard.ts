import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, Router } from '@angular/router';


import { AccountService } from '../_services/account.service';

@Injectable({ providedIn: 'root'})

export class AuthGuard implements CanActivate {
  constructor(
    private router: Router,
    private accountService: AccountService
  ) {}


  canActivate( route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const user = this.accountService.userValue;
    if (user) {
      //We are checking if the user is authorized
      return true;
    }
    //If the user is not logged in redirect the user
    this.router.navigate(['/account/login'], {queryParams: {returnUrl: state.url}});
    return false;
  }


}
