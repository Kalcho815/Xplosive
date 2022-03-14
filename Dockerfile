FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Xplosive/Xplosive.csproj", "Xplosive/"]
RUN dotnet restore "Xplosive/Xplosive.csproj"
COPY . .
WORKDIR "/src/Xplosive"
RUN dotnet build "Xplosive.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "Xplosive.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "Xplosive.dll" ]
