import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContatComponent } from './view/contat/contat.component';
import { JogosComponent } from './view/jogos/jogos.component';

@NgModule({
  declarations: [
    AppComponent,
    ContatComponent,
    JogosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
