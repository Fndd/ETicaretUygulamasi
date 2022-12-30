import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomersComponent } from './customers/customers.component';
import { OrdersModule } from './orders/orders.module';
import { CustomersModule } from './customers/customers.module';
import { ProductsModule } from './products/products.module';
import { DashboardModule } from './dashboard/dashboard.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    CustomersModule,
    OrdersModule,
    ProductsModule,
    DashboardModule,
    RouterModule
 ],
  exports: [ 
    CustomersModule,
    OrdersModule,
    ProductsModule,
    DashboardModule
  ]
})
export class ComponentsModule { }
