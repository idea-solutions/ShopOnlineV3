import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.less']
})
export class ShopComponent implements OnInit {
  products: Product[];
  constructor(private productService: ProductsService) { }
  ngOnInit(): void {
    this.productService.GetAllProduct().subscribe((products: Product[]) => {
      this.products = products;
      console.log(this.products);
    });
  }

}
