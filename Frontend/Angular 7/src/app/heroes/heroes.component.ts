import { Component, OnInit, ViewChild, ChangeDetectorRef } from '@angular/core';
import { HeroService } from '../shared/hero.service';
import { MatDialog, MatDialogConfig, MatTableDataSource } from "@angular/material";
import { HeroComponent } from './hero/hero.component';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  dataSource;
  subscribedParam = "initial value";

  constructor(private service: HeroService, private toastr: ToastrService, private router:Router, private route: ActivatedRoute) { 
    this.config = {
      itemsPerPage: 10,
      currentPage: 1,
      totalItems: null
    };
  }

  config: any;

  
  pageChanged(event){
    this.config.currentPage = event;
  }

  ngOnInit() {
    this.resetDatasource();
    this.route.paramMap.subscribe(params => {
      this.subscribedParam = params.get("id")
    })
  }

  onCreate(){
    this.router.navigate(['heroes/hero']);
    this.service.form2.reset();
  }

  resetDatasource() {
    this.service.getHeroes().subscribe(
      res => {
        this.dataSource = res;
        this.config.totalItems = this.dataSource.count
      },
      err => console.log(err)
    )
  }

  goto(id: string): void {
    this.router.navigate(['heroes/hero', id]);
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
}
