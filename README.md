# WebAPP3

ASP.NET Core (.NET 8) Web API with Swagger, packaged as a self-contained app. No .NET install is needed.

## Download and install

Get the latest zip from [Releases](https://github.com/IanW33333/WebAPP3/releases/latest).

**Windows:** extract `WebAPP3-win-x64.zip`, then run `WebApplication3.exe`.

**Linux:** extract `WebAPP3-linux-x64.zip`, then run `chmod +x WebApplication3 && ./WebApplication3`.

**macOS (Intel):** extract `WebAPP3-macos-x64.zip`, then run `chmod +x WebApplication3 && ./WebApplication3`.

**macOS (Apple Silicon):** extract `WebAPP3-macos-arm64.zip`, then run `chmod +x WebApplication3 && ./WebApplication3`.

The app listens on `http://localhost:5000` by default. To change the URL, run it with `--urls http://localhost:8080`. Swagger UI is at `/swagger` when `ASPNETCORE_ENVIRONMENT=Development`.

macOS may block an unsigned downloaded executable. If Gatekeeper blocks it, review the macOS security prompt and only allow it if you trust the source.

## Automated builds and releases

GitHub Actions builds self-contained ZIP packages for Windows x64, Linux x64, macOS Intel (x64), and macOS Apple Silicon (arm64) on pushes to `main`/ `master`, pull requests, and manual runs. Build ZIPs are uploaded as workflow artifacts.

To publish all four packages as a GitHub Release, push a version tag beginning with `v`, for example:

```bash
git tag v1.0.0
git push origin v1.0.0
```

The release workflow attaches the four platform ZIPs to that tag's GitHub Release.

## Build from source

```bash
cd WebApplication3
dotnet run
dotnet publish -c Release -r win-x64 --self-contained true -o publish
```

## Docker

```bash
docker build -f WebApplication3/Dockerfile -t webapp3 .
docker run -p 8080:8080 webapp3
```
