# Personal Finance API

Uma API RESTful robusta e modular para gestão financeira pessoal, desenvolvida com **.NET 10** e **C#**, aplicando conceitos de **Clean Architecture**, **Domain-Driven Design (DDD)** simplificado e boas práticas de engenharia de software.

---

## Tecnologias e Bibliotecas

- **Framework:** .NET 10 / ASP.NET Core Web API
- **Banco de Dados & ORM:** PostgreSQL + Entity Framework Core (Code-First & Migrations)
- **Autenticação & Segurança:** JWT (JSON Web Tokens) com Refresh Tokens + BCrypt.Net
- **Validação:** FluentValidation
- **Logging Estruturado:** Serilog
- **Documentação:** OpenAPI / Swagger UI
- **Testes:** xUnit + FluentAssertions + Moq

---

## Arquitetura do Projeto

A solução foi estruturada em camadas independentes para desacoplar as regras de negócio de frameworks externos:

```text
src/
├── PersonalFinance.Domain/         # Entidades, Enums, Interfaces de domínio (Puro C#)
├── PersonalFinance.Application/    # Casos de uso, DTOs, Serviços e Validadores
├── PersonalFinance.Infrastructure/ # EF Core DbContext, Mappings, Migrations e Serviços Externos
└── PersonalFinance.Api/            # Controllers, Middlewares, Injeção de Dependências e Configurações

tests/
├── PersonalFinance.UnitTests/      # Testes unitários de domínio e casos de uso
└── PersonalFinance.IntegrationTests/ # Testes de integração de endpoints e banco
