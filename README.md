# JobBoard
Project JobBoard. Learning project to apply RESTful best practices (HATEOAS, Richardson level3)

# How to create a Docker image containing a SQL Server instance?
## Prequisites:
    Have Docker up and running. Install from Docker, the Docker desktop application for example.
- insde powershell run: docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=your_strong_password_here' -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2022-latest
This will create an image inside Docker.

# Packages installation
    -   dotnet add package microsoft.entityframeworkcore --version 8.0.0   
    -   dotnet add package microsoft.entityframeworkcore.tools --version 8.0.0
    -   dotnet add package microsoft.entityframeworkcore.sqlserver --version 8.0.0
    
# Database context
    - Create the appropiate Entity classes.
    For now add this to appsettings.json
     "ConnectionStrings": {
    "JobBoardContext": "Server=localhost,1433;Database=JobBoard;Initial Catalog=JobBoard;User Id=sa;Password=your_strong_password;Persist Security Info=False;Encrypt=False"
  }
## Using the JobBoardContext
    - create an initial migration: dotnet ef migrations add InitialCreate
    - persist the initial migration to the database: dotnet ef database update InitialCreate  

# Swagger
@see https://aka.ms/aspnetcore/swashbuckle
## Powershell 
    -   dotnet add package Swashbuckle.AspNetCore -v 6.6.2

# JSonPatch
    -   dotnet add package microsoft.aspnetcore.jsonpatch -v 8.0.0
    -   dotnet add package microsoft.aspnetcore.mvc.newtonsoftjson -v 8.0.0

