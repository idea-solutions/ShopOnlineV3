import { Injectable } from '@angular/core';
import { Category } from '../models/category';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { CheckApiRequest } from '../common/CheckApiRequest';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
  category: Category[];

  baseUrl: any;
  modelName: any;


  constructor(private http: HttpClient) {
    this.baseUrl = environment.BaseUrl;
    this.modelName = "/api/Category/"
  }
  public GetAllCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(this.baseUrl + this.modelName).pipe(
      catchError(CheckApiRequest.handleError)
    );
  }
}
