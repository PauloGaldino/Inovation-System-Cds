#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Organize_Cds_System.UI/Organize_Cds_System.UI.csproj", "src/Organize_Cds_System.UI/"]
RUN dotnet restore "src/Organize_Cds_System.UI/Organize_Cds_System.UI.csproj"
COPY . .
WORKDIR "/src/src/Organize_Cds_System.UI"
RUN dotnet build "Organize_Cds_System.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Organize_Cds_System.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Organize_Cds_System.UI.dll"]