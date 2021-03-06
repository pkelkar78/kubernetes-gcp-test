#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["GCPTestWebAPI.csproj", "GCPTestWebAPI/"]
RUN dotnet restore "GCPTestWebAPI/GCPTestWebAPI.csproj"
WORKDIR "/src/GCPTestWebAPI"
COPY . .
RUN dotnet build "GCPTestWebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GCPTestWebAPI.csproj" -c Release -o /app/publish

FROM base AS final
ENV ASPNETCORE_URLS=http://*:${PORT}
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GCPTestWebAPI.dll"]
