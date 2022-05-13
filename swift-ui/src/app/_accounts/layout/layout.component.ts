import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { AccountService } from 'src/app/_services/account.service';

@Component({ templateUrl: 'layout.component.html' })
export class LayoutComponent {
    constructor(
        private router: Router,
        private accountService: AccountService
    ) {
        //If user is already logged in redirect
        if (this.accountService.userValue) {
            this.router.navigate(['/']);
        }
    }
}
