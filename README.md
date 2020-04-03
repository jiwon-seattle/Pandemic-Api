- [x] As a user, I want to GET and POST reviews about travel destinations.
- [x] As a user, I want to GET reviews by country or city.
- [x] As a user, I want to see the most popular travel destinations by number of reviews or by overall rating.
- [x] As a user, I want to PUT and DELETE reviews, but only if I wrote them. (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)
- [x] As a user, I want to look up random destinations just for fun.

# Pandemic API

#### An API that is able to track status of pandamic per country, 04.03.2020

#### By **Jiwon Han**

[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
![LastCommit](https://img.shields.io/github/last-commit/jiwon-seattle/VendorOrderTracker.Solution)
![Languages](https://img.shields.io/github/languages/top/jiwon-seattle/VendorOrderTracker.Solution)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## 1. User Flow

1. A user is able to track pandemic per country
2. A user is able to track pandemic status of specific country
2. A user is utilize Pandemic API with full CRUD functionality   

Parking Lot/Improvement Opportunities:
- MVC implementation 
- Identity
- enhanced API authorizaiton

## 2. Development
### Tech stack:
+ [.NET CORE](https://dotnet.microsoft.com/download/dotnet-core/) for package management (represents for C#, Entity Framework and Razor) 
+ [MySQL](https://dev.mysql.com/downloads/file/?id=484919) 

### To run dev mode locally:
```bash
  $ git clone https://github.com/jiwon-seattle/Kanban.Solution.git
  $ cd Pandemic
  $ dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0
  $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0
  $ dotnet add package Microsoft.EntityFrameworkCore.Proxies
  $ dotnet build
  $ dotnet ef migrations add MigrationName
  $ dotnet ef database update  
  # After successfull pkg installtion
  $ dotnet run
```
Now, it will automatically open http://localhost:5000 and API is available on Postman or Swagger

You might encounter a MySql database related errors on initial loading since this application needs a specific data route to fetch data.

## 3. Known Bugs

There are no known bug at this moment

## 4. Support and contact details

Any feedback is appreciated! Please contact at email: jiwon1.han@gmail.com

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Jiwon Han_**
