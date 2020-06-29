import { NumberSymbol } from '@angular/common'
import { Category } from './category'

export interface Product {
  id: string;
  categoryId: string;
  name: string;
  productImage: string;
  detail: string;
  price: number;
  createBy: string;
  modifiedBy: string;
  dateCreate: Date;
  dateModified: Date;
  status: number;
  imageProductLocation: string;
  fileData: string;
  fileImage: string;
  category: Category;
}
