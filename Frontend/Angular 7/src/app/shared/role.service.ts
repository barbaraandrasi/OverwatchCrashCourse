import { Injectable } from '@angular/core';
import { HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class RoleService {

  constructor(private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:63767/api/';
  
  getRoles() {
    return this.http.get(this.BaseURI + 'Roles');
  }

}