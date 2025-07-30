# CallManagement
## Cài các gói NuGet

dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson

dotnet tool install --global dotnet-ef

## Chạy Migrations:

dotnet ef migrations add Init

dotnet ef database update

dotnet build

dotnet run
