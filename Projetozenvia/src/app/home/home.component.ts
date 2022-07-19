import { CustomerService } from './../services/customer.service';
import { Component, OnInit } from '@angular/core';
import { CustomerSearch } from '../models/customerSearch.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  customers!: CustomerSearch;
  page: number = 0;
  name: string = '';

  constructor( private service: CustomerService) { }

  ngOnInit(): void {
    this.service.GetAll(this.page, this.name).subscribe((customers: CustomerSearch) => {
      this.customers = customers;
    });
  }

}
