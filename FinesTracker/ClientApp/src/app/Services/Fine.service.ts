import { Injectable } from '@angular/core';
import {HttpClient, HttpResponse} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Fine} from '../Models/Fine';

@Injectable({
  providedIn: 'root'
})
export class FineService {

  url = 'fines';
  constructor(private http: HttpClient) { }

  public getAllFines(page: number, pageLength: number): Observable<Array<Fine>>{
    return this.http.get<Array<Fine>>(this.url + `/GetAllFines?page=${page}&pageLength=${pageLength}`);
  }

  public getFineById(id: number): Observable<Fine>{
    return this.http.get<Fine>(this.url + `/GetById/${id}`);
  }

  public updateFine(id: number, fine: Fine): Observable<HttpResponse<any>>{
    return this.http.put<HttpResponse<any>>(this.url + `/UpdateFine/${id}`, fine);
  }

  public addFine(fine: Fine): Observable<HttpResponse<any>>{
    return this.http.post<HttpResponse<any>>(this.url, fine);
  }

  public deleteFine(id: number): Observable<HttpResponse<any>>{
    return this.http.delete<HttpResponse<any>>(this.url + `/Delete/${id}`);
  }
}
