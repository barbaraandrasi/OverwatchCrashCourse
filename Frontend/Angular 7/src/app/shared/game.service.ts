import { Injectable } from '@angular/core';
import { HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:63767/api/';

  getGameDetails() {
    return this.http.get(this.BaseURI + 'Games');
  }

  getGameModes() {
    return this.http.get(this.BaseURI + 'GameModes');
  }
}
