import { Component, OnInit } from "@angular/core";
import { SharedService } from "../shared.service";

@Component({
  selector: "header-component",
  templateUrl: 'header.component.html',
})

export class HeaderComponent implements OnInit {
  public cartProductCount: number = 0;

  constructor(private sharedService: SharedService) {}

  ngOnInit() {
    this.sharedService.getCart().subscribe(data => {
      this.cartProductCount = data.length;
    });
  }
}
