import { Routes } from "@angular/router";

import { HomeComponent } from "./navigation/home/home.component";

export const rootRouterConfig: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent }
];