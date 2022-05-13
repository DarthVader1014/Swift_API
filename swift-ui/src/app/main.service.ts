import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';


@Injectable()
export class MyMainService {

  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getProducts() {
    return this.http.get(`${this.baseUrl}/api/Product`)
    .pipe(map((response: any) =>
      response
    ));
  }
}
