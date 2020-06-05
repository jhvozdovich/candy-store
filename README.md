# **Honeydukes**

### _Advanced Databases and Authentication - Week 12 Project at Epicodus_

#### Author: **_Jessica Hvozdovich_**
#### June 5, 2020

<!-- ![Site Screenshot](./Honeydukes/wwwroot/img/readmescreenshot.jpg) -->

### Description

_This application takes user input to display different Flavors and Treats available at a candy store. The purpose of this project is to create a C# web application that employs a database with a many-to-many relationship using MySQL and Entity Framework. Identity is also used to support user authentication and authorization. It also demonstrates the use of MVC routes that follow RESTful conventions for full CRUD functionality._

### Instructions for use:

1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project Flavory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/jhvozdovich/candy-store.git
cd candy-store (or the file name you created for the main Flavory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project Flavory you can open all of the files with the command:
```
code .
```
4. Create a file within the Honeydukes folder named appsettings.json.
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=candy-store;uid=root;pwd=YOURMYSQLPASSWORDHERE;"
  }
}
```
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

6. To install the necessary dependencies and start a local host, after replicating the database steps below run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:

<!-- ```
CREATE DATABASE `blockbuster`;

USE `blockbuster`;
w
CREATE TABLE `Treats` (
  `TreatId` int(11) NOT NULL AUTO_INCREMENT,
  `FlavorId` int(11) NOT NULL DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  `RegularTreat` tinyint(4) DEFAULT '0',
  `Usual` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TreatId`)
);

CREATE TABLE  Flavors` (
  `FlavorId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`FlavorId`)
);

``` -->
<!-- REPLACE WITH CORRECT COMMANDS -->

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.
Passwords requirements are currently reduced for testing.

### Support and Contact Information

Please contact me with any suggestions or questions at jhvozdovich@gmail.com. Thank you for your input!  
_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/candy-store/issues) here on GitHub._

### Technologies Used

* C#
* `ASP.NET` Core
* `ASP.NET` Core MVC
* Entity Framework Core
* `ASP.NET` Core Identity
* MySQL
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can navigate to a page that lists Flavors** | User Input:"Click: View Flavors" | Output: “Fruitti, Cherry, Earwax” |
| **If no Flavors have been added a message appears** | User Input:"Click: View Flavors" | Output: “You have no Flavors listed! Accio Flavors!” |
| **User can navigate to an add Flavors page** | User Input:"Click: Accio Flavor" | Output: “Create a new Flavor.” |
| **User can fill out the Add Flavors form** | User Input:"Enter New Flavor Name: Lemon" | Output:  Flavors: Fruitti, Cherry, Earwax, Lemon” |
| **User can click on Flavors to view the Treats available with that Flavor** | User Input:"Click: Earwax" | Output: “Treats: Bertie Bott's Every Flavour Beans” |
| **If no Treats have been added a message appears** | User Input:"Click: View Treats" | Output: “You have no Treats listed. Accio Treats!” |
| **User can navigate to a create new Treat with a form** | User Input:"Click: Accio Treat" | Output: “Treat Form" |
| **User can add a new Treat linked to a Flavor** | User Input:"Treat Name: Fizzing Whizzbees, Vendor: Trolley, Flavor: Sherbert, Price: 2 Sickles" | Output: “Sherbert Treats: Bertie Bott's Every Flavour Beans, Fizzing Whizzbees” |
| **User can view Treat details when clicked** | User Input:"Click: Fizzing Whizzbees" | Output: “Treat Details: "Name: Fizzing Whizzbees, Vendor: Trolley, Flavor: Sherbert, Price: 2 Sickles” |
| **User can delete a Flavor** | User Input:"Click: Reducto!" | Output: “You have removed this Flavor!” |
| **User can delete a Treat** | User Input:"Click: Reducto!" | Output: “You have removed this Treat!” |
| **User can fill out registration information** | User Input:"Username: hpotter Name: Harry Password: 3Xp3LL1@rmu5" | Output: “Welcome Harry” |

### Stretch Goals
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Patron class without editing permission** | User Input:"Click: View Flavors" | Output: “Create/Delete/Update buttons not displayed” |
| **Patron can register** | User Input:"Click: Register" | Output: “Registration form - Patron” |
| **Patron can fill out registration information** | User Input:"Username: hpotter Name: Harry Password: 3Xp3LL1@rmu5" | Output: “Welcome Harry” |
| **Admin can fill out registration information** | User Input:"Username: aFlume Name: Ambrosius Password: LemonDr0p!" | Output: “Welcome Ambrosius” |
| **Patron can purchase a treat** | User Input:"Treat: Chocolate Frogs" | Output: “That will be 3 Sickles!” |
| **Purchase Treat options are only available to signed in Patrons** | User Input:"Click: purchase a treats" | Output: “You must make an account!” |


### Resources
(Background Image)[LINK HERE]

#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Jessica Hvozdovich_**
