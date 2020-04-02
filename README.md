<p align="center">
  <a href="https://code.visualstudio.com/"><img src="https://img.shields.io/badge/VSCode-v1.43-%2300BFFF"></a>
  <a href="https://docs.microsoft.com/pt-br/aspnet/core/mvc/overview?view=aspnetcore-3.1"><img     src="https://img.shields.io/badge/ASP.NET%20Core%20MVC-v3.1-blue"></a>
  <a https://docs.microsoft.com/pt-br/ef/core/"><img src="https://img.shields.io/badge/EntityFrameworkCore-v3.1-orange"></a>
  <a href="https://getbootstrap.com/docs/4.3/getting-started/introduction/"><img src="https://img.shields.io/badge/Bootstrap-v4.3.1-blueviolet"></a>
  <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads"><img src="https://img.shields.io/badge/SqlServer-v12.0-brightgreen"></a>
</p>

<h1 align="center">AppLivros</h1>

Repositório de uma aplicação web desenvolvida para fins didáticos, com o objetivo de catalogar uma lista livros utilizando de recursos
para adicionar, pesquisar, atualizar e excluir registros em um banco de dados.
 
Projeto teve sua estrutura desenvolvida com base na documentação da Microsoft [Criar um aplicativo Web com o ASP.NET Core MVC](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.0).

# Recursos Utilizados
- Visual Studio Code v1.43.0
- Microsoft SQL Server Management Studio versão 12.0.4100.1
- Linguagem C#
- ASP.NET Core MVC v3.1.102
- EntityFrameworkCore v3.1.2
- Code First Migrations
- Bootstrap v4.3.1
- Javascript

# Dependências
```
dotnet add package Microsoft.EntityFrameworkCore --version 3.1.2
```
```
dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.2
```
```
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.0.3
```
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.2
```
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.1.1
```
```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Tools --version 2.0.4
```
# Comandos usados no projeto

### Criando o projeto
```
dotnet new mvc -o ProjetoAppLivros --framework netcoreapp3.1
```

### Criação do controller Livros com scaffolding
```
dotnet aspnet-codegenerator controller -name LivrosController --model ProjetoAppLivros.Models.Livro --dataContext ProjetoAppLivros.Context.ProjetoAppLivrosDbContext --relativeFolderPath Controllers --useDefaultLayout
```

### Migrations Utilizadas
```
dotnet ef migrations add MigracaoInicial
```
```
dotnet ef database update
```
# Screenshot
![Screenshot](https://github.com/PauloAlves8039/AppLivros/blob/master/src/ProjetoAppLivros/wwwroot/images/screenshot.png)

