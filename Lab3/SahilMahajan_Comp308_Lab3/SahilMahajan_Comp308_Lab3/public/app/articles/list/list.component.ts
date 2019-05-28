 import { Component } from '@angular/core';
import { ArticlesService } from '../articles.service';
import { AuthenticationService } from '../../authentication/authentication.service';



@Component({
    selector: 'list',
    templateUrl: 'app/articles/list/list.template.html'
})
export class ListComponent {
    user: any;
    articles: any;
    errorMessage: string;
    constructor(private _articlesService: ArticlesService, private _authenticationService:
        AuthenticationService) {
        this.user = _authenticationService.user;
    }
    ngOnInit() {
        this._articlesService.list().subscribe(articles => this.articles
            = articles);

       
    }
}

