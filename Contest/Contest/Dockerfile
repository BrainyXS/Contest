FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Contest/Contest.csproj", "Contest/"]
RUN dotnet restore "Contest/Contest.csproj"
COPY . .
WORKDIR "/src/Contest"
RUN dotnet build "Contest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contest.dll"]
