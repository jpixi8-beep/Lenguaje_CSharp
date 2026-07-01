
# ProductAPI 🚀

API RESTful para gestión de productos, construida con **ASP.NET Core 9**, **Entity Framework Core** y **SQLite**.  
Documentada con **Swagger** para pruebas interactivas.

## 📦 Instalación de paquetes

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.0
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.0
dotnet add package Swashbuckle.AspNetCore --version 6.5.0
```

## ⚙️ Migraciones

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## ▶️ Ejecución

```bash
dotnet run
```

La API estará disponible en:

- `http://localhost:5140/swagger`

## 📌 Endpoints principales

- `GET /api/Products` → Lista todos los productos.  
- `GET /api/Products/{id}` → Obtiene un producto por ID.  
- `POST /api/Products` → Crea un nuevo producto.  
- `PUT /api/Products/{id}` → Actualiza un producto existente.  
- `DELETE /api/Products/{id}` → Elimina un producto.

## 📌 Ejemplo de request (POST)

```json
{
  "name": "Laptop Gamer",
  "price": 25000,
  "stock": 5
}
```

## 📌 Ejemplo de response (DELETE)

```json
{
  "mensaje": "Producto eliminado con éxito",
  "producto": {
    "id": 1,
    "name": "Laptop Gamer",
    "price": 25000,
    "stock": 5
  }
}
```
