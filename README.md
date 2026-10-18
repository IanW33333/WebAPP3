# WebAPP3

ASP.NET Core (.NET 8) Web API with Swagger, packaged as a self-contained app. No .NET install is needed.

## Download and install

Get the latest zip from [Releases](https://github.com/IanW33333/WebAPP3/releases/latest).

**Windows:** extract `WebAPP3-win-x64.zip`, then run `WebApplication3.exe`.

**Linux:** extract `WebAPP3-linux-x64.zip`, then run `chmod +x WebApplication3 && ./WebApplication3`.

The app listens on `http://localhost:5000` by default. To change the URL, run it with `--urls http://localhost:8080`. Swagger UI is at `/swagger` when `ASPNETCORE_ENVIRONMENT=Development`.

## Build from source

```
cd WebApplication3
dotnet run
dotnet publish -c Release -r win-x64 --self-contained true -o publish
```

## Docker

```
docker build -f WebApplication3/Dockerfile -t webapp3 .
docker run -p 8080:8080 webapp3
```
