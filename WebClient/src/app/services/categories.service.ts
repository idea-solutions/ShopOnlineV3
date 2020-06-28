import { Injectable } from '@angular/core';
import { Category } from '../models/category';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
  category: Category[];

  baseUrl: any;
  modelName: any;

  //  options: {
  //     headers?: HttpHeaders | {[header: string]: string | string[]},
  //     observe?: 'body' | 'events' | 'response',
  //     params?: HttpParams|{[param: string]: string | string[]},
  //     reportProgress?: boolean,
  //     responseType?: 'arraybuffer'|'blob'|'json'|'text',
  //     withCredentials?: boolean,
  //   }
  constructor(private http: HttpClient) {
    this.baseUrl = environment.BaseUrl;
    this.modelName = "/api/Category/"
  }
  public GetAllCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(this.baseUrl + this.modelName);
  }

}
