# VTT .NET Core Api and React Frontend
## Created with

- Visual Studio
- Visual Code

## Getting Started

First clone down this repositoty to your local machine

`git clone https://github.com/ruzla/VTTDb.git`

## .Net Core Api

### Step 1
Open VTTDataApi.sln in Visual Studio. Located `VTTDb>VTTDataApi`

### Step 2
Check you have a local db named `(LocalDb)\\MSSQLLocalDB` on your localSQLServer:

In Visual Studio `View>SQL Server Object Explorer` check the SQL Server dropdown.

If it is present skip to the next step.

If you do not see (LocalDb)\\MSSQLLocalDB in the SQL Server list you will need to change the connection string server to a new one you create or change to an existing one in the SQL Server list.

### Step 3
Go to NuGet package manager console and run the following command

`update-database`

This will create the database and seed the data

### Step 4
Run the Solution

## React Frontend

### Step 1
From a terminal window navigate to `VTTDb>vtt-frontend`

### Step 2
Run command:

`npm install`

### Step 3
Run command:

`npm start`

You should now be able to view the contents of the database through your browser on http://localhost:3000/

The Api has 2 GET endpoints:

http://localhost:60734/api/vaultex/organisations

http://localhost:60734/api/vaultex/employees

