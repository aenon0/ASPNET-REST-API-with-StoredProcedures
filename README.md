## ASP.NET Web API CRUD Operations using SQL Server Stored Procedures


This repository contains a sample ASP.NET Web API project that demonstrates CRUD (Create, Read, Update, Delete) operations using SQL Server stored procedures. It is designed to showcase and document practices for building RESTful APIs with ASP.NET with a SQL Server database.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Setting Up the Database](#setting-up-the-database)
- [Running the Web API](#running-the-web-api)
- [Usage](#usage)
- [Contributing](#contributing)
- [Clarification](#clarification)

## Overview
-This project is a practical example of creating a RESTful API using ASP.NET Web API that performs CRUD operations by interfacing with a SQL Server database through stored procedures. It serves as a reference for developers looking to implement these functionalities in their own projects.
## Features
- **CRUD Operations:** Demonstrates the implementation of Create, Read, Update, and Delete operations for a specific data entity.
- **SQL Server Integration:** Utilizes stored procedures to interact with a SQL Server database, ensuring secure and efficient data manipulation.
- **Consistent RESTful API:** Adheres to RESTful API design principles for a predictable and user-friendly interface.
- **Error Handling:** Includes error handling and informative responses for a better user experience.
- **Documentation:** A detailed README and API documentation provide insights into project structure and endpoints.

## Prerequisites
Before you get started, ensure you have the following:
- **Visual Studio:** An environment for .NET development, including ASP.NET Web API.
- **SQL Server:** A running instance of SQL Server where you can create and manage a database.

## Setting Up the Database
1. Create a new database on your SQL Server instance.
2. Execute the the sql scripts located in the sqlScripts.txt file. You can use tools like SQL Server Management Studio or Azure Data Studio to execute these scripts.

## Running the Web API
1. Clone this repository to your local machine:
   git clone https://github.com/aenon0/ASP.NET-Web-API.git
2. Open the project in Visual Studio.
3. Update the connection string in the appsettings.json file with the connection details of your SQL Server.
4. Build and run the project in Visual Studio.


##Usage
Here are some common tasks you can perform with this API:
--Create a new record using a POST request.
--Retrieve records using GET requests.
--Update a record using a PUT request.
--Delete a record using a DELETE request.
--Contributing
--Contributions to this project are welcome. To contribute:

##Contribution
1. Fork the repository.
2. Create a new branch for your feature or fix: git checkout -b feature/your-feature-name.
3. Make your changes and commit them: git commit -m 'Add feature'.
4. Puh to the branch: git push origin feature/your-feature-name.
5. Create a pull request on GitHub.


##More Clarification
For more clarification on how it was built, use the following link:
--https://youtu.be/DboyInxNgXc

