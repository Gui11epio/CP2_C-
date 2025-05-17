# CP2- C#

## 📌 Descrição do Projeto

Este projeto consiste em uma API RESTful desenvolvida com ASP.NET Core, com objetivo de gerenciar entidades como Motos, Filiais e Pátios. A aplicação implementa operações básicas de CRUD (Create, Read, Update, Delete) e segue uma arquitetura em camadas (Controllers, Application, Domain, Infrastructure).

## 👥 Nome e RM dos Integrantes

- Guilherme Camasmie Laiber de Jesus – RM554894

- Fernando Fernandes Prado – RM557982

- Pedro Manzo Yokoo – RM556115

## 🚀 Rotas Disponíveis

### 📍 MotoController - `/api/moto`
- `GET /api/moto`  
  Retorna todas as motos cadastradas.

- `GET /api/moto/placa?valor=XYZ1234`  
  Retorna uma moto específica pela placa.

- `POST /api/moto`  
  Cria uma nova moto. Requer um corpo com os dados da moto.

- `PUT /api/moto/placa?placa=XYZ1234`  
  Atualiza os dados de uma moto pela placa.

> Os outros controllers (`FilialController`, `PatioController`) seguem estrutura semelhante com operações básicas de CRUD.

## 🛠️ Tecnologias Utilizadas

- [.NET 6 / ASP.NET Core](https://dotnet.microsoft.com/)
- C#
- Entity Framework Core
- Swagger (OpenAPI) para documentação
- Visual Studio / VS Code

## ▶️ Instruções de Execução

1. **Clone o repositório:**
   ```bash
   git clone <url-do-repositório>
   cd CP2_C--master/Sprint1-C#
