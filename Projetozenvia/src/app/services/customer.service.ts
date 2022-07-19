import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CustomerSearch } from '../models/customerSearch.model';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private httpClient: HttpClient) { }

  GetAll(page: number, name: string): Observable<CustomerSearch>{
    return this.httpClient.get<CustomerSearch>('http://localhost:5000/customer', {
      params: {
        ['page']: page,
        ['size']: 10,
        ['name']: name
      }
    });
  }
}
