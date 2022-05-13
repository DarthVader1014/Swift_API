import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { filter } from 'rxjs/operators';

import { Alert, AlertType } from '../_models/alert';


@Injectable({
  providedIn: 'root'
})
export class AlertService {
  private subject = new Subject<Alert>();
  private Id = 'default-alert'

  //Subcribinng to alert observables
  onAlert (id = this.Id): Observable<Alert> {
    return this.subject.asObservable().pipe(filter(x => x && x.id == id));
  }

  //AlertType methods
  success(message: string, options?: any) {
    this.alert(new Alert({...options, type: AlertType.Success, message}))
  }

  error(message: string, options?: any) {
    this.alert(new Alert({...options, type: AlertType.Error, message}))
  }

  info(message: string, options?: any) {
    this.alert(new Alert({...options, type: AlertType.Info, message}))
  }

  warn(message: string, options?: any) {
    this.alert(new Alert({...options, type: AlertType.Warning, message}))
  }



  //Alert method
  alert(alert: Alert){
    alert.id = alert.id || this.Id;
    this.subject.next(alert)
  }

  //Clear all alerts
  clear(id = this.Id) {
    this.subject.next(new Alert ({id}));

  }


}
