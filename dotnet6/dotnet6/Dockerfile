FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["dotnet6/dotnet6.csproj", "dotnet6/"]
RUN dotnet restore "dotnet6/dotnet6.csproj"
COPY . .
WORKDIR "/src/dotnet6"
RUN dotnet build "dotnet6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dotnet6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dotnet6.dll"]
