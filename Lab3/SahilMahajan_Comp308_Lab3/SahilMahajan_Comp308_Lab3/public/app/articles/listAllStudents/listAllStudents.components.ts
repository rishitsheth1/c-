import { Component } from '@angular/core';
import { ArticlesService } from '../articles.service';
import { AuthenticationService } from '../../authentication/authentication.service';

 

@Component({
    selector: 'listAllStudents',
    templateUrl: 'app/articles/listAllStudents/listAllStudents.template.html'
})
export class ListAllStudentsComponent {
    user: any;
    articles: any;
    users: any;
    errorMessage: string;
    constructor(private _articlesService: ArticlesService, private _authenticationService:
        AuthenticationService) {
        console.log("in constructor");
        this.user = _authenticationService.user;
    }
    ngOnInit() {
        console.log("in ListAllStudentsComponent subscribing");
        this._articlesService.listAllStudents().subscribe(articles => this.articles
            = articles);
        console.log(this.articles + " in end of ngonit  ListAllStudentsComponent  user is  " + this.user);

    }
}

