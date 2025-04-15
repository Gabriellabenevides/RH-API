# RH API

Este projeto é uma API para gerenciar colaboradores e cargos em um sistema de Recursos Humanos. Ele foi desenvolvido utilizando .NET 9 e segue uma arquitetura baseada em camadas, com suporte a injeção de dependência, MediatR para manipulação de comandos e consultas, e Entity Framework para acesso ao banco de dados.

---

## Tecnologias Utilizadas

- **.NET 9**
- **Entity Framework Core**
- **MediatR**
- **MySQL** como banco de dados
- **ASP.NET Core** para construção da API
- **C# 13.0**

---

## Estrutura do Projeto

A estrutura do projeto segue uma abordagem modular e organizada:

### **Camadas Principais**
1. **RH.Domain**: Contém as entidades, interfaces e comandos que definem o domínio do sistema.
2. **RH.Application**: Contém os manipuladores de comandos e lógica de aplicação.
3. **RH.API**: Implementa os controladores e expõe os endpoints da API.
4. **RH.MySQL**: Implementa os repositórios e configurações do banco de dados.

---

## Endpoints Disponíveis

### **ColaboradorController**
- **POST /api/v1/Colaborador**
  - **Descrição**: Adiciona um novo colaborador ao sistema.
  - **Body**:
    

### **Migrações**
Para aplicar as migrações, execute os seguintes comandos no terminal:

Add-Migration (nome da migração)
Update-Database

---

## Iniciando o Ambiente com Docker

Antes de rodar o projeto, certifique-se de iniciar os serviços necessários utilizando o Docker. Execute o seguinte comando no terminal:
docker-compose up -d

---

## Estrutura de Classes e Principais Componentes

### **Entidades**
- **Colaborador**: Representa um colaborador no sistema.
- **Cargo**: Representa um cargo no sistema.

### **Comandos**
- **IncluirColaboradorCommand**: Comando para adicionar um novo colaborador.
- **IncluirCargoCommand**: Comando para adicionar um novo cargo.

### **Manipuladores**
- **IncluirColaboradorHandler**: Manipula a lógica de inclusão de colaboradores.
- **IncluirCargoHandler**: Manipula a lógica de inclusão de cargos.

---

## Contribuição

Contribuições são bem-vindas! Siga os passos abaixo para contribuir:
1. Faça um fork do repositório.
2. Crie uma branch para sua feature:
3. Abra o PR;
