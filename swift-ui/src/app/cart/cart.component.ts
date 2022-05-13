import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';

@Component({
  selector: 'cart-component',
  templateUrl: 'cart.component.html',
})
export class CartComponent implements OnInit {

  public cartItems;
  public totalAmmount;

  constructor(
    private sharedService: SharedService
  ) { }

  ngOnInit() {

      this.cartItems = this.sharedService.getCart();
      this.sharedService.getTotalAmount().subscribe((total: any) => {
      this.totalAmmount = total;

      });

  }

  // Remove item from cart list
  removeItemFromCart(productId) {
    /* this.cartItems.map((item, index) => {
      if (item.id === productId) {
        this.cartItems.splice(index, 1);
      }
    });

    this.mySharedService.setProducts(this.cartItems); */

    this.sharedService.removeProductFromCart(productId);

  }

  emptyCart() {
    this.sharedService.emptyCart();
  }

  checkOut(){

  }

}
