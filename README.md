# P1.PortfolioApp

A modern portfolio application built with .NET 10, featuring a Blazor Web UI and a RESTful API backend.

## Project Overview

**P1.PortfolioApp** is a multi-layered solution demonstrating best practices for building scalable web applications with .NET. The solution is organized into distinct projects, each with specific responsibilities:

### Projects

- **P1.PortfolioApp.UI** - Blazor Web application for the user interface
- **P1.PortfolioApp.API** - ASP.NET Core Web API with OpenAPI/Swagger support
- **P1.PortfolioApp.Core** - Core domain models and business logic
- **P1.PortfolioApp.Services** - Business services and application logic

## Technology Stack

- **.NET 10** - Latest long-term support framework
- **Blazor Web** - Interactive server-side UI framework
- **ASP.NET Core Web API** - RESTful API backend
- **C# 14** - Modern language features with nullable reference types enabled
- **Swagger/OpenAPI** - API documentation and testing

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) or later
- [Visual Studio 2026](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/yourusername/P1.PortfolioApp.git
cd P1.PortfolioApp
```

### Build the Solution

```bash
dotnet build
```

### Run the Application

**UI (Blazor Web):**
```bash
cd P1.PortfolioApp.UI
dotnet run
```

**API (ASP.NET Core):**
```bash
cd P1.PortfolioApp.API
dotnet run
```

Visit `https://localhost:5198` for the UI and `https://localhost:5201` for the API.

## Project Structure

```
P1.PortfolioApp/
├── P1.PortfolioApp.UI/              # Blazor Web UI
│   ├── Components/
│   ├── Pages/
│   └── Program.cs
├── P1.PortfolioApp.API/             # ASP.NET Core API
│   ├── Controllers/
│   ├── Program.cs
│   └── appsettings.json
├── P1.PortfolioApp.Core/            # Domain models
│   └── Entities/
├── P1.PortfolioApp.Services/        # Business services
│   └── Implementations/
└── README.md
```

## Development

### Code Style

This project follows C# coding conventions:
- Nullable reference types are enabled
- Implicit usings are enabled
- Async/await patterns are preferred for I/O operations

### Building & Testing

```bash
# Build all projects
dotnet build

# Run tests (if applicable)
dotnet test

# Clean build artifacts
dotnet clean
```

## Configuration

Configuration is managed through `appsettings.json` files in each project. Environment-specific settings can be provided through:
- `appsettings.{Environment}.json` files
- Environment variables
- Command-line arguments

## Contributing

1. Create a feature branch (`git checkout -b feature/amazing-feature`)
2. Commit your changes (`git commit -m 'Add amazing feature'`)
3. Push to the branch (`git push origin feature/amazing-feature`)
4. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Support

For issues and questions, please open an issue on the GitHub repository.
