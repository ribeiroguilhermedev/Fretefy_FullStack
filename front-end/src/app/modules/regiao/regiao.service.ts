import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Cidade } from '../cidade/cidade.service';

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

export interface RegiaoFormData {
    nome: string;
    descricao: string;
    cidades?: Cidade[];
}

export interface RegiaoNestedPayload {
    regiao: {
        id?: string;
        nome: string;
        descricao: string;
    };
    cidades: Cidade[];
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

    getRegiao(id: string): Observable<Regiao> {
        return this.http.get<Regiao>(`${this.apiUrl}/${id}`);
    }

    createRegiao(formData: RegiaoFormData): Observable<Regiao> {
        const payload: RegiaoNestedPayload = {
            regiao: {
                nome: formData.nome,
                descricao: formData.descricao
            },
            cidades: formData.cidades || []
        };

        return this.http.post<Regiao>(`${this.apiUrl}/nested`, payload);
    }

    updateRegiao(id: string, formData: RegiaoFormData): Observable<Regiao> {
        const payload = {
            nome: formData.nome,
            descricao: formData.descricao
        };

        return this.http.put<Regiao>(`${this.apiUrl}/${id}`, payload);
    }

    toggleAtivo(id: string, ativoAtual: boolean): Observable<any> {
        const payload = {
            ativo: !ativoAtual
        };
        return this.http.patch(`${this.apiUrl}/${id}/toggle-ativo`, payload);
    }

    deleteRegiao(id: string): Observable<any> {
        return this.http.delete(`${this.apiUrl}/${id}`);
    }

    adicionarCidadeNaRegiao(regiaoId: string, cidadeId: string): Observable<any> {
        const payload = {
            cidadesIds: [cidadeId]
        };
        return this.http.post(`${this.apiUrl}/${regiaoId}/cidades`, payload);
    }

    removerCidadeDaRegiao(regiaoId: string, cidadeId: string): Observable<any> {
        return this.http.delete(`${this.apiUrl}/${regiaoId}/cidades/${cidadeId}`);
    }
} 