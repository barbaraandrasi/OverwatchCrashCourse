import { Component, OnInit, ViewChild } from '@angular/core';
import { HeroService } from '../shared/hero.service';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialog, MatDialogConfig } from "@angular/material";
import { HeroComponent } from './hero/hero.component';

export class HeroDto {
  id: string;
  name: string;
  roleName: string;
  roleId: string;
  difficulty: string
}


@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  displayedColumns: string[] = ['name', 'role', 'difficulty', 'actions'];
  dataSource;

  constructor(private service: HeroService, private dialog: MatDialog) { }

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  searchkey: string;

  ngOnInit() {
    this.service.getHeroes().subscribe(
      res => {
        this.dataSource = res;
        this.dataSource.sort(x=> x. Name);
        this.dataSource.paginator=this.paginator;
      },
      err => console.log(err)
    )
  }
onCreate(){
  this.service.initializeFormGroup(null);
  const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = "50%";
  this.dialog.open(HeroComponent, dialogConfig);
}

onEdit(row) {
  this.service.initializeFormGroup(row);
  const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus = true;
    dialogConfig.width = "50%";
  this.dialog.open(HeroComponent, dialogConfig);
}

onDelete(row) {
  this.service.deleteHero(row.id).subscribe(
    () => console.log("user deleted")
    );
}
}
