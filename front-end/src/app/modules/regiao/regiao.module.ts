import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RegiaoComponent } from './regiao.component';
import { RegiaoFormComponent } from './regiao-form/regiao-form.component';
import { RegiaoRoutingModule } from './regiao.routing';
import { RegiaoService } from './regiao.service';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    RegiaoRoutingModule
  ],
  declarations: [
    RegiaoComponent,
    RegiaoFormComponent
  ],
  exports: [
    RegiaoComponent,
    RegiaoFormComponent
  ],
  providers: [RegiaoService]
})
export class RegiaoModule { }
