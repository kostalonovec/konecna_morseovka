FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["konecna_morseovka/konecna_morseovka.csproj", "konecna_morseovka/"]
RUN dotnet restore "konecna_morseovka/konecna_morseovka.csproj"
COPY . .
WORKDIR "/src/konecna_morseovka"
RUN dotnet build "konecna_morseovka.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "konecna_morseovka.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "konecna_morseovka.dll"]
