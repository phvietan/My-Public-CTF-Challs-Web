# The builder image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder

WORKDIR /sln

# Just copy everything
COPY source .

# Do the restore/publish/build in one step
RUN dotnet publish -c Release -r linux-x64 -o /sln/artifacts -p:PublishTrimmed=True

# The deployment image
FROM mcr.microsoft.com/dotnet/runtime-deps:7.0

# Copy across the published app
WORKDIR /app
RUN useradd -ms /bin/bash user

COPY --chown=user:user --from=builder ./sln/artifacts .
USER user
ENTRYPOINT ["./Public-CTF-Web"]
