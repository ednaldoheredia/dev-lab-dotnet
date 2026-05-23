FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Poc_01.csproj", ""]
RUN dotnet restore "Poc_01.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Poc_01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Poc_01.csproj" -c Release -o /app/publish

FROM base AS final

ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development  
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Poc_01.dll"]