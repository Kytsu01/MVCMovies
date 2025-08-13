# 🎬 Projeto CRUD de Filmes – ASP.NET Core MVC

Este projeto é um exemplo simples de aplicação web utilizando ASP.NET Core MVC. Ele implementa as operações básicas de **CRUD (Create, Read, Update, Delete)** para gerenciamento de filmes, com foco em aprendizado e demonstrar a estrutura básica de um projeto MVC.

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

1. Clone o repositório utilizando o prompt de comando com o Git e o .Net 9.0 instalado na sua máquina:
      ```bash
      git clone https://github.com/Kytsu01/MVCMovies.git

2. Entre no Diretório ".../MVCMovies/MVCMovies".

3. Execute o seguinte comando:

      ```bash   
      dotnet ef --version

  Caso funcione você deve ver algo como:

      Entity Framework Core .NET Command-line Tools
      9.0.8

  Caso não funcione, execute o seguinte comando:

      dotnet tool install --global dotnet -ef

4. Certo, com tudo configurado execute os seguintes comandos agora:

       dotnet restore
       dotnet ef database update
       dotnet run

6. Abriu uma janela do terminal na sua máquina, após isso pesquise o seguinte no seu navegador de preferência:

         http://localhost:5165

