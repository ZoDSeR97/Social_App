# Social_App
Making a social app 

## :interrobang: Why use this mixture of technology?
Main reason is to learn Next.js, Typescript, and practice ASP.Net.

## 📉 Performance Speculation
Probably much better off with either double down on Blazor Server App or Next.js 13 as we won't have to deal with 2 programming languages for 1 project. 

Most cool 'things' for web development are made in JS though and Blazor(.Net7) does not do a good job at keeping developers away from JS atm.

## ☢️ Loosely connection
At the moment the backend connect to front end through ID generated from Clerk. 

This should be sufficient for now.

Supposely Back end and Front end need to connect through JWT but there are lack of official documentations on ASP.Net.

## :white_check_mark: Requirements
We are using MySQL in this journey
```bash
$ node --version
v18.18.0
$ dotnet --version
7.0.401
$ dotnet tool install --global dotnet-ef # This install entity framework globally
```

## :checkered_flag: How to run ##
Go to appsetting.json edit connection to your MySQL DB
```json
{  
    "Logging": {    
        "LogLevel": {      
            "Default": "Information",      
            "Microsoft.AspNetCore": "Warning"    
        }  
    },
    "AllowedHosts": "*",    
    "ConnectionStrings":    
    {        
        "DefaultConnection": "Server=localhost;port=3306;userid={yourID};password={yourPass};database={DBName};"    
    }
}
```
Now use these commands in terminal
```bash
$ cd folder_name # cd into folder directory where .cs files are
$ dotnet restore # Restore the dependencies and tools of a project
$ dotnet ef database update
$ dotnet run
```

## 🤡 Frontend
- Tailwindcss
- react-icons
- Clerk (Authentication)
- Uploadthing (File upload)

## 👾 Backend
- ASP.Net
- Entity Framework
- MySQL
