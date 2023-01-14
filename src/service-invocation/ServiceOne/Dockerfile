#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /
COPY ["src/service-invocation/ServiceOne/ServiceOne.csproj", "service-invocation/ServiceOne/"]
COPY ["src/service-invocation/Common/Common.csproj", "service-invocation/Common/"]
RUN dotnet restore "service-invocation/ServiceOne/ServiceOne.csproj"
COPY . .
WORKDIR "/src/service-invocation/ServiceOne"
RUN dotnet build "ServiceOne.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceOne.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "ServiceOne.dll"]
