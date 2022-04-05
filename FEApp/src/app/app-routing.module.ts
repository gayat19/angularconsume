import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCustomerComponent } from './add-customer/add-customer.component';
import { CustomersComponent } from './customers/customers.component';
import { DeleteCustomerComponent } from './delete-customer/delete-customer.component';

const routes: Routes = [
  {path:'view',component:CustomersComponent},
  {path:'add',component:AddCustomerComponent},
  {path:'delete',component:DeleteCustomerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
