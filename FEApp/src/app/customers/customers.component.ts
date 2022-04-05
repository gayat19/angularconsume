import { Component, OnInit } from '@angular/core';
import { Customer } from '../models/customer.model';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  customers:Customer[];
  constructor(private customerService:CustomerService) {
    this.customers =[];
    this.customerService.getCustomers().subscribe(data=>{
      this.customers = data as Customer[];
    })
   }

  ngOnInit(): void {
  }

}
