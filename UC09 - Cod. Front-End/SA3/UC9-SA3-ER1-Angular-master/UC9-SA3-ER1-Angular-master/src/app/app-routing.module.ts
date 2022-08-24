import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContatComponent } from './view/contat/contat.component';

const routes: Routes = [
  {path: "contato", component: ContatComponent}
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
