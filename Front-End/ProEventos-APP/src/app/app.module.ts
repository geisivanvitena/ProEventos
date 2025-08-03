import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

// Importa o módulo responsável por permitir a realização de requisições HTTP
import { HttpClientModule } from '@angular/common/http';
// Importa o módulo de animações do Angular
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// Importa os módulos necessários do ngx-bootstrap para funcionalidade de colapso (collapse)
import { CollapseModule } from 'ngx-bootstrap/collapse';
// Importa o FormsModule para habilitar o uso de [(ngModel)] (two-way data binding) nos formulários
import { FormsModule } from '@angular/forms';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { NavComponent } from './nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
      EventosComponent,
      PalestrantesComponent,
      NavComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
