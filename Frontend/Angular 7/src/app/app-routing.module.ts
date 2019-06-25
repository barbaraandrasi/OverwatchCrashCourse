import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './auth/auth.guard';
import { UserprofileComponent } from './userprofile/userprofile.component';
import { HeroComponent } from './heroes/hero/hero.component';
import { GameComponent } from './game/game.component';
import { HeroesComponent } from './heroes/heroes.component';
import { RolesComponent } from './roles/roles.component';

const routes: Routes = [
  {path:'',redirectTo:'/user/login',pathMatch:'full'},
  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'registration', component: RegistrationComponent },
      { path: 'login', component: LoginComponent }
    ]
  },
  { path:'home',  component:HomeComponent, canActivate:[AuthGuard]},
  { path:'userprofile', component:UserprofileComponent, canActivate:[AuthGuard] },
  { path:'heroes', component:HeroesComponent, canActivate:[AuthGuard]} ,
  { path:'heroes/hero/:id', component: HeroComponent, canActivate:[AuthGuard] },
  { path:'heroes/hero', component: HeroComponent, canActivate:[AuthGuard] },
  { path:'game', component:GameComponent, canActivate:[AuthGuard] },
  { path:'roles', component:RolesComponent, canActivate:[AuthGuard] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
