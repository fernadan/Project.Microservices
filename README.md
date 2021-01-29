# Project.Microservices
> Application over the microservices architerure, working with ASP.NET Core.

Used tecnologies
* ASP.NET Code (.NET 5)
* Ocelot (v. 17.0.0)
* Unit tests (xUnit)
* Integration test
* Docker / Docker Compose
* Swagger - NSwag (v. 13.10.1)

## API Gateway

**Host: https://localhost/7100**
**Swagger: https://localhost/7100**

### Routes
**ShowMeTheCode: https://localhost/7100/showmethecode**
**CalculaJuros: https://localhost/7100/calculajuros?valorinicial=100&meses=5**
**TaxaJuros: https://localhost/7100/taxajuros**

## API TaxaJuros

**Host: https://localhost/7101**
**Swagger: https://localhost/7101**

### Endpoints
**ShowMeTheCode: https://localhost/7101/showmethecode**
**CalculaJuros: https://localhost/7101/calculajuros**

## API CalculaJuros

**Host: https://localhost/7102**
**Swagger: https://localhost/7102**

### Endpoints
**TaxaJuros: https://localhost/7102/taxajuros**


## ISSUES
### SSL Test Problem
**Error with calling docker container by ocelot

## Futures Features
### Using HttpClient to call services
### Using messeges to communicate each other
### Transforms API return into JSON
###	Change the swagger descriptions
### Use integration testing
