FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Fretefy.Test.WebApi/Fretefy.Test.WebApi.csproj", "Fretefy.Test.WebApi/"]
COPY ["Fretefy.Test.Domain/Fretefy.Test.Domain.csproj", "Fretefy.Test.Domain/"]
COPY ["Fretefy.Test.Infra/Fretefy.Test.Infra.csproj", "Fretefy.Test.Infra/"]
RUN dotnet restore "Fretefy.Test.WebApi/Fretefy.Test.WebApi.csproj"
COPY . .
WORKDIR "/src/Fretefy.Test.WebApi"
RUN dotnet build "Fretefy.Test.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Fretefy.Test.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
RUN mkdir -p /app/Data
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fretefy.Test.WebApi.dll"]
