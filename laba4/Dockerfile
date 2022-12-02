FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["laba4/laba4.csproj", "laba4/"]
RUN dotnet restore "laba4/laba4.csproj"
COPY . .
WORKDIR "/src/laba4"
RUN dotnet build "laba4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "laba4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "laba4.dll"]
