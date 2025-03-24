# Fretefy API Teste

## Pré-requisitos

- Docker e Docker Compose

## Configuração Inicial

### 1. Clone o repositório

```bash
git clone https://github.com/ribeiroguilhermedev/Fretefy_FullStack.git
cd Fretefy_FullStack/back-end
```

### 2. Inicie os contêineres Docker

```bash
docker-compose up -d
```

Isso irá iniciar todos os serviços necessários: ef e api

### 3. Ver o status dos contêineres

```bash
docker-compose ps
```

### 4. Execute as migrações de banco de dados

```bash
# Entre no container do ef
docker-compose exec ef bash

# Execute o comando de update dentro do container
dotnet ef database update --project Fretefy.Test.Infra/ --startup-project Fretefy.Test.WebApi/
```

Este comando irá atualizar o banco de dados sincronizado com as migartions.

## Desenvolvimento


### Acessar a API

Após executar os serviços, a api estará disponivel em:

```
http://localhost:5001
```

E o Swagger:

```
http://localhost:5000/swagger
```
Para encerrar os serviços:

```bash
docker-compose down
```

## Comandos

### Reconstruir contêineres

Se você precisar reconstruir os contêineres após alterações:

```bash
docker-compose build
docker-compose up -d
```

### Limpar recursos

Para encerrar e remover volumes:

```bash
docker-compose down -v
``` 


## Front-end

Para rodar o front-end com versões mais recentes do Node, utilize o  comando:

```bash
export NODE_OPTIONS=--openssl-legacy-provider && npm start
```

resolve problemas de compatibilidade com a versao do angular do projeto