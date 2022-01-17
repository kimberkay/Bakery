# _Bakery_

#### By: _*Kim Brannian*_

#### _A back-end web application for using Identity for a Bakery._

## Technologies Used
* C#
* .NET
* ASP.NET Core MVC
* Razor
* NuGet
* _git_
* _GitHub_
* Entity Framework Core
* Pomelo
* MySql
* Identity



## Description
_A back-end web application for Pierre's vendors to track their orders._

## System Requirements
* Download and install [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
* Download and install [MySql](https://www.mysql.com/downloads/) and connect to your local server
* A text editor, such as [VS Code](https://code.visualstudio.com/)


## Setup/Installation Requirements
* Navigate to https://github.com/kimberkay/.Solution
* Click on the green "Code" button and copy the repository URL or click on the   
  copy button
* Open the terminal on your desktop
* Once in the terminal, use it to navigate to your desktop folder
* Once inside your desktop folder, use the command `git clone https://github/kimberkay/Bakery.git`
* After cloning the project, navigate into it using the command `cd Factory.Solution
* Create a .gitignore file in the root directory and add: 
  
  */obj/
  */bin/
  */appsettings.json

* Create an appsettings.json file in the root directory and add:

  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=yourfirstname_yourlastname;uid=root;pwd=[your-mysql-password];"
    }
  }

* Run the command `git init`
* Run the command `git add .gitignore`
* Run the command `cd Factory` to navigate the `Bakery.Solutions\Bakery` main project folder  
* Run the command `dotnet restore` to install project dependencies
* Run the command `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
* Run the command `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
* Run the command `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
* Run the command `dotnet tool install --global dotnet-ef --version 3.0.0`
* Run the command `dotnet ef database update`
* Run the command `dotnet run` to run the project in the browser

## Known Bugs
* _No known bugs_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Kim Brannian_