import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/models/category';
import { CategoriesService } from 'src/app/services/categories.service';

@Component({
  selector: 'app-mainpage',
  templateUrl: './mainpage.component.html',
  styleUrls: ['./mainpage.component.less']
})
export class MainpageComponent implements OnInit {

  categories: Category[];

  constructor(private categoryService: CategoriesService) {

  }



  ngOnInit(): void {
    this.categoryService.GetAllCategories().subscribe((categories: Category[]) => this.categories = categories);
    console.log(this.categories);
  }



}
