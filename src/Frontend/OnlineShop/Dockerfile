FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Frontend/OnlineShop/OnlineShop.csproj", "Frontend/OnlineShop/"]
RUN dotnet restore "Frontend/OnlineShop/OnlineShop.csproj"
COPY . .
WORKDIR "/src/Frontend/OnlineShop"
RUN dotnet build "OnlineShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OnlineShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineShop.dll"]
