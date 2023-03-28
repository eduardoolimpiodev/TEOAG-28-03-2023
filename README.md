# TEOAG - Test Eduardo Olimpio Auto Glass


-Add : global.json
(Command Line Interface - CLI 
-dotnet new globaljson)

Limpar certificado digital:
dotnet dev-certs https --clear

Criar certificado digital:
dotnet dev-certs https --trust

Contrato Swagger:
https://localhost:[port]/swagger/v1/swagger.json

Criação das migrations dentro da pasta Data:
dotnet ef migrations add Initial -o Data/Migrations

Criação do banco de dados:
dotnet ef database update

#DDD:

Criação de Migrations DDD:
dotnet ef migrations add Initial -p TEOAG.Data -s TEOAG.API

Update-Database DDD:
dotnet ef database update -s TEOAG.API
