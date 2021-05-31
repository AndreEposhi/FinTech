#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["FinTech.TaxaJuros.Api/FinTech.TaxaJuros.Api.csproj", "FinTech.TaxaJuros.Api/"]
RUN dotnet restore "FinTech.TaxaJuros.Api/FinTech.TaxaJuros.Api.csproj"
COPY . .
WORKDIR "/src/FinTech.TaxaJuros.Api"
RUN dotnet build "FinTech.TaxaJuros.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FinTech.TaxaJuros.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinTech.TaxaJuros.Api.dll"]