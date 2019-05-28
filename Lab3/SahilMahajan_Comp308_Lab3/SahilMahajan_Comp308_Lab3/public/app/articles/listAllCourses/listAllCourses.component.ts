 import { Component } from '@angular/core';
import { ArticlesService } from '../articles.service';
import { AuthenticationService } from '../../authentication/authentication.service';



@Component({
    selector: 'listAllCourses',
    templateUrl: 'app/articles/listAllCourses/listAllCourses.template.html'
})
export class ListAllCoursesComponent {
    user: any;
    articles: any;
    errorMessage: string;
    constructor(private _articlesService: ArticlesService, private _authenticationService:
        AuthenticationService) {
        console.log("in constructor");
        this.user = _authenticationService.user;
    }
    ngOnInit() {
        console.log("in ngonit");
        this._articlesService.list().subscribe(articles => this.articles
            = articles);
        console.log("in end of ngonit" + this.articles+" user is  "+ this.user);

    }
}

