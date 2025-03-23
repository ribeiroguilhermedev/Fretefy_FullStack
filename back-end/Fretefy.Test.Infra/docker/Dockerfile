FROM mcr.microsoft.com/dotnet/sdk:3.1

# instala sqlite e ef
RUN apt-get update && apt-get install -y sqlite3 libsqlite3-dev
RUN dotnet tool install --global dotnet-ef --version 3.1.32

# add ef tools no path
ENV PATH="$PATH:/root/.dotnet/tools"

ENTRYPOINT ["tail", "-f", "/dev/null"]