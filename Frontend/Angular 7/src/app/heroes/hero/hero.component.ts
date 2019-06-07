import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeroService } from 'src/app/shared/hero.service';
import { ToastrService } from 'ngx-toastr';
import {MatDialogRef} from '@angular/material';

@Component({
  selector: 'app-hero',
  templateUrl: './hero.component.html',
  styles: [],
  styleUrls: ['./hero.component.css']
})
export class HeroComponent implements OnInit {
  roles;
  

  constructor(private router:Router,
     private service: HeroService,
     private toastr: ToastrService,
     public dialogRef: MatDialogRef<HeroComponent>) { }

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
    this.service.register().subscribe(
      (res: any) => {
        if (!res.err) {
          this.service.form2.reset();
          this.toastr.success('New hero created!', 'Hero created succesfully!');
          this.onClose();
        }
      },
      err => {
        console.log(err);
      }
    );
  }

  onClose() {
    this.service.form2.reset();
    this.service.initializeFormGroup();
    this.dialogRef.close();
  }

  roleConverter(roleId) {
      switch(roleId) {
        case 1: return 'Damage'
      }
  }
}