import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { OrdersComponent } from './orders/orders.component';
import { OrderComponent } from './orders/order/order.component';
import { CustomerComponent } from './shared/customer/customer.component';
import { ItemComponent } from './shared/item/item.component';
import { OrderItemComponent } from './shared/order-item/order-item.component';
import { OrderItemsComponent } from './orders/order-items/order-items.component';

@NgModule({
  declarations: [
    AppComponent,
    OrdersComponent,
    OrderComponent,
    CustomerComponent,
    ItemComponent,
    OrderItemComponent,
    OrderItemsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
