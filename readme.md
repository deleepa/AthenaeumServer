VS Code set up

Install the .NET Core SDK and runtime from the following location: https://dot.net/core
Version should be > 2.2

When opening the project, the IDE might ask to install some dependencies. Install them.

To run the project, use dotnet run qna-platform-server.csproj


EF Migrations and Database updates

This project follows the code-first approach in EF. When a model has been updated, a new migration can be created using:

dotnet ef migrations add <migration-name>

Update the database using:

dotnet ef database update
