import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Product } from '../models/product';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { CheckApiRequest } from '../common/CheckApiRequest';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  Products: Product[];

  baseUrl: any;
  modelName: any;
  constructor(private http: HttpClient) {
    this.baseUrl = environment.BaseUrl;
    this.modelName = "/api/product/"
  }

  GetAllProduct(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseUrl + this.modelName)
    .pipe(catchError(CheckApiRequest.handleError));
  }


}
