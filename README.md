# Todo API Assignment

## Project Overview

This is a .NET 5 Web API project that implements a Todo application.

## Project Structure

```
TodoApp/
├── Controllers/v1/          # API Controllers (API endpoints)
├── Service/                 # Business logic layer
├── Domain/                  # Domain models and entities
├── Data/                    # Data access layer (Entity Framework)
└── Startup.cs              # Application configuration

TodoApp.Contracts/           # API contracts and DTOs
├── V1/
    ├── Requests/            # Request models
    ├── Responses/           # Response models
    └── AppRoutes.cs         # API route definitions

TodoApp.UnitTests/           # Unit test project
```

## Technology Stack

- **.NET 5.0** - Target framework
- **Entity Framework Core 5.0.17** - ORM with In-Memory database
- **AutoMapper 11.0.0** - Object-to-object mapping
- **Swashbuckle.AspNetCore 5.6.3** - Swagger/OpenAPI documentation
- **xUnit** - Unit testing framework
- **Moq** - Mocking framework for unit tests

## Setup Instructions

### Prerequisites
- .NET 5.0 SDK installed
- Visual Studio 2019/2022, VS Code, or Rider

### Running the Application
1. **Clone and navigate to the project directory**
   ```bash
   cd TodoApp
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Access the application**
   - API: `https://localhost:5001` or `http://localhost:5000`
   - Swagger UI: `https://localhost:5001/swagger` or `http://localhost:5000/swagger`

### Running Tests
```bash
cd TodoApp.UnitTests
dotnet test
```

## API Endpoints

### Required Endpoints to Implement

| GET | Get all todo items
| PUT | Update a todo item
| GET | Get a specific todo item 
| DELETE | Delete a todo item

## Expected HTTP Status Codes

### Create
- **Success**: `201 Created` - Todo item created successfully
- **Failure**: `400 Bad Request` - Invalid input data (e.g., missing name, empty name)

### Get All
- **Success**: `200 OK` - Returns list of all todo items
- **Failure**: `500 Internal Server Error` - Database or service error

### Get by ID
- **Success**: `200 OK` - Returns the requested todo item
- **Failure**: `404 Not Found` - Todo item with specified ID doesn't exist
- **Failure**: `400 Bad Request` - Invalid ID format (non-GUID)
- **Failure**: `500 Internal Server Error` - Database or service error

### Update
- **Success**: `200 OK` - Todo item updated successfully
- **Failure**: `404 Not Found` - Todo item with specified ID doesn't exist
- **Failure**: `400 Bad Request` - Invalid input data (e.g., missing name, empty name)
- **Failure**: `400 Bad Request` - Invalid ID format (non-GUID)
- **Failure**: `500 Internal Server Error` - Database or service error

### Delete
- **Success**: `204 No Content` - Todo item deleted successfully
- **Failure**: `404 Not Found` - Todo item with specified ID doesn't exist
- **Failure**: `400 Bad Request` - Invalid ID format (non-GUID)
- **Failure**: `500 Internal Server Error` - Database or service error

## Code Quality Requirements

### Controller Implementation
- Follow the existing pattern in `TodoController`
- Use proper HTTP status codes as specified above
- Implement proper error handling

### Error Handling
- Return `BadRequest(400)` for invalid input
- Return `NotFound(404)` for missing resources
- Return `InternalServerError(500)` for unexpected errors
- Return `Created(201)` for successful creation
- Return `NoContent(204)` for successful deletion

### Bonus Testing
- Add unit tests for new endpoints
- Test both success and failure scenarios
- Use proper mocking techniques
- Follow the existing test structure

Good luck with your implementation!
