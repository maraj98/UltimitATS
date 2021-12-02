#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UsersAuthentication/UltimitAts.UsersAuthentication.csproj", "UsersAuthentication/"]
COPY ["UltimitAts.Infrastructure/UltimitAts.Infrastructure.csproj", "UltimitAts.Infrastructure/"]
COPY ["Data/UltimitAts.Data.csproj", "Data/"]
RUN dotnet restore "UsersAuthentication/UltimitAts.UsersAuthentication.csproj"
COPY . .
WORKDIR "/src/UsersAuthentication"
RUN dotnet build "UltimitAts.UsersAuthentication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UltimitAts.UsersAuthentication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UltimitAts.UsersAuthentication.dll"]
