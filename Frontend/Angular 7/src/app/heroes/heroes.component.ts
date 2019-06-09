import { Component, OnInit, ViewChild, ChangeDetectorRef } from '@angular/core';
import { HeroService } from '../shared/hero.service';
import { MatDialog, MatDialogConfig, MatTableDataSource } from "@angular/material";
import { HeroComponent } from './hero/hero.component';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  displayedColumns: string[] = ['name', 'role', 'difficulty', 'actions'];
  dataSource;

  constructor(private service: HeroService, private toastr: ToastrService, private router:Router, private dialog: MatDialog) { }


  ngOnInit() {
    this.resetDatasource();
  }

onCreate(){
  this.service.initializeFormGroup(null);
  const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = "30%";
  this.dialog.open(HeroComponent, dialogConfig);
  this.dialog.afterAllClosed.subscribe(() => {
    this.resetDatasource();
   })
}

onEdit(row) {
  this.service.initializeFormGroup(row);
  const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = "30%";
  this.dialog.open(HeroComponent, dialogConfig);
   this.dialog.afterAllClosed.subscribe(() => {
       this.resetDatasource();
      })
}

onDelete(row) {
  if (confirm('Are you sure to delete this record ?')) {
    this.service.deleteHero(row.id)
      .subscribe(res => {
        debugger;
        this.toastr.warning('Hero removed!', 'Hero deleted successfully!');
        this.resetDatasource();
      },
        err => {
          debugger;
          console.log(err);
        })
  }
}

  resetDatasource() {
    this.service.getHeroes().subscribe(
      res => {
        this.dataSource = res;
      },
      err => console.log(err)
    )
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
}
