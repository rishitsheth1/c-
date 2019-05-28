import { Routes } from '@angular/router';
import { ArticlesComponent } from './articles.component';
import { CreateComponent } from './create/create.component';
import { ListComponent } from './list/list.component';
import { ViewComponent } from './view/view.component';
import { EditComponent } from './edit/edit.component';
import { ListAllCoursesComponent } from './listAllCourses/listAllCourses.component';
import { ListAllStudentsComponent } from './listAllStudents/listAllStudents.components'; 
export const ArticlesRoutes: Routes = [{
    path: 'articles',
    component: ArticlesComponent,
    children: [
        { path: 'listAllStudents', component: ListAllStudentsComponent },
        { path: 'listAllCourses', component: ListAllCoursesComponent },
       
        { path: '', component: ListComponent },
        { path: 'create', component: CreateComponent },
        { path: ':articleId', component: ViewComponent },
        { path: ':articleId/edit', component: EditComponent },
       
          
    ],
}];