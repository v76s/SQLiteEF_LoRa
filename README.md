# SQLiteEF_LoRa

Simple reminder demo for SQLite + EF.

Steps to run:
Hit F5 in Visual Studio 

Steps to reproduce:

- Add packages: 
  Microsoft.EntityFrameworkCore
  Microsoft.EntityFrameworkCore.Design
  Microsoft.EntityFrameworkCore.Sqlite

- Create model, corresponding controller. 
- Create DataContext and apply migrations to DB.
  dotnet ef migrations add <MigrationName>
  dotnet ef database update

- Add to appsettings.json : 
   "ConnectionStrings": {
    "DefaultConnection": "Data Source=LoRaSQLite.db"