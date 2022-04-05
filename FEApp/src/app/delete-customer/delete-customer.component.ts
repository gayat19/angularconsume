import { Component, OnInit } from '@angular/core';
import { Customer } from '../models/customer.model';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-delete-customer',
  templateUrl: './delete-customer.component.html',
  styleUrls: ['./delete-customer.component.css']
})
export class DeleteCustomerComponent implements OnInit {
customers:Customer[];
  constructor(private customerService:CustomerService) {
    this.customers=[];
    this.customerService.getCustomers().subscribe(data=>{
      this.customers = data as Customer[];
    })
   }
   deleteCust(custId:any){
    this.customerService.deleteCustomer(custId.value).subscribe(data=>{
      var cust = data as Customer;
      if(!cust)
        alert("Customer not deleted");
      else
        alert("Custoemr deleted successfully");
    })
   }
  ngOnInit(): void {
  }

}
