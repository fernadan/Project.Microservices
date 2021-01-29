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
**API: https://localhost/7100/api**
**Swagger: https://localhost/7100**

### Routes
**ShowMeTheCode: https://localhost/7100/api/showmethecode**
**CalculaJuros: https://localhost/7100/api/calculajuros**
**TaxaJuros: https://localhost/7100/api/taxajuros**

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
