FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Deedforge/Deedforge/Deedforge.csproj", "Deedforge/Deedforge/"]
COPY ["Deedforge.Domain/Deedforge.Domain.csproj", "Deedforge.Domain/"]
COPY ["Deedforge.Shared/Deedforge.Shared.csproj", "Deedforge.Shared/"]
COPY ["Deedforge/Deedforge.Client/Deedforge.Client.csproj", "Deedforge/Deedforge.Client/"]
RUN dotnet restore "./Deedforge/Deedforge/Deedforge.csproj"
COPY . .
WORKDIR "/src/Deedforge/Deedforge"
RUN dotnet build "./Deedforge.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./Deedforge.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Deedforge.dll"]