FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /api

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./backend/api/api.csproj"
COPY . .
WORKDIR /src
RUN dotnet build "./backend/api/api.csproj" -c Release -o /api/build

FROM build AS publish
RUN dotnet publish "./backend/api/api.csproj" -c Release -o /api/publish

FROM base AS final
WORKDIR /api
COPY --from=publish /api/publish .
ENTRYPOINT ["dotnet", "api.dll"]