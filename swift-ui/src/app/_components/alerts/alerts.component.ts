import { Input } from '@angular/core';
import { OnDestroy } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Router, NavigationStart } from '@angular/router';
import { Subscription } from 'rxjs';

import { Alert, AlertType } from 'src/app/_models/alert';
import { AlertService } from 'src/app/_services/alert.service';


@Component({selector: 'alerts', templateUrl: './alerts.component.html',})


export class AlertsComponent implements OnInit, OnDestroy {
  @Input() id = 'default-alert';
  @Input() fade = true;

  alerts: Alert[] = [];
  alertSubcription: Subscription;
  routeSubscription: Subscription;


  constructor( private router: Router, private alertService: AlertService) { }

  ngOnInit(){
    //Subscription to newly generated subscriptions
    this.alertSubcription = this.alertService.onAlert(this.id)
        .subscribe(alert => {

          if(!alert.message) {
            this.alerts = this.alerts.filter(x => x.keepAfterRouteChange);


            this.alerts.forEach( x => delete x.keepAfterRouteChange);
            return;
          }

          //Alerts are added to an array
          this.alerts.push(alert);

          //Autoclose
          if(alert.autoClose){
            setTimeout(() => this.removeAlert(alert), 3000);
          }
        });

        //Clear all alerts when switch to a different route
        this.routeSubscription = this.router.events.subscribe(event =>{
          if (event instanceof NavigationStart) {
            this.alertService.clear(this.id);
          }
        });
      }

      ngOnDestroy() {
        //Unsubscribe
        this.alertSubcription.unsubscribe();
        this.alertSubcription.unsubscribe();
      }

      removeAlert(alert: Alert) {
        //A check to see if all alerts are removed properly
        if (!this.alerts.includes(alert)) return;

        if (this.fade) {
          //fade out alert
          alert.fade = true;

          //Remove alert after fade effect
          setTimeout(() => {
            this.alerts = this.alerts.filter( x => x !== alert);
          }, 250);
          }else {
            this.alerts = this.alerts.filter(x => x !==alert);
          }
        }

        cssClass(alert: Alert) {

          if (!alert) return;

          const classes = ['alert', 'alert-dismissable', 'mt-4', 'container'];

          const alertTypeClass = {
            [AlertType.Success]: 'a alert success',
            [AlertType.Error]: 'a alert danger',
            [AlertType.Info]: 'a alert info',
            [AlertType.Warning]: 'a alert warning'
          }
          classes.push(alertTypeClass[alert.type]);

          if (alert.fade) {
            classes.push('fade');
          }
          return classes.join(' ');
        }
      }

