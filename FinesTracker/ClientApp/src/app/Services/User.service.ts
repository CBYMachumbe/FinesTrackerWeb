import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {User} from '../Models/User';

@Injectable({
  providedIn: 'root'
})

export class UserService {
  url = 'User';
  constructor(private http: HttpClient) {}

  public getUsers(page: number, pageLength: number): Observable<Array<User>> {
    return this.http.get<Array<User>>(this.url + `/GetAllUsers?page=${page}&pageLength=${pageLength}`);
  }
}
