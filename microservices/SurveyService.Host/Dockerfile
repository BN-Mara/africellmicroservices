FROM mcr.microsoft.com/dotnet/aspnet:5.0.3-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0.3-buster-slim AS build
WORKDIR /src
COPY . .
WORKDIR /src/microservices/SurveyService.Host
RUN dotnet restore -nowarn:msb3202,nu1503
RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SurveyService.Host.dll"]
