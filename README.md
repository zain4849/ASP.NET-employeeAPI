# EmployeesAPI
# EmployeeAPI with ASP.NET, Docker Compose, SQL Server, and SwaggerUI.

## Overview
This project is a simple EmployeeAPI built with ASP.NET Core, utilizing Docker Compose to containerize the application along with a SQL Server database. SwaggerUI is integrated for easy API documentation and testing.

## Dependencies
- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

## Installation
1. Clone this repository to your local machine.
2. Navigate to the project directory.
3. Run `docker-compose up --build` to build and run the containers.
4. Once the containers are up and running, navigate to `https://localhost:8081` or `http://localhost:8080` in your web browser to access the API and SwaggerUI interface.

## Usage
- The API endpoints are documented using SwaggerUI, which can be accessed at `https://localhost:8081/swagger/index.html` or `http://localhost:8080/swagger/index.html`.
- Use the provided endpoints to perform CRUD operations on employee data.

## Docker Compose
- Docker Compose is used to define and run multi-container Docker applications. It simplifies the process of running the API and database together.
- The `docker-compose.yml` file contains configurations for both the API and SQL Server containers.

## Database Setup
- The SQL Server database is automatically initialized when the Docker containers are spun up.
- Database connection string: `Server=<server_name>;Database=<database_name>;User=<username>;Password=<strong_password>;MultipleActiveResultSets=true;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;`

## SwaggerUI
- SwaggerUI provides interactive API documentation and testing capabilities.
- Use SwaggerUI to explore available endpoints and test API requests.

## Contributing
Contributions are welcome! Please follow the [contribution guidelines](CONTRIBUTING.md) before submitting pull requests.

## License
This project is licensed under the [MIT License](LICENSE).
