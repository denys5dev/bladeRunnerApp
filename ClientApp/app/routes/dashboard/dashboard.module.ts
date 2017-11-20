import { NgModule } from '@angular/core';
import { DashboardComponent } from './dashboard/dashboard.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
    { path: '', component: DashboardComponent },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    declarations: [DashboardComponent],
    exports: [
        RouterModule
    ]
})
export class DashboardModule { }
