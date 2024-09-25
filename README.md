# BookstoreApp
## Overview

BookstoreApp is a comprehensive project developed as part of the ASP.NET Core Web API training conducted by Zafer Cömert at BTK Academy. The application allows users to browse, add, update, and delete books through a RESTful API. This project incorporates various key concepts learned during the course, such as:

    ASP.NET Core
    RESTful API design
    Dependency Injection
    Entity Framework Core (EF Core)
    Authentication and Authorization
    Unit testing

## Features

    Book Management: Users can perform CRUD (Create, Read, Update, Delete) operations on books.
    Author Management: Manage the list of authors associated with books.
    User Authentication: Secure user login and registration using JWT tokens.
    Paging and Filtering: Efficiently fetch data with support for pagination and filtering.
    Error Handling: Global error handling is implemented for better user experience.
    Unit Tests: Unit tests are implemented to ensure code quality and functionality.

## Technologies Used

    ASP.NET Core 6.0: A modern, cross-platform framework for building web APIs.
    Entity Framework Core (EF Core): For database management and interaction.
    SQL Server: The backend database for storing books and author data.
    AutoMapper: To map between domain models and DTOs (Data Transfer Objects).
    JWT (JSON Web Token): For secure authentication and authorization.
    Swagger: Integrated API documentation.

## Setup Instructions

To set up the project locally, follow these steps:

    Clone the Repository:
    git clone https://github.com/AhmetFarukTUNC/BOOKSTOREAPPWEBAPPWITHASP.NETCORE
    Navigate to the Project Directory:
    cd BOOKSTOREAPPWEBAPPWITHASP.NETCORE
    Restore the Dependencies:
    dotnet restore
    Update the appsettings.json File:

Configure the appsettings.json file to match your local environment. Specifically, update the connection string to point to your local SQL Server database:
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=BookstoreDb;Trusted_Connection=True;"
}
## Run the Migrations:

Apply the database migrations to create the necessary tables in your database:
dotnet ef database update
Run the Application:
Start the application by running:
dotnet run
The API will be available at http://localhost:5000.

## Swagger Documentation:

To access the API documentation, navigate to:
http://localhost:5000/swagger
## API Endpoints

Here are some of the key endpoints provided by the API:
Books

    GET /api/books – Get a list of all books.
    GET /api/books/{id} – Get details of a specific book.
    POST /api/books – Add a new book.
    PUT /api/books/{id} – Update an existing book.
    DELETE /api/books/{id} – Delete a book.

Authors

    GET /api/authors – Get a list of all authors.
    POST /api/authors – Add a new author.

Authentication

    POST /api/auth/login – User login with JWT authentication.
    POST /api/auth/register – User registration.

Testing

Unit tests have been written using xUnit and can be run using the following command:
dotnet test
## Future Improvements

    Add support for book reviews and ratings.
    Implement search functionality to search books by title or author.
    Improve frontend integration for better user experience.


 
