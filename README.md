# AppLivros
Repositório de uma aplicação web desenvolvida para fins didáticos, com o objetivo de catalogar uma lista livros utilizando de recursos
para adicionar, pesquisar, atualizar e excluir registros em um banco de dados.
 
Projeto teve sua estrutura desenvolvida com base na documentação da Microsoft [Criar um aplicativo Web com o ASP.NET Core MVC](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/?view=aspnetcore-3.0).

# Especificações
- Visual Studio Code v1.43.0
- Microsoft SQL Server Management Studio versão 12.0.4100.1
- Linguagem C#
- ASP.NET Core MVC v3.1.102
- EntityFrameworkCore v3.1.2
- Code First Migrations
- Bootstrap v4.3.1
- Javascript

# Dependências
`> dotnet add package Microsoft.EntityFrameworkCore --version 3.1.2`

`> dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.2`

`> dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet --version 2.0.3`

`> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.2`

`> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.1.1`

`> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Tools --version 2.0.4`

# Comando de criação do projeto
`> dotnet new mvc -o ProjetoAppLivros --framework netcoreapp3.1`

# Comando de criação do controller Livros com scaffolding
`> dotnet aspnet-codegenerator controller -name LivrosController --model ProjetoAppLivros.Models.Livro --dataContext ProjetoAppLivros.Context.ProjetoAppLivrosDbContext --relativeFolderPath Controllers --useDefaultLayout`

# Migrations Utilizadas
`> dotnet ef migrations add MigracaoInicial`

`> dotnet ef database update`

# Screenshot
<html lang="pt-br">
<head>
</head>
<body>
	<img src="https://github.com/PauloAlves8039/AppLivros/blob/master/src/ProjetoAppLivros/wwwroot/images/screenshot.png" />
</body>
</html>

