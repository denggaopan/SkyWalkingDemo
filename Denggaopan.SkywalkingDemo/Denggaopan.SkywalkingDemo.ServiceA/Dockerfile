#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Denggaopan.SkywalkingDemo.ServiceA/Denggaopan.SkywalkingDemo.ServiceA.csproj", "Denggaopan.SkywalkingDemo.ServiceA/"]
RUN dotnet restore "Denggaopan.SkywalkingDemo.ServiceA/Denggaopan.SkywalkingDemo.ServiceA.csproj"
COPY . .
WORKDIR "/src/Denggaopan.SkywalkingDemo.ServiceA"
RUN dotnet build "Denggaopan.SkywalkingDemo.ServiceA.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Denggaopan.SkywalkingDemo.ServiceA.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Denggaopan.SkywalkingDemo.ServiceA.dll"]