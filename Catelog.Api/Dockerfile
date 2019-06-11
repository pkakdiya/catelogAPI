FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Catelog.Api/Catelog.Api.csproj Catelog.Api/
RUN dotnet restore Catelog.Api/Catelog.Api.csproj
COPY . .
WORKDIR /src/Catelog.Api
RUN dotnet build Catelog.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Catelog.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Catelog.Api.dll"]
