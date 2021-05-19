import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {FinePost} from '../Models/FinePost';
import {Injectable} from '@angular/core';
import {TallyObject} from '../Models/TallyObject';


@Injectable({
  providedIn: 'root'
})

export class FinePostService {
  url = 'FinePost';
  constructor(private http: HttpClient) {}

  public getAllFinePosts(page: number, pageLength: number): Observable<Array<FinePost>> {
    return this.http.get<Array<FinePost>>(this.url + `/GetAllFinePosts?page=${page}&pageLength=${pageLength}`);
  }

  public addNewFinePost(post: FinePost): Observable<any> {
    return this.http.post<any>(this.url + '/AddNewFine', post);
  }

  public getTallyObjects(): Observable<Array<TallyObject>> {
    return this.http.get<Array<TallyObject>>(this.url + '/GetTally');

  }
}
