import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { InvestimentoComponent } from './investimento/investimento.component';
import { NumericDirective } from "./helpers/numeric.directive";
import { ApiHttpService } from './core/services/api-http';

@NgModule({
  declarations: [
    AppComponent,
    NumericDirective,
    NavMenuComponent,
    InvestimentoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: InvestimentoComponent, pathMatch: 'full' }
    ])
  ],
  providers: [ApiHttpService, NumericDirective],
  bootstrap: [AppComponent]
})
export class AppModule { }
