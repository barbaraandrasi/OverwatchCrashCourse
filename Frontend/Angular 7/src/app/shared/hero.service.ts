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
    Difficulty: new FormControl('')
  })

  register(selectedId) {
    var body = {
      name: this.form2.value.HeroName,
      role: selectedId,
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

  initializeFormGroup() {
    this.form2.setValue({
      HeroName: '',
      Role: '',
      Difficulty: '',
    });
}
}
