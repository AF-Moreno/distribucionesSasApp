# distribucionesSasApp

Este proyecto se desarrolla con el fin de construir un servicio web RESTfull API para la materia de  **Arquitectura de Software**.

## **Información General**
### Herramientas de desarrollo
* [ASP.NET](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-5.0)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [XUnit](https://xunit.net/)
* [Swagger](https://swagger.io/)
* [Dapper Micro ORM](https://dapper-tutorial.net/)
### Herramientas de infraestructura
* [Azure App Service](https://azure.microsoft.com/es-es/services/app-service/)
* [Azure SQL Database](https://azure.microsoft.com/es-es/services/sql-database/)
### Herramientas de administración de proyecto
* [Azure DevOps](https://azure.microsoft.com/es-es/services/devops/)
* [Azure Pipelines](https://azure.microsoft.com/es-es/services/devops/pipelines/)

## **Arquitectura de Software**
Prácticas de desarrollo implementadas:
* [SOLID](https://es.wikipedia.org/wiki/SOLID)
* [Patrón Diseño guiado por el dominio (DDD)](https://es.wikipedia.org/wiki/Dise%C3%B1o_guiado_por_el_dominio)
* [Patrón Repository](https://our-academy.org/posts/el-patron-repository:-implementacion-y-buenas-practicas)
* [Patrón de inyección de dependencias](https://es.wikipedia.org/wiki/Inyecci%C3%B3n_de_dependencias)
* [Unit Testing](https://es.wikipedia.org/wiki/Prueba_unitaria)
### **Paquetes**
Se implementa la arquitectura MVC segregado por las siguientes capas

**Poli.Arqsoftware.DistribucionesSasApp.Core**
* **Repository** 
  * Uso de Dapper como micro ORM para obtener datos de SQL Server 
  * Capa encargada del acceso a Datos (SQL Server, MemoryCache)
  * implementación del patrón repositorio
* **Domain (Service)**
  * Implementa la lógica de negocio segregado por Dominios (servicios)

**Poli.Arqsoftware.DistribucionesSasApp.Api**
* **Controller**
  *  Capa encargada de recibir todas las solicitudes **HTTP**

**Poli.Arqsoftware.DistribucionesSasApp.Test**
* **Unit**
  * Contenedor de las pruebas unitarias del sistema


## **Infraestructura y despliegue**
El proyecto se despliega utilizando diferentes servicios del portal de **Azure**
Se requiere tener una suscripción activa en el portal de **Azure**

### **Diagrama de despliegue**
![DeploymentDiagram](https://user-images.githubusercontent.com/35159383/116011481-008bed80-a5eb-11eb-881d-cf3653a76c8e.jpeg)

* **Azure Server**
  Servidores de azure que provee el uso de los siguientes servicios:
  * **Resource Group:**
  Administra todos los recursos y servicios de infraestructura de nuestra aplicación
    * **Web App Service:**
    Servicio que permite el despliegue del API service
    * **Azure SQL Data Base Server**
    Servidor que aloja la base de datos usada por el API Service

## **Características de la aplicación**
* Implementa **Swagger** el cual nos ofrece una interfaz grafica que permite el uso de los diferentes servicios directamente desde el **Navegador Web** https://poli-arqsoftware-app.azurewebsites.net/swagger/index.html
