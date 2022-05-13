import { Component, Input, OnInit, Renderer2 } from '@angular/core';
import { MyMainService } from '../main.service';

import { SharedService } from '../shared.service';

@Component({
  selector: 'product-list-component',
  templateUrl: 'product-list.component.html',
})
export class ProductListComponent implements OnInit {

  @Input() products: any = [];
  public singleProduct;
  public isAdded;

  constructor(
    public renderer: Renderer2,
    private myMainService: MyMainService,
    private sharedService: SharedService
  ) {
    this.setProducts();
  }

  ngOnInit() {
    console.log('I am product-list');

    this.isAdded = new Array(this.products.length);
    this.isAdded.fill(false, 0, this.products.length);

    this.setProducts();
    this.getProducts();
  }

  setProducts() {
    // Get all product list on component init
    this.myMainService.getProducts().subscribe((data: any) => {
      this.sharedService.setProducts(data);
      console.log(data);
    });
  }

  getProducts() {
    this.sharedService.getProducts().subscribe((data: any) => {
      if (data && data.length > 0) {
        this.products = data;
      } else {
        this.products.map((item, index) => {
          this.isAdded[index] = false;
        });
      }
    });
  }


  // Add item in cart on Button click
  // ===============================

  addToCart(productId) {

    // Change button color to green
    this.products.map((item, index) => {
      if (item.id === productId) {
        this.isAdded[index] = true;
      }
    })

    this.singleProduct = this.products.filter(product => {
      return product.id === productId;
    });

    this.sharedService.addProductToCart(this.singleProduct[0]);
  }

}
