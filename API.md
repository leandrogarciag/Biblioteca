# Biblioteca API

La Biblioteca API proporciona acceso a recursos de la biblioteca, incluyendo Autores y sus Libros.

## Tabla de Contenidos

- [Biblioteca API](#biblioteca-api)
  - [Tabla de Contenidos](#tabla-de-contenidos)
    - [Autores](#autores)
      - [Obtener todos los Autores](#obtener-todos-los-autores)
      - [Obtener un autor por ID](#obtener-un-autor-por-id)
      - [Agregar un nuevo autor](#agregar-un-nuevo-autor)
      - [Actualizar un autor existente](#actualizar-un-autor-existente)
      - [Eliminar un autor existente](#eliminar-un-autor-existente)
    - [Libros](#libros)
      - [Obtener todos los Libros](#obtener-todos-los-libros)
      - [Obtener un libro por ID](#obtener-un-libro-por-id)
      - [Agregar un nuevo libro](#agregar-un-nuevo-libro)
      - [Actualizar un libro existente](#actualizar-un-libro-existente)
      - [Eliminar un libro existente](#eliminar-un-libro-existente)
  
### Autores

#### Obtener todos los Autores

**GET** /api/Autores

Devuelve una lista de todos los Autores.

```json
[
    {
        "id": 1,
        "nombre": "Autor 1",
        "Libros": [
            {
                "id": 1,
                "titulo": "Libro 1",
                "descripcion": "Descripcion del libro 1",
                "autorId": 1
            },
            {
                "id": 2,
                "titulo": "Libro 2",
                "descripcion": "Descripcion del libro 2",
                "autorId": 1
            }
        ]
    },
    {
        "id": 2,
        "nombre": "Autor 2",
        "Libros": [
            {
                "id": 1,
                "titulo": "Libro 1",
                "descripcion": "Descripcion del libro 1",
                "autorId": 1
            },
            {
                "id": 2,
                "titulo": "Libro 2",
                "descripcion": "Descripcion del libro 2",
                "autorId": 1
            }
        ]
    },
    // ...
]
```

#### Obtener un autor por ID

Devuelve un autor específico por ID. **GET** /api/Autores/{id}

**Parámetros**
id: ID del autor.

Respuesta 200 OK

```json
{
    "id": 1,
    "nombre": "Autor 1",
    "Libros": [
        {
            "id": 1,
            "titulo": "Libro 1",
            "descripcion": "Descripcion del libro 1",
            "autorId": 1
        },
        {
            "id": 2,
            "titulo": "Libro 2",
            "descripcion": "Descripcion del libro 2",
            "autorId": 1
        }
    ]
}
```

404 Not Found

#### Agregar un nuevo autor

**POST** /api/Autores

Agrega un nuevo autor. Requiere un cuerpo de solicitud con el nombre del autor.

```json
{
  "nombre": "string",
  "fechaNacimiento": "2023-05-12T03:44:25.943Z"
}
```

Respuesta 201 OK

#### Actualizar un autor existente

**PUT** /api/Autores/{id}

Actualiza un autor existente. Requiere un cuerpo de solicitud con el nombre del autor.

id: ID del autor (debe coincidir con el id del cuerpo para validar) ej: 6

```json
{
  "id": 6,
  "nombre": "string",
  "fechaNacimiento": "2023-05-12T03:44:25.943Z"
}
```

Respuesta 204 Ok

#### Eliminar un autor existente

**DELTE** /api/Autores/{id}

Eliminar un autor existente. Requiere id del autor.

id: ID del autor 6

```json
{
  "id": 6,
  "nombre": "string",
  "fechaNacimiento": "2023-05-12T03:44:25.943Z"
}
```

Respuesta 204 Ok


### Libros

#### Obtener todos los Libros

**GET** /api/Libros

Devuelve una lista de todos los Libros.

```json
[
    {
        "id": 1,
        "nombre": "Autor 1",
        "Libros": [
            {
                "id": 1,
                "titulo": "Libro 1",
                "descripcion": "Descripcion del libro 1",
                "autorId": 1
            },
            {
                "id": 2,
                "titulo": "Libro 2",
                "descripcion": "Descripcion del libro 2",
                "autorId": 1
            }
        ]
    },
    {
        "id": 2,
        "nombre": "Autor 2",
        "Libros": [
            {
                "id": 1,
                "titulo": "Libro 1",
                "descripcion": "Descripcion del libro 1",
                "autorId": 1
            },
            {
                "id": 2,
                "titulo": "Libro 2",
                "descripcion": "Descripcion del libro 2",
                "autorId": 1
            }
        ]
    },
    // ...
]
```

#### Obtener un libro por ID

Devuelve un libro específico por ID. **GET** /api/Libros/{id}

**Parámetros**
id: ID del libro.

Respuesta 200 OK

```json
{
    "id": 1,
    "nombre": "Autor 1",
    "Libros": [
        {
            "id": 1,
            "titulo": "Libro 1",
            "descripcion": "Descripcion del libro 1",
            "autorId": 1
        },
        {
            "id": 2,
            "titulo": "Libro 2",
            "descripcion": "Descripcion del libro 2",
            "autorId": 1
        }
    ]
}
```

404 Not Found

#### Agregar un nuevo libro

**POST** /api/libro

Agrega un nuevo libro. Requiere un cuerpo de solicitud con el nombre del libro, fecha y id del autor.

```json
{
  "nombre": "string",
  "fechaNacimiento": "2023-05-12T03:44:25.943Z"
}
```

Respuesta 201 OK

#### Actualizar un libro existente

**PUT** /api/Libros/{id}

Actualiza un libro existente. Requiere un cuerpo de solicitud con el nombre del libro.

id: ID del libro (debe coincidir con el id del cuerpo para validar) ej: 6

```json
{
  "id": 6,
  "nombre": "string",
}
```

Respuesta 204 Ok

#### Eliminar un libro existente

**DELTE** /api/Libros/{id}

Eliminar un autor existente. Requiere id del libro.

id: ID del libeo 6

```json

```

Respuesta 204 Ok
