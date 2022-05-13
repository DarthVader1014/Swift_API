import { Component, OnInit } from '@angular/core';

import { AccountService } from './_services/account.service';
import { User } from './_models/user';
import { MyMainService } from './main.service';
import { SharedService } from './shared.service';


@Component({ selector: 'app', templateUrl: 'app.component.html' })
export class AppComponent implements OnInit {
    [x: string]: any;
    user: User;

    constructor(
      private accountService: AccountService,
      )

      {this.accountService.user.subscribe(x => this.user = x);}

    logout() {
        this.accountService.logout()}

    ngOnInit() {

    }
  }

