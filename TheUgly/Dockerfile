FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /Docker

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /Docker
COPY --from=build-env /Docker/out .
ENTRYPOINT ["dotnet", "TheUgly.dll"]