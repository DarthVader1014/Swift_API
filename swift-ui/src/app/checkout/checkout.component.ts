import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {

  items;
  checkoutForm;

  constructor(
    private sharedService: SharedService,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {

    this.items = this.sharedService.getCart()
    this.checkoutForm = this.formBuilder.group({})
  }

  OnSubmit(customerData){
    //Checkout data
    console.warn('Order has been submitted', customerData)

    this.items = this.sharedService.emptyCart();
    this.checkoutForm.reset();
  }

}
