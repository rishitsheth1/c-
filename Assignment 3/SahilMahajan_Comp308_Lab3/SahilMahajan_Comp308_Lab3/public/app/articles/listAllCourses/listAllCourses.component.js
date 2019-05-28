System.register(["@angular/core", "../articles.service", "../../authentication/authentication.service"], function (exports_1, context_1) {
    "use strict";
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var __moduleName = context_1 && context_1.id;
    var core_1, articles_service_1, authentication_service_1, ListAllCoursesComponent;
    return {
        setters: [
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (articles_service_1_1) {
                articles_service_1 = articles_service_1_1;
            },
            function (authentication_service_1_1) {
                authentication_service_1 = authentication_service_1_1;
            }
        ],
        execute: function () {
            ListAllCoursesComponent = /** @class */ (function () {
                function ListAllCoursesComponent(_articlesService, _authenticationService) {
                    this._articlesService = _articlesService;
                    this._authenticationService = _authenticationService;
                    console.log("in constructor");
                    this.user = _authenticationService.user;
                }
                ListAllCoursesComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    console.log("in ngonit");
                    this._articlesService.list().subscribe(function (articles) { return _this.articles
                        = articles; });
                    console.log("in end of ngonit" + this.articles + " user is  " + this.user);
                };
                ListAllCoursesComponent = __decorate([
                    core_1.Component({
                        selector: 'listAllCourses',
                        templateUrl: 'app/articles/listAllCourses/listAllCourses.template.html'
                    }),
                    __metadata("design:paramtypes", [articles_service_1.ArticlesService,
                        authentication_service_1.AuthenticationService])
                ], ListAllCoursesComponent);
                return ListAllCoursesComponent;
            }());
            exports_1("ListAllCoursesComponent", ListAllCoursesComponent);
        }
    };
});
//# sourceMappingURL=listAllCourses.component.js.map