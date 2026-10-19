# AccountProvider — .NET 8 Azure Functions

An educational account service developed during my full-stack studies at EC Utbildning.

## Implementation

- .NET 8 isolated-worker Azure Functions (v4).
- HTTP functions for sign-up, sign-in, and verification.
- Function-level authorization on the HTTP entry points.
- A separate `Data/` project with Identity and Entity Framework Core dependencies.

## Structure

- `AccountProvider/Functions/`: `SignUp.cs`, `Signln.cs` (function name: `SignIn`), and `Verify.cs`.
- `AccountProvider/Program.cs`: worker startup.
- `AccountProvider/host.json`: Functions host settings.
- `Data/`: data access and shared persistence code.
- `AccountProvider.sln`: solution entry point.

## Local development

Install the .NET 8 SDK and Azure Functions Core Tools. Supply database and required service settings locally before starting the worker.

```bash
git clone https://github.com/Norman-Deen/AccountProvider.git
cd AccountProvider
dotnet restore AccountProvider.sln
cd AccountProvider
func start
```

Use the routes printed by the Functions host. Local and deployed authorization behavior depends on host configuration.

## Scope

This is a coursework snapshot, not a ready-to-deploy identity platform. Review configuration and authentication requirements before adapting it.

[Nour Altinawi — Nourtin](https://nourtin.com/) · [Current real-time 3D work](https://github.com/Norman-Deen)
