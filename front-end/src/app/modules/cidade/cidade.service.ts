import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Cidade {
    id: string;
    nome: string;
    uf: string;
}

@Injectable({
    providedIn: 'root'
})
export class CidadeService {
    private apiUrl = 'http://localhost:5001/api/cidade';

    constructor(private http: HttpClient) { }

    getCidades(): Observable<Cidade[]> {
        return this.http.get<Cidade[]>(this.apiUrl);
    }
} 