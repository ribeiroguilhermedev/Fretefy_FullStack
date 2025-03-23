import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

export interface Cidade {
    id: string;
    nome: string;
    uf: string;
}

export interface Regiao {
    id: string;
    nome: string;
    descricao: string;
    criadoEm: string;
    atualizadoEm: string;
    ativo: boolean;
    cidades: Cidade[];
    mostrarCidades?: boolean;
}

export type FiltroAtivo = 'todos' | 'ativos' | 'inativos';

@Injectable({
    providedIn: 'root'
})
export class RegiaoService {
    private apiUrl = 'http://localhost:5001/api/regiao';

    constructor(private http: HttpClient) { }

    getRegioes(filtroAtivo: FiltroAtivo = 'todos'): Observable<Regiao[]> {
        let params = new HttpParams();

        if (filtroAtivo === 'ativos') {
            params = params.set('ativo', 'true');
        } else if (filtroAtivo === 'inativos') {
            params = params.set('ativo', 'false');
        }

        return this.http.get<Regiao[]>(this.apiUrl, { params }).pipe(
            map(regioes => regioes.map(regiao => ({
                ...regiao,
                mostrarCidades: false
            })))
        );
    }

    toggleAtivo(id: string, ativoAtual: boolean): Observable<any> {
        const payload = {
            ativo: !ativoAtual
        };
        return this.http.patch(`${this.apiUrl}/${id}/toggle-ativo`, payload);
    }
} 