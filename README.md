# Custom Dependency Injection Container Implementation

A C# console application demonstrating the implementation of a custom dependency injection container from scratch, inspired by Nick Chapsas's tutorial. This project serves as a learning exercise to understand the core concepts of dependency injection and IoC containers.

## Overview

This project implements a basic dependency injection container with support for two lifetime scopes:
1. Singleton - One instance is shared across the entire application
2. Transient - A new instance is created each time it's requested

## Features

- Custom DI container implementation
- Support for Singleton and Transient lifetimes
- Registration of services using fluent interface
- Service resolution with dependency graph handling
- Console-based demonstration

## Implementation Details

### Container Types

#### 1. Singleton Container
- Maintains a single instance of the registered service
- Instance is created on first resolution and cached
- Same instance is returned for subsequent requests

#### 2. Transient Container
- Creates a new instance each time a service is requested
- No instance caching
- Suitable for services that need a fresh instance every time

## Usage Example

```csharp
// Create Collection for Services
var services = new DiServiceCollection();

// Register services
services.RegisterSingleton<ISomeService, SomeServiceOne>();
services.RegisterTransient<IRandonGuidProvider, RandonGuidProvider>();

//Create Container
var container = services.GenerateContainer();

//Get Services
var serviceFirst = container.GetService<ISomeService>();
var serviceSecond = container.GetService<ISomeService>();
```

## Project Structure

```
DependencyInjectionFromScratch/
├── DependencyInjection/            # Core DI Implementation
│   ├── DiContainer.cs              # Main DI container implementation
│   ├── DiServiceCollection.cs      # Service collection for registration
│   ├── ServiceDescriptor.cs        # Service registration metadata
│   └── ServiceLifetime.cs          # Enum for service lifetime options
├── IRandomGuidProvider.cs          # Interface for GUID generation
├── ISomeService.cs                 # Example service interface
├── MainApp.cs                      # Application entry point
├── Program.cs                      # Program initialization
├── RandomGuidGenerator.cs          # GUID generator implementation
└── SomeServiceOne.cs              # Example service implementation
```

## Core Components
DependencyInjection Folder
1. DiContainer
The main container responsible for:

Service resolution
Instance creation
Lifetime management
Dependency graph resolution

2. DiServiceCollection
Handles service registration with support for:

Fluent registration syntax
Multiple lifetime scopes
Type mapping

3. ServiceDescriptor
Contains metadata for registered services:

Service type
Implementation type
Lifetime scope
Instance management

4. ServiceLifetime
Enumeration defining supported lifetimes:

Singleton (One instance for the entire application)
Transient (New instance per resolution)

## Learning Objectives

- Understanding dependency injection from the ground up
- Implementing different service lifetimes
- Managing service registration and resolution
- Handling dependency graphs
- Understanding IoC container internals

## Acknowledgments

This project was created following Nick Chapsas's tutorial as a learning exercise to gain deeper understanding of dependency injection concepts.

## Getting Started

1. Clone the repository
```bash
git clone https://github.com/yourusername/dependency-injection-implementation.git
```

2. Open the solution in Visual Studio or your preferred IDE

3. Build and run the console application

## Prerequisites

- .NET 7.0
- Visual Studio 2022 or any C# IDE

## Contributing

This is a learning project, but suggestions and improvements are welcome. Feel free to:
1. Fork the repository
2. Create a feature branch
3. Submit a pull request
