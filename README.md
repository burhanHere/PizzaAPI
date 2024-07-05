### README for PizzaAPI

# PizzaAPI

PizzaAPI is a simple RESTful API built with C# .NET Core that manages pizza data. The API provides endpoints to perform CRUD (Create, Read, Update, Delete) operations on a list of pizzas. This project does not use any external databases and instead uses a hardcoded list to store pizza data.

## Project Structure

```
PizzaAPI/
├── Controllers/
│   └── PizzaController.cs
├── Properties/
│   └── launchSettings.json
├── obj/
├── PizzaAPI.csproj
├── PizzaAPI.sln
├── Program.cs
├── appsettings.Development.json
└── appsettings.json
```

### Main Files

- **`Program.cs`**: Sets up the application, configures services, and starts the web host.
- **`PizzaController.cs`**: Defines the API endpoints for managing pizzas.
- **`appsettings.json` and `appsettings.Development.json`**: Configuration files for application settings.
- **`PizzaAPI.csproj`**: Project file defining the build configuration.
- **`launchSettings.json`**: Configuration for debugging and launching the application.

## Endpoints

The following endpoints are available in the Pizza API:

### GET /Pizza

Retrieves the list of all pizzas.

**Response**:
```json
[
  {
    "id": 1,
    "name": "Margherita",
    "isGlutenFree": false
  },
  ...
]
```

### GET /Pizza/id/{id}

Retrieves a pizza by its ID.

**Parameters**:
- `id`: The ID of the pizza to retrieve.

**Response**:
```json
{
  "id": 1,
  "name": "Margherita",
  "isGlutenFree": false
}
```

### POST /Pizza/name/{name}/isGlutenFree/{isGlutenFree}

Creates a new pizza.

**Parameters**:
- `name`: The name of the pizza.
- `isGlutenFree`: Whether the pizza is gluten-free.

**Response**:
```json
{
  "id": 2,
  "name": "Pepperoni",
  "isGlutenFree": true
}
```

### PUT /Pizza/id/{id}, name/{name}

Updates the name of an existing pizza.

**Parameters**:
- `id`: The ID of the pizza to update.
- `name`: The new name of the pizza.

**Response**:
```json
{
  "id": 1,
  "name": "UpdatedName",
  "isGlutenFree": false
}
```

### PUT /Pizza/id/{id}, isGlutenFree/{isGlutenFree}

Updates the gluten-free status of an existing pizza.

**Parameters**:
- `id`: The ID of the pizza to update.
- `isGlutenFree`: The new gluten-free status of the pizza.

**Response**:
```json
{
  "id": 1,
  "name": "Margherita",
  "isGlutenFree": true
}
```

### PUT /Pizza/id/{id}, name/{name}/isGlutenFree/{isGlutenFree}

Updates the name and gluten-free status of an existing pizza.

**Parameters**:
- `id`: The ID of the pizza to update.
- `name`: The new name of the pizza.
- `isGlutenFree`: The new gluten-free status of the pizza.

**Response**:
```json
{
  "id": 1,
  "name": "UpdatedName",
  "isGlutenFree": true
}
```

### DELETE /Pizza/id/{id}

Deletes a pizza by its ID.

**Parameters**:
- `id`: The ID of the pizza to delete.

**Response**:
- `204 No Content`

## Setup

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Running the Application

1. Clone the repository:
   ```sh
   git clone <repository-url>
   cd PizzaAPI
   ```

2. Restore the dependencies:
   ```sh
   dotnet restore
   ```

3. Build the project:
   ```sh
   dotnet build
   ```

4. Run the application:
   ```sh
   dotnet run
   ```

The API will be available at `https://localhost:5001` or `http://localhost:5000`.

### Testing the Endpoints

You can use tools like [Postman](https://www.postman.com/), Swagger or [curl](https://curl.se/) to test the API endpoints.
