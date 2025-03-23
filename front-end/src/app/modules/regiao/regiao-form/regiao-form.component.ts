import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators, FormArray } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError, switchMap, tap } from 'rxjs/operators';
import { Regiao, RegiaoService } from '../regiao.service';
import { CidadeService, Cidade } from '../../cidade/cidade.service';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
    selector: 'app-regiao-form',
    templateUrl: './regiao-form.component.html',
    styleUrls: ['./regiao-form.component.scss']
})
export class RegiaoFormComponent implements OnInit {
    regiaoForm: FormGroup;
    modoEdicao = false;
    regiaoId: string;
    enviouForm = false;
    cidades: Cidade[] = [];
    cidadesDisponiveis: Cidade[] = [];
    cidadeSelecionada: string = '';
    errorMessage: string = '';

    constructor(
        private fb: FormBuilder,
        private regiaoService: RegiaoService,
        private cidadeService: CidadeService,
        private route: ActivatedRoute,
        private router: Router
    ) {
        this.createForm();
    }

    get cidadesFormArray() {
        return this.regiaoForm.get('cidades') as FormArray;
    }

    get nome() {
        return this.regiaoForm.get('nome');
    }

    get descricao() {
        return this.regiaoForm.get('descricao');
    }

    ngOnInit() {
        this.cidadeService.getCidades().subscribe(
            cidades => {
                this.cidades = cidades;
                this.cidadesDisponiveis = [...cidades];
            }
        );

        this.route.paramMap.pipe(
            switchMap(params => {
                const id = params.get('id');
                if (id) {
                    this.modoEdicao = true;
                    this.regiaoId = id;
                    return this.regiaoService.getRegiao(id);
                }
                return of(null);
            })
        ).subscribe(regiao => {
            if (!regiao) return;

            this.populateForm(regiao);

            if (this.modoEdicao && regiao.cidades && regiao.cidades.length) {
                const cidadesJaAdicionadasIds = regiao.cidades.map(c => c.id);
                this.cidadesDisponiveis = this.cidades.filter(
                    c => !cidadesJaAdicionadasIds.includes(c.id)
                );
            }
        });
    }

    createForm() {
        const cidadesValidators = this.modoEdicao ? [] : [Validators.required, Validators.minLength(1)];

        this.regiaoForm = this.fb.group({
            nome: ['', [Validators.required]],
            descricao: [''],
            cidades: this.fb.array([], cidadesValidators)
        });
    }

    populateForm(regiao: Regiao) {
        this.regiaoForm.patchValue({
            nome: regiao.nome,
            descricao: regiao.descricao
        });

        while (this.cidadesFormArray.length) {
            this.cidadesFormArray.removeAt(0);
        }

        if (regiao.cidades && regiao.cidades.length) {
            regiao.cidades.forEach(cidade => {
                this.cidadesFormArray.push(this.createCidadeFormGroup(cidade));
            });
        }
    }

    createCidadeFormGroup(cidade: Cidade) {
        return this.fb.group({
            id: [cidade.id, Validators.required],
            nome: [cidade.nome],
            uf: [cidade.uf]
        });
    }

    adicionarCidade(): void {
        if (!this.cidadeSelecionada) {
            return;
        }

        const cidadeSelecionada = this.cidadesDisponiveis.find(c => c.id === this.cidadeSelecionada);

        if (!cidadeSelecionada) {
            return;
        }

        if (this.modoEdicao) {
            this.regiaoService.adicionarCidadeNaRegiao(this.regiaoId, this.cidadeSelecionada)
                .subscribe({
                    next: () => {
                        const cidadeFormGroup = this.fb.group({
                            id: [cidadeSelecionada.id],
                            nome: [cidadeSelecionada.nome],
                            uf: [cidadeSelecionada.uf]
                        });

                        this.cidadesFormArray.push(cidadeFormGroup);
                        this.cidadesDisponiveis = this.cidadesDisponiveis.filter(c => c.id !== this.cidadeSelecionada);
                        this.cidadeSelecionada = '';
                        this.errorMessage = '';
                    },
                    error: (error: HttpErrorResponse) => {
                        this.handleApiError(error);
                    }
                });
        } else {
            const cidadeFormGroup = this.fb.group({
                id: [cidadeSelecionada.id],
                nome: [cidadeSelecionada.nome],
                uf: [cidadeSelecionada.uf]
            });

            this.cidadesFormArray.push(cidadeFormGroup);
            this.cidadesDisponiveis = this.cidadesDisponiveis.filter(c => c.id !== this.cidadeSelecionada);
            this.cidadeSelecionada = '';
        }
    }

    removerCidade(index: number): void {
        const cidadeRemovida = this.cidadesFormArray.at(index).value;

        if (this.modoEdicao) {
            this.regiaoService.removerCidadeDaRegiao(this.regiaoId, cidadeRemovida.id)
                .subscribe({
                    next: () => {
                        this.cidadesFormArray.removeAt(index);

                        if (!this.cidadesDisponiveis.some(c => c.id === cidadeRemovida.id)) {
                            this.cidadesDisponiveis.push({
                                id: cidadeRemovida.id,
                                nome: cidadeRemovida.nome,
                                uf: cidadeRemovida.uf
                            });

                            this.cidadesDisponiveis.sort((a, b) => a.nome.localeCompare(b.nome));
                        }
                        this.errorMessage = '';
                    },
                    error: (error: HttpErrorResponse) => {
                        this.handleApiError(error);
                    }
                });
        } else {
            this.cidadesFormArray.removeAt(index);

            if (!this.cidadesDisponiveis.some(c => c.id === cidadeRemovida.id)) {
                this.cidadesDisponiveis.push({
                    id: cidadeRemovida.id,
                    nome: cidadeRemovida.nome,
                    uf: cidadeRemovida.uf
                });

                this.cidadesDisponiveis.sort((a, b) => a.nome.localeCompare(b.nome));
            }
        }
    }

    onSubmit(): void {
        this.enviouForm = true;
        this.errorMessage = '';

        if (this.regiaoForm.invalid) {
            return;
        }

        const formData = this.regiaoForm.value;

        if (this.modoEdicao) {
            this.regiaoService.updateRegiao(
                this.regiaoId,
                {
                    nome: formData.nome,
                    descricao: formData.descricao
                }
            ).subscribe({
                next: () => {
                    this.router.navigate(['/regiao']);
                },
                error: (error: HttpErrorResponse) => {
                    this.handleApiError(error);
                }
            });
        } else {
            this.regiaoService.createRegiao(formData).subscribe({
                next: () => {
                    this.router.navigate(['/regiao']);
                },
                error: (error: HttpErrorResponse) => {
                    this.handleApiError(error);
                }
            });
        }
    }

    cancelar() {
        this.router.navigate(['/regiao']);
    }

    private handleApiError(error: HttpErrorResponse): void {
        if (error.status >= 400 && error.status < 500) {
            if (typeof error.error === 'string') {
                this.errorMessage = error.error;
            } else {
                this.errorMessage = `Erro ${error.status}: ${error.statusText || 'Erro na requisição'}`;
            }
        } else {
            this.errorMessage = 'Ocorreu um erro no servidor';
        }
    }
} 