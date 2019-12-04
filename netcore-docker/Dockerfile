FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["netcore-docker/netcore-docker.csproj", "netcore-docker/"]
RUN dotnet restore "netcore-docker/netcore-docker.csproj"
COPY . .
WORKDIR "/src/netcore-docker"
RUN dotnet build "netcore-docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "netcore-docker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "netcore-docker.dll"]