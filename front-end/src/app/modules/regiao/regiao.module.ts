import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { RegiaoComponent } from './regiao.component';
import { RegiaoRoutingModule } from './regiao.routing';
import { RegiaoService } from './regiao.service';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    RegiaoRoutingModule
  ],
  declarations: [RegiaoComponent],
  exports: [RegiaoComponent],
  providers: [RegiaoService]
})
export class RegiaoModule { }
