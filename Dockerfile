# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./ ./
RUN dotnet restore !!!Fatigheter.sln!!!.sln

# Copy everything else and build
RUN dotnet publish -c Release -o out

# Run tests
# RUN dotnet test

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .ENTRYPOINT ["dotnet", "!!!namnet på din DLL fil!!!.dll"]
