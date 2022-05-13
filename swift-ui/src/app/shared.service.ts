import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Subject } from 'rxjs';
import { BehaviorSubject } from 'rxjs';


@Injectable()
export class SharedService {

//Storage for local variables
public cartItems = [];
public totalAmount = new Subject<number>();
public products = new Subject();


getCart(): any {
  return this.cartItems;
}

getProducts(): Observable<any> {
  // console.log('this.cartItems: ' , this.cartItems);
  return this.products.asObservable();
}

setProducts(products) {
  // this.cartItems.push(...products);
  this.products.next(products);
}

addProductToCart(product){
  this.cartItems.push(product);
  this.setTotalPrice();
  console.log(JSON.stringify(this.cartItems))


}

removeProductFromCart(productId) {
  this.cartItems.map((item,index) => {
    if(item.id == productId) {
      this.cartItems.splice(index, 1)
    }
  });
  this.setTotalPrice();
}

  //Remove products from cart
  emptyCart() {
    this.cartItems.length = 0;
  }

  //Calculate total price
  setTotalPrice() {
    let total = 0;

    this.cartItems.map(item => {
      total += item.price;
    });

    this.totalAmount.next(total);

    return total;
  }

  getTotalAmount(): Observable<number> {
    return this.totalAmount.asObservable();
  }
}


