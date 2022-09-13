# RusLabTest

This simple project contains `Product` model and CRUD operations on it. Swagger documentation is supported.

## Run project

To run this project, you have to have access to postgresql database. You can run docker container on your host machine or use external database.
In `appsettings.json` change `ConnectionStrings` field like that:
```json
"ConnectionStrings": {
    "PostgreSQL": "Host=localhost;Port=5432;Database=ruslabtest;Username=user;Password=password;"
}
```

In future, Connection String can be moved to environment variables or to the `secrets.json` file.

Next step is to apply migrations. In Visual Studio console, it's
```console
PM> Update-Database
```

In other terminal, go to project folder and run
```console
$ dotnet ef database update
```

If everything is done correctly, migrations would be successfuly applied to your database and you are ready to start the project.

## Database-First approach

If you want to generate models from existing database, run next command in Visual Studio console
```console
PM> Scaffold-DbContext "Host=localhost;Port=5432;Database=ruslabtest;Username=user;Password=password;" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir ScaffoldedModels
```

and in other terminals (was not tested)
```console
$ dotnet ef dbcontext scaffold "Host=localhost;Port=5432;Database=ruslabtest;Username=user;Password=password;" Npgsql.EntityFrameworkCore.PostgreSQL --output-dir ScaffoldedModels
```

with your connection credentials 


