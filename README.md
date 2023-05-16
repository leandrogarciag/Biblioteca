# Documentación para correr el proyecto

El proyecto Biblioteca API es una implementación de backend para una biblioteca. Permite a los usuarios interactuar con un conjunto de datos de libros y autores a través de una API RESTful. El objetivo de este proyecto es proporcionar una interfaz sencilla y eficiente para administrar los recursos de la biblioteca.

### Características
Las características clave de la API de la Biblioteca incluyen:

- Gestión de Autores: La API permite a los usuarios agregar, actualizar, recuperar y eliminar autores. Cada autor tiene asociado un conjunto de libros.

- Gestión de Libros: Los usuarios pueden agregar, actualizar, recuperar y eliminar libros. Cada libro está asociado con un autor.

- Arquitectura limpia: El proyecto sigue una arquitectura de software limpia, con responsabilidades claramente definidas entre las diferentes capas de la aplicación. Esto facilita la mantenibilidad y escalabilidad del código.


- Base de datos relacional: El proyecto utiliza SQL Server como sistema de base de datos relacional para almacenar la información de los autores y los libros.

- ORM - Entity Framework: Para interactuar con la base de datos, el proyecto usa Entity Framework Core, un ORM (Object-Relational Mapper) popular y potente que facilita el trabajo con datos relacionales.

- Automapper: Se utiliza Automapper para mapear entre entidades y DTOs, lo que simplifica el código y evita errores manuales en el mapeo de datos.

- Documentación: El proyecto incluye una documentación detallada de la API, que facilita su uso a los desarrolladores y usuarios finales.
## Requisitos previos
Para ejecutar este proyecto, debes tener instalado lo siguiente en tu máquina:

- .NET 7.0 SDK
- SQL Server
- Git

## Pasos para ejecutar el proyecto

1. Clonar el repositorio

Primero, necesitas clonar el repositorio en tu máquina local. Puedes hacerlo ejecutando el siguiente comando en tu terminal:

git clone <https://github.com/leandrogarciag/Biblioteca.git>

2. Restaurar los paquetes NuGet

Navega hasta el directorio del proyecto clonado y ejecuta el siguiente comando para restaurar los paquetes NuGet:

```sh
dotnet restore
```

3. Antes de ejecutar la aplicación, debemos compilarla para verificar que no hay errores de compilación

```sh
dotnet build
```

4. Configurar la cadena de conexión de la base de datos

Abre el archivo appsettings.json y configura la cadena de conexión a tu instancia de SQL Server en la propiedad ConnectionString.

Ejemplo:

```sh
"ConnectionString": "Server=(localdb)\\mssqllocaldb;Database=BibliotecaDB;Trusted_Connection=True;"
```

5. Aplicar las migraciones de Entity Framework

Ejecuta el siguiente comando para aplicar las migraciones de Entity Framework y crear la base de datos:

```sh
dotnet ef database update --project .\Biblioteca.Infrastructure\Biblioteca.Infrastructure.csproj
```

6. Ejecutar el proyecto

Finalmente, puedes ejecutar el proyecto usando el siguiente comando en la raiz del proyecto:

```sh
dotnet run --project .\Biblioteca.API\
```

7. Visualizar funcionamiento

Para visualizar el funcionamiento de la API leer el "API.MD":

