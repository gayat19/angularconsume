import { Component, OnInit } from '@angular/core';
import { Customer } from '../models/customer.model';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-add-customer',
  templateUrl: './add-customer.component.html',
  styleUrls: ['./add-customer.component.css']
})
export class AddCustomerComponent implements OnInit {
customer:Customer;
  constructor(private customerService:CustomerService) { 
    this.customer = new Customer();
  }
addCustomer(){
 var len = this.customer.pic?.length;
  len = len?len-16:0;
  this.customer.pic = "/assets/images/"+this.customer.pic?.substring(17,len);
    this.customerService.createCustomer(this.customer).subscribe(data=>{
      var cust = data as Customer;
      if(!cust)
        alert("Customer not added");
      else
        alert("Custoemr added successfully");
    })
}
getFile(fname:any){
  this.customer.pic=fname.filename;
}
  ngOnInit(): void {
  }

}
