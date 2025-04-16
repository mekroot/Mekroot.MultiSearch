# Multi Search

Detta project använder följande tekniker:
* [.NET Core](https://www.microsoft.com/net/download) version 2.1
* [Angular CLI](https://cli.angular.io/) version 6.1.4.
## Installation

Om du inte har Angular-CLI installerat så kan du installer det med hjälp av `npm i -g @angular/cli`.

## Inställningar
Se till så att du har API nyckel ifrån Google och Bing. 
Ersätt dessa i `appsettings.json`:

         "GoogleApiKey": "DIN GOOGLE API NYCKEL",
         "GoogleCse": "DITT GOOGLE CUSTOM SEARCH ID",
 
         "BingAccessKey": "DIN BING SEARCH ACCESS NYCKEL",
         
     

## Köra programmet

1. Öppna kommando prompten (Windows) eller Terminalen (Mac/Linux)
2. Navigera dig till `\MultiSearch.Web`
3. Kör `ng build`
1. Öppna `MultiSearch.sln` i Visual Studio.
2. Bygg.
3. Navigera dig till `https://localhost:5001`
