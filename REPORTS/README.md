# Hatid-Agad System

Hatid-Agad is a student registration and login system.

## Database Setup Instructions
Since this project uses a SQL Server database, you must set it up on your local machine to run the application:

1. **Open SQL Server Management Studio (SSMS)**.
2. **Execute the Script**: Locate the `Database_Script.sql` file in the project's `DATABASE` folder. Open and execute this script in SSMS to create the `HatidDB` database structure.
3. **Configure Connection**: Open the `App.config` file located in the project directory.
4. **Update Connection String**: Update the connection string to point to your local SQL Server instance. Replace the existing connection string with the following:

   <add name="HatidDBConn" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=HatidDB;Integrated Security=True" />

## Troubleshooting
If you encounter a "database not found" error, ensure that:
* The SQL Server instance is running.
* You have successfully executed the `Database_Script.sql` file.
* The connection string in `App.config` matches your SQL Server instance name (e.g., `.\SQLEXPRESS` or `(localdb)\MSSQLLocalDB`).

If you encounter Error MSB3030 when building the project, it means Visual Studio is trying to locate a missing database file. To fix this:

Open the Solution Explorer in Visual Studio.

Locate HatidDB.mdf (it may have a warning icon).

Right-click the file and select Exclude from Project.

Click Build > Rebuild Solution to resolve the error.
