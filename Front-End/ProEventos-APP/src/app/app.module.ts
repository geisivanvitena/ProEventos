import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'; // Importa o módulo responsável por permitir a realização de requisições HTTP
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; // Importa o módulo de animações do Angular

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';

@NgModule({
  declarations: [
    AppComponent,
      EventosComponent,
      PalestrantesComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
