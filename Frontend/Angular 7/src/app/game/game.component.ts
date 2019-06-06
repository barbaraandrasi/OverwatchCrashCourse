import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { GameService } from '../shared/game.service';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styles: [],
  styleUrls:['./game.component.css']
})
export class GameComponent implements OnInit {
  gameDetails;
  gameModes;

  constructor(private router:Router, private service:GameService) { }

  ngOnInit() {
    this.service.getGameDetails().subscribe(
      res => this.gameDetails = res[0],
      err => console.log(err)
    );

    this.service.getGameModes().subscribe(
      res => this.gameModes = res,
      err => console.log(err)
    )
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
}
