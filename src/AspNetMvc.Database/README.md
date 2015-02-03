Running the sample
------------------
Before you can run the sample, you need to create a database.

1. Open the Package Manager Console.
2. Enter the command `Update-Database`.

From scratch
------------
If you want to create your own project, you need the following steps to get your database up and running.

1. Open the Package Manager Console.
2. Enter the command `Install-Package EntityFramework`.
3. Create a class derived from `DbContext`.
4. Add a connection string to Web.config.
5. In the Package Manage Console, enter the command `Enable-Migrations`.
6. Open the file Migrations\Configuration.cs.
7. Change the line `AutomaticMigrationsEnabled = false;` to `AutomaticMigrationsEnabled = true;`.
8. In the Package Manager Console, enter the command `Update-Database`.