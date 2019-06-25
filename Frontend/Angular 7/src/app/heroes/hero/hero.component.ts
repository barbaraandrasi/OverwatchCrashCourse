import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { HeroService } from 'src/app/shared/hero.service';
import { ToastrService } from 'ngx-toastr';
import { balancePreviousStylesIntoKeyframes } from '@angular/animations/browser/src/util';

@Component({
  selector: 'app-hero',
  templateUrl: './hero.component.html',
  styles: [],
  styleUrls: ['./hero.component.css']
})
export class HeroComponent implements OnInit {
  roles;
  heroDetail;


  constructor(private router: Router,
    private service: HeroService,
    private toastr: ToastrService,
    private route: ActivatedRoute) { }

  ngOnInit() {
    this.service.getRoles().subscribe(
      res => this.roles = res,
      err => console.log(err)
    )
    const id = this.route.snapshot.paramMap.get('id');
    this.service.getOneHero(id).subscribe(
      res => {
        this.heroDetail = res;
        this.service.initializeFormGroup(this.heroDetail);
      },
      err => console.log(err)
    )
  }

  onSubmit() {
    this.service.persist().subscribe(
      (res: any) => {
        if (!res) {
          this.service.form2.reset();
          this.toastr.success('Hero updated!', 'Hero modified succesfully!');
          this.back();
        } else if (!res.err) {
          this.service.form2.reset();
          this.toastr.success('New hero created!', 'Hero created succesfully!');
          this.back();
        }
      },
      err => {
        console.log(err);
      }
    );
  }

  onDelete(heroDetail) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deleteHero(heroDetail.id)
        .subscribe(res => {
          debugger;
          this.toastr.warning('Hero removed!', 'Hero deleted successfully!');
          this.back();
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }

  onLogout() {
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }

  back() {
    this.router.navigate(['/heroes']);
  }
}