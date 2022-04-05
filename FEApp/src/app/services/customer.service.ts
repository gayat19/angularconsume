import {HttpClient} from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Customer } from '../models/customer.model';

@Injectable()
export class CustomerService{


    constructor(private httpClient:HttpClient) {

    }
    public getCustomers(){
        return this.httpClient.get("http://sampleconsumeapp.azurewebsites.net/api/Customer");
    }
    public getCustomerById(id:number){
        return this.httpClient.get("http://sampleconsumeapp.azurewebsites.net/GetCustomerById/"+id);
    }
    public createCustomer(customer:Customer){
        return this.httpClient.post("http://sampleconsumeapp.azurewebsites.net/api/Customer",customer);
    }
    public deleteCustomer(id:number){
        return this.httpClient.delete("http://sampleconsumeapp.azurewebsites.net/api/Customer/?id="+id);
    }
}