import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Home } from './components/home/home';
import { Machine } from './components/machine/machine';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Home,Machine],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Concert Technologies');
}
