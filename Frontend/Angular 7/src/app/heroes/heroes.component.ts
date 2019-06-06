import { Component, OnInit } from '@angular/core';
import { HeroService } from '../shared/hero.service';

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
  displayedColumns: string[] = ['name', 'role', 'difficulty'];
  dataSource;

  constructor(private service: HeroService) { }

  ngOnInit() {
    this.service.getHeroes().subscribe(
      res => {
        this.dataSource = res;
      },
      err => console.log(err)
    )
  }

}
