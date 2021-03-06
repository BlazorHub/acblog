FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/AcBlog.Server.API/AcBlog.Server.API.csproj", "src/AcBlog.Server.API/"]
COPY ["src/AcBlog.Data.Repositories.FileSystem/AcBlog.Data.Repositories.FileSystem.csproj", "src/AcBlog.Data.Repositories.FileSystem/"]
COPY ["src/AcBlog.Data/AcBlog.Data.csproj", "src/AcBlog.Data/"]
COPY ["src/AcBlog.Data.Repositories.SQLServer/AcBlog.Data.Repositories.SQLServer.csproj", "src/AcBlog.Data.Repositories.SQLServer/"]
RUN dotnet restore "src/AcBlog.Server.API/AcBlog.Server.API.csproj"
COPY . .
WORKDIR "/src/src/AcBlog.Server.API"
RUN dotnet build "AcBlog.Server.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AcBlog.Server.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AcBlog.Server.API.dll"]