#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Project.Microservices/Project.Microservices.csproj", "Project.Microservices/"]
COPY ["Docs/Docs.Swagger/Docs.Swagger.csproj", "Docs/Docs.Swagger/"]
RUN dotnet restore "Project.Microservices/Project.Microservices.csproj"
COPY . .
WORKDIR "/src/Project.Microservices"
RUN dotnet build "Project.Microservices.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project.Microservices.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project.Microservices.dll"]
