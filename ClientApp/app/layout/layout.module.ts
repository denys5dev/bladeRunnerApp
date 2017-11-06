import { NgModule } from '@angular/core';

import { SharedModule } from './../shared/shared.module';
import { LayoutComponent } from './layout.component';
import { NavMenuComponent } from './navmenu/navmenu.component';

@NgModule({
    imports: [
        SharedModule
    ],
    providers: [
        
    ],
    declarations: [
        LayoutComponent,
        NavMenuComponent
    ],
    exports: [
        LayoutComponent,
        NavMenuComponent
    ]
})
export class LayoutModule { }