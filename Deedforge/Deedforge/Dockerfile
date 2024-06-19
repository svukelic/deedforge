#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

WORKDIR /app
EXPOSE 8080
EXPOSE 8081
USER app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Deedforge/Deedforge/Deedforge.csproj", "Deedforge/Deedforge/"]
COPY ["Deedforge.Domain/Deedforge.Domain.csproj", "Deedforge.Domain/"]
COPY ["Deedforge.Shared/Deedforge.Shared.csproj", "Deedforge.Shared/"]
COPY ["Deedforge/Deedforge.Client/Deedforge.Client.csproj", "Deedforge/Deedforge.Client/"]
RUN dotnet restore "./Deedforge/Deedforge/Deedforge.csproj"
COPY . .
WORKDIR "/src/Deedforge/Deedforge"
RUN dotnet build "./Deedforge.csproj"

FROM build AS publish
RUN dotnet publish "./Deedforge.csproj" /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /publish .
ENTRYPOINT ["dotnet", "Deedforge.dll"]