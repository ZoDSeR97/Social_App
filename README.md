# Social_App
Making a social app 

## :interrobang: Why use this mixture of technology?
Main reason is to learn Next.js, Typescript, and practice ASP.Net

## :bar_chart: Performance Speculation
Probably much better off with either double down on Blazor Server App or Next.js as we won't have to deal with 2 programming languages for 1 project. 

Most cool 'thing' for web development are made in JS though and Blazor does not do a good job of keeping developers away from JS.

## :white_check_mark: Requirements
We are using MySQL in this journey
```bash
$ node --version
v18.16.0
$ dotnet --version
7.0.203
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
$ dotnet run
```

## :clown: Frontend
- Tailwind
- react-icons

## :space-invader: Backend
- ASP.Net
- Entity Framework
- MySQL