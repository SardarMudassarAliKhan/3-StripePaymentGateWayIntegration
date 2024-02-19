#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["3-StripePaymentGateWayIntegration/3-StripePaymentGateWayIntegration.csproj", "3-StripePaymentGateWayIntegration/"]
RUN dotnet restore "./3-StripePaymentGateWayIntegration/3-StripePaymentGateWayIntegration.csproj"
COPY . .
WORKDIR "/src/3-StripePaymentGateWayIntegration"
RUN dotnet build "./3-StripePaymentGateWayIntegration.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./3-StripePaymentGateWayIntegration.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "3-StripePaymentGateWayIntegration.dll"]