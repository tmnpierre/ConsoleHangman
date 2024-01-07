# Utilisez l'image de base officielle .NET 6 SDK pour construire le projet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

# Copiez les fichiers csproj et restaurez les dépendances
COPY *.csproj ./
RUN dotnet restore

# Copiez tout le reste et construisez l'application
COPY . ./
RUN dotnet publish -c Release -o out

# Générez l'image runtime
FROM mcr.microsoft.com/dotnet/runtime:6.0

WORKDIR /app
COPY --from=build /app/out .

# Commande pour exécuter l'application
ENTRYPOINT ["dotnet", "ConsoleHangman.dll"]
