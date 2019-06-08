    
import { Injectable } from '@angular/core';
import {FormGroup, FormControl, Validators} from "@angular/forms";
import { HttpClient, HttpParams} from "@angular/common/http";
import { identifierModuleUrl } from '@angular/compiler';
import { HeroDto } from '../heroes/heroes.component';

@Injectable({
  providedIn: 'root'
})
export class HeroService {

  constructor(private http: HttpClient) { }
  readonly BaseURI = 'http://localhost:63767/api/';

  form2: FormGroup = new FormGroup({
    id: new FormControl(''),
    HeroName: new FormControl('',Validators.required),
    Role: new FormControl('',Validators.required),
    Difficulty: new FormControl('')
  })

 

 createHero() {
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

  updateHero(id) {
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
  
  persist() {
    if(this.form2.value.id) {
     return this.updateHero(this.form2.value.id);
    } else {
    return this.createHero();
    }
  }

  deleteHero(heroId) {
    var uri = this.BaseURI + 'heroes/' +heroId;
    const headers =  {
      'Accept': 'application/json',
      'Content-Type': 'application/json' 
    }

     return this.http.delete(this.BaseURI +'Heroes/'+heroId, {headers});
      }

 clear() {
  this.form2.setValue({
    id : this.form2.value.id,
    HeroName:'',
    Role:'',
    Difficulty: '',
  });
 }

  initializeFormGroup(hero) {
    this.form2.setValue({
      id : hero ? hero.id:null,
      HeroName: hero ? hero.name:'',
      Role: hero ? hero.role:'',
      Difficulty:hero ? hero.difficulty:'',
    });
}

/*refreshList(){
  this.http.get(this.BaseURI + 'Heroes')
  .toPromise()
  .then(res => this.list = res as HeroDto[]);
}
*/
}
