# Installing & updating EntityFramework Core

### Oficial documentation

*  Getting Started with EF Core
https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli

* Razor Pages with Entity Framework Core in ASP.NET Core - Tutorial 1 of 8
https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-3.0&tabs=visual-studio

* Configuring a DbContext
https://docs.microsoft.com/en-us/ef/core/miscellaneous/configuring-dbcontext

* Troubleshooting the dotnet ef command for EF Core Migrations
https://thedatafarm.com/data-access/no-executable-found-matching-command-dotnet-ef/

* Tutorial: Using the migrations feature - ASP.NET MVC with EF Core
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations?view=aspnetcore-3.0


dotnet tool install --global dotnet-ef
	
### Commands using Package Manager Console

* Install-Package Microsoft.EntityFrameworkCore.Sqlite
* Install-Package Microsoft.EntityFrameworkCore.Tools
* Install-Package Microsoft.EntityFrameworkCore.SqlServer
* Install-Package Microsoft.EntityFrameworkCore.Design
* Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
* Install-Package Microsoft.EntityFrameworkCore.SqlServer
* Install-Package Microsoft.Extensions.Logging.Debug 
* Install-Package Microsoft.EntityFrameworkCore.Tools.DotNet

* Add-Migration MigationName
* Remove-Migration MigationName
* Update-Database


## Others References

* How to: Add class diagrams to projects
https://docs.microsoft.com/en-us/visualstudio/ide/class-designer/how-to-add-class-diagrams-to-projects?view=vs-2019