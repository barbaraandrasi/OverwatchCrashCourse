    
import { Injectable } from '@angular/core';
import {FormGroup, FormControl, Validators} from "@angular/forms";
import { HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class HeroService {

  constructor(private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:63767/api/';

  form2: FormGroup = new FormGroup({
    HeroName: new FormControl('',Validators.required),
    Role: new FormControl('',Validators.required),
    Difficulty: new FormControl('')
  })

  register() {
    var body = {
      name: this.form2.value.HeroName,
      role: this.form2.value.Role,
      difficulty: this.form2.value.Difficulty
    };
    var headers: { 
      'Accept': 'application/json',
      'Content-Type': 'application/json' 
  }
    return this.http.post(this.BaseURI+'Heroes', body, { headers });
  }

  getRoles() {
    return this.http.get(this.BaseURI+'Roles');
  }

  getHeroes(){
    return this.http.get(this.BaseURI + 'Heroes');
  }

  updateHero() {
    var id;
    var body = {
      id: id,
      name: this.form2.value.HeroName,
      role: this.form2.value.Role,
      difficulty: this.form2.value.Difficulty
    };
    var headers: { 
      'Accept': 'application/json',
      'Content-Type': 'application/json' 
  }
    return this.http.put(this.BaseURI + "Heroes/"+id, body, {headers} );
  }

  deleteHero() {
    var id;

    this.http.delete(this.BaseURI +'Heroes/'+id);
  }

  initializeFormGroup() {
    this.form2.setValue({
      HeroName: '',
      Role: '',
      Difficulty: '',
    });
}
}
