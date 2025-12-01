# STEP 1 — Build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy everything
COPY . .

# Publish the project
RUN dotnet publish -c Release -o /app

# STEP 2 — Run the application
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

# Copy published output
COPY --from=build /app .

# Start your app
ENTRYPOINT ["dotnet", "final.dll"]
