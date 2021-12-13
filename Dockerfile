FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY ["NuGet.Config", ""]
COPY ["License.config", ""]

COPY ["Cms.Core/Cms.Core.csproj", "Cms.Core/"]
RUN dotnet restore "Cms.Core/Cms.Core.csproj"

COPY ["Cms/Cms.csproj", "Cms/"]
RUN dotnet restore "Cms/Cms.csproj"

COPY . .
RUN dotnet publish "Cms/Cms.csproj" -c Release  -o /app/out 

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_ENVIRONMENT Docker
ENV ASPNETCORE_URLS=http://+:80

COPY --from=build /app/out .

COPY ["License.config", "/app"]

ENTRYPOINT ["dotnet", "Cms.dll"]
