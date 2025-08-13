# 🎬 Projeto CRUD de Filmes – ASP.NET Core MVC

Este projeto é um exemplo simples de aplicação web utilizando ASP.NET Core MVC. Ele implementa as operações básicas de **CRUD (Create, Read, Update, Delete)** para gerenciamento de filmes, com foco em aprendizado de demonstrar a estrutura básica de um projeto MVC.

## 🚀 Funcionalidades

- ✅ Cadastro de novos filmes
- 📄 Listagem de todos os filmes
- ✏️ Edição de dados de um filme
- ❌ Exclusão de filmes
- 🔍 Filtro de busca por título
- 🎭 Filtro por gênero

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core MVC (.NET 9)
- Razor Views
- Entity Framework Core
- SQL Server
- LINQ para consultas

## 🔧 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/Kytsu01/MVCMovies.git

2. Entre no Diretório onde você clonou o projeto utilizando o Git Bash ou o CMD com o Git instalado na sua máquina.

3. Execute os seguintes comandos:
    dotnet restore

    dotnet ef update database **(Caso de errado este comando siga o passo 3.1, depois execute esse comando novamente)**
        3.1 Execute o comando **dotnet tool install --global dotnet-ef** depois rode novamente o comando **dotnet ef update database**

   dotnet run

4. Abriu uma janela do terminal na sua máquina, veja qual é a porta sendo usado no localhost e pesquisa no google da sua máquina:
       **Imagem de demonstração:**
               <img width="643" height="162" alt="image" src="https://github.com/user-attachments/assets/350478d5-326f-4c2d-ba9c-fa79e3ed4c61" />

