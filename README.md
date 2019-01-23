# dotnetcorestore
Functional store with user authentification and admin interface management.

// Environment

MacOs Mojave 10.14.2
VS Code 1.30, Docker 17.12.0-ce (SQL Server 2017), Npm 6.5.0, Azure Data Studio
ASP.NET Core 2.2.0 (Razor Pages), EntityFrameworkCore

// Commands : CLI .NET Core, Docker, Npm

dotnet new mvc 
dotnet restore
dotnet run

// Codefirst approach, create file: Models/Paiement.cs

dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet restore
dotnet run

// Entity Framework Core design tools

dotnet add package Microsoft.EntityframeworkCore.Design

dotnet aspnet-codegenerator controller -name PaiementController -m Paiement -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

// Initial database migration

docker run -d --name container_test -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=P@55w0rd' -e 'MSSQL_PID=Developer' -p 1433:1433 microsoft/mssql-server-linux:2017-latest

dotnet ef migrations add InitialCreate
dotnet ef database update

// Commandes SQL (facultatif)

npm install -g sql-cli 
mssql -u sa -p P@55w0rd 
EXEC sp_databases

//// Credentials

docker : container_test 
user : sa
mdp : P@55w0rd
db : main_db
table : paiement