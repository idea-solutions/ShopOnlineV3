import { Component, OnInit } from '@angular/core';
import { CategoriesService } from 'src/app/services/categories.service';
import { Category } from 'src/app/models/category';
import { element } from 'protractor';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.less']
})
export class HeaderComponent implements OnInit {
  categories: Category[];
  childCategory: Category[];
  parentCategory: Category[];
  constructor(private categoryService: CategoriesService) { }

  ngOnInit(): void {
    this.categoryService.GetAllCategories().subscribe((categories: Category[]) => {
      this.categories = categories
      this.childCategory = categories.filter(x => x.categoryParent === 0);
      this.parentCategory = categories.filter(x => x.categoryParent === 1);
    });

  }

}
