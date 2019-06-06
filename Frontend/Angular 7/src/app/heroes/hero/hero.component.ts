import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeroService } from 'src/app/shared/hero.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-hero',
  templateUrl: './hero.component.html',
  styles: [],
  styleUrls: ['./hero.component.css']
})
export class HeroComponent implements OnInit {
  roles;
  selected;

  constructor(private router:Router, private service: HeroService,private toastr: ToastrService) { }

  ngOnInit() {
    this.service.form2.reset();
    this.service.getRoles().subscribe(
      res => this.roles = res,
      err => console.log(err)
    )
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }

  onClear() {
    this.service.form2.reset();
    this.service.initializeFormGroup();
  }
  
 
    
 

  onSubmit() {
    var selectedId;
    this.roles.forEach(role => {
      if(role.name === this.selected && !selectedId){
         selectedId = role.id;      
      }
    });
    this.service.register(selectedId).subscribe(
      (res: any) => {
        if (res.succeeded) {
          this.service.form2.reset();
          this.toastr.success('New hero created!', 'Hero created succesfully!');
        }
      },
      err => {
        console.log(err);
      }
    );
  }
}
