# CallManagement

Backend: .NET (API) dựa trên kiến trúc Clean Architecture

## Cài các gói NuGet

dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson

dotnet tool install --global dotnet-ef

## Chạy Migrations:

dotnet ef migrations add Init

dotnet ef database update

dotnet build

dotnet ef migrations add Init --project CallManagement.Infrastructure --startup-project CallManagement.API --verbose

## Chạy ứng dụng

cd CallManagement.API

dotnet run
