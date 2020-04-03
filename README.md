
# Pandemic API

#### An API that is able to track status of pandamic per country, 04.03.2020

#### By **Jiwon Han**

[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
![LastCommit](https://img.shields.io/github/last-commit/jiwon-seattle/VendorOrderTracker.Solution)
![Languages](https://img.shields.io/github/languages/top/jiwon-seattle/VendorOrderTracker.Solution)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---

## 1. Pandemic API

The API contains Country and Status with one to one relationship
- Country has CountryId, CountryName, Latitute, Longtitude
- Status has StatusId, CountryId, Cases(Count number for people who affected from pandemic), Confirmed for true or false, and Date

Improvement Opportunities:
- Used package Microsoft.EntityFrameworkCore.Proxies to enable lazy loading
- Stated addJason option in Startup.cs to ignore cycles that it finds in the object graph and to generate JSON response properly
- Used package Swashbuckle.AspNetCoredescribes for Swagger that describes the capabilities of the API and how to access it with HTTP

## 2. User Flow

1. A user is able to track pandemic per country
2. A user is able to track pandemic status of specific country
2. A user is utilize Pandemic API with full CRUD functionality   

Parking Lot:
- Overall cases for each country
- MVC implementation 
- Identity
- enhanced API authorizaiton

## 3. Development
### Tech stack:
+ [.NET CORE](https://dotnet.microsoft.com/download/dotnet-core/) for package management (represents for C#, Entity Framework and Razor) 
+ [MySQL](https://dev.mysql.com/downloads/file/?id=484919) 

### To run dev mode locally:
```bash
  $ git clone https://github.com/jiwon-seattle/Pandemic-Api.git
  $ cd Pandemic
  $ dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0
  $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0
  $ dotnet add package Microsoft.EntityFrameworkCore.Proxies
  $ dotnet add package --version 5.3.1 Swashbuckle.AspNetCore
  $ dotnet build
  $ dotnet ef migrations add MigrationName
  $ dotnet ef database update  
  # After successfull pkg installtion
  $ dotnet run
```
Now, it will automatically open http://localhost:5000 and API is available on [Postman](https://www.postman.com/) or [Swagger UI](localhost:5000/swagger)

You might encounter a MySql database related errors on initial loading since this application needs a specific data route to fetch data.

## 4. Known Bugs

There are no known bug at this moment

## 5. Support and contact details

Any feedback is appreciated! Please contact at email: jiwon1.han@gmail.com

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Jiwon Han_**
