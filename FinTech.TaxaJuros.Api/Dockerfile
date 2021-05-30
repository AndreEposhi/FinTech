FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

LABEL version="1.0.2" description="Aplicacao ASP .NET Core WebApi"

COPY dist /app

WORKDIR /app

EXPOSE 80/tcp

ENTRYPOINT ["dotnet","FinTech.TaxaJuros.Api.dll"]