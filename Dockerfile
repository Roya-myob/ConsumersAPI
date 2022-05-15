#Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source

# Copy csproj file and restore any dependecies via nuget
COPY . .
RUN dotnet publish "./ConsumersApi/Consumers.API.csproj" -c release -o /app

# Generate runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "Consumers.API.dll"]