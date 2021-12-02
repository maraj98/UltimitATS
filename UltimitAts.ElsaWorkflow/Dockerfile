#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["UltimitAts.ElsaWorkflow/UltimitAts.ElsaWorkflow.csproj", "UltimitAts.ElsaWorkflow/"]
RUN dotnet restore "UltimitAts.ElsaWorkflow/UltimitAts.ElsaWorkflow.csproj"
COPY . .
WORKDIR "/src/UltimitAts.ElsaWorkflow"
RUN dotnet build "UltimitAts.ElsaWorkflow.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UltimitAts.ElsaWorkflow.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UltimitAts.ElsaWorkflow.dll"]
