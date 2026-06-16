# FarmaciaInteligente-API
API .NET voltada para gestão de conteúdos farmacêuticos com integração de IA Generativa e RAG.
# Farmácia Inteligente API 💊

Projeto desenvolvido como parte do aprimoramento técnico e prático de conhecimentos em **.NET 8**. O objetivo desta API é fornecer soluções inteligentes para o gerenciamento de informações farmacêuticas, aplicando padrões de arquitetura e boas práticas de desenvolvimento.

## 🚀 Tecnologias e Ferramentas
* **.NET 8.0**
* **ASP.NET Core Web API**
* **FluentValidation** (Validação de dados)
* **Git / GitHub** (Controle de versão)
* **GitHub Codespaces** (Ambiente de desenvolvimento)

## 🏗️ Estrutura do Projeto
O projeto segue uma estrutura organizada para facilitar a manutenção e a escalabilidade:
```text
/src
├── Controllers/      # Controladores da API
├── DTOs/             # Data Transfer Objects
├── Middlewares/      # Tratamento global de erros
├── Services/         # Lógica de negócio e interfaces
└── Validators/       # Regras de validação (FluentValidation)
🛠️ Como rodar o projeto
Clone o repositório.

Certifique-se de estar com o SDK do .NET 8 instalado.

No terminal, na raiz do projeto, execute:

Bash
   dotnet build
   dotnet run
🎯 Status do Desenvolvimento
[x] Configuração da arquitetura base (src/ e .csproj)

[x] Implementação do Middleware de Erros

[x] Implementação de DTOs

[x] Implementação de Validação com FluentValidation

[ ] Implementação de persistência de dados (Próximos passos