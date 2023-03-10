import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './admin/layout/layout.component';
import { ComponentsModule } from './ui/components/components.module';
import { HomeComponent } from './ui/components/home/home.component';

const routes: Routes = [
  {path:"admin", component:LayoutComponent, children:[
    {path:"",loadChildren: ()=> import("./admin/components/dashboard/dashboard.module").then(module =>module.DashboardModule)},
    {path:"customers",loadChildren: ()=> import("./admin/components/customers/customers.module").then(module =>module.CustomersModule)},
    {path:"products",loadChildren: ()=> import("./admin/components/products/products.module").then(module =>module.ProductsModule)},
    {path:"orders",loadChildren: ()=> import("./admin/components/orders/orders.module").then(module =>module.OrdersModule)}
  ]},
  {path:"", component:HomeComponent, children:[
    {path:"baskets",loadChildren: ()=> import("./ui/components/baskets/baskets.module").then(module =>module.BasketsModule)},
    {path:"products",loadChildren: ()=> import("./ui/components/products/products.module").then(module =>module.ProductsModule)},
    ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
