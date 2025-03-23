import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { RegiaoService, Regiao, FiltroAtivo } from './regiao.service';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})
export class RegiaoComponent implements OnInit {
  regioes$: Observable<Regiao[]>;
  filtro: FiltroAtivo = 'todos';

  constructor(private regiaoService: RegiaoService) { }

  ngOnInit() {
    this.carregarRegioes();
  }

  carregarRegioes() {
    this.regioes$ = this.regiaoService.getRegioes(this.filtro);
  }

  aplicarFiltro(_filtro: FiltroAtivo) {
    this.filtro = _filtro;
    this.carregarRegioes();
  }

  editarRegiao(regiao: Regiao) {
    console.log(regiao);
  }

  toggleAtivoRegiao(regiao: Regiao) {
    this.regiaoService.toggleAtivo(regiao.id, regiao.ativo).subscribe(
      () => {
        this.carregarRegioes();
      }
    );
  }

  excluirRegiao(regiao: Regiao) {
    this.regiaoService.deleteRegiao(regiao.id).subscribe(() => {
      this.carregarRegioes();
    });
  }
}
