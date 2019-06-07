import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RoleService } from '../shared/role.service';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.css']
})
export class RolesComponent implements OnInit {
  roles;

  constructor(private router:Router, private service:RoleService) { }

  ngOnInit() {
    this.service.getRoles().subscribe(
      res => this.roles = res,
      err => console.log(err)
    )
  }

  onLogout(){
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
}
