import { Routes } from '@angular/router';
import { Machine } from './components/machine/machine';
import { Home } from './components/home/home';

export const routes: Routes = [
    {
        path: "",
        component: Home
    },
    {
        path: "Machine",
        component: Machine
    },
];
