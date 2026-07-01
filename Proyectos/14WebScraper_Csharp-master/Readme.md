
# 📌 Proyecto 14 – Web Scraper

## 🚀 Descripción

Aplicación en **C# con .NET 9** que realiza **scraping de datos públicos** desde una web y los guarda en una base de datos SQLite.  
Permite visualizar los resultados en una interfaz web y aplicar filtros básicos.
El objetivo es mostrar cómo automatizar la recolección de información y procesarla para análisis.

---

### 🏗️ Arquitectura

- **ASP.NET Core MVC** → interfaz para visualizar los datos recolectados.  
- **HttpClient + HtmlAgilityPack** → librerías para scraping.  
- **Entity Framework Core (SQLite)** → almacenamiento de resultados.  
- **Services Layer** → lógica de scraping encapsulada.  

---

### 📂 Estructura del proyecto

```cmd
14.WebScraper_Csharp/
 ├── Controllers/
 │    └── ScraperController.cs
 ├── Data/
 │    └── AppDbContext.cs
 ├── Models/
 │    └── Registro.cs
 ├── Services/
 │    └── ScraperService.cs
 ├── Views/
 │    └── Scraper/
 │         ├── Index.cshtml
 │         └── Resultados.cshtml
 ├── Program.cs
 ├── appsettings.json
 └── WebScraper.csproj
```

## 🚀 Tecnologías

- **.NET 9.0**
- **ASP.NET Core MVC**
- **Entity Framework Core (SQLite)**
- **HtmlAgilityPack** para scraping
- **LINQ** para consultas

---

## 📂 Estructura

Ver carpeta principal del proyecto.

---

## 📌 Uso

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/LechuDev/14.WebScraper_Csharp.git
   cd 14.WebScraper_Csharp
   ```

2. Restaurar dependencias:

   ```bash
   dotnet restore
   ```

3. Crear base de datos:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. Ejecutar:

   ```bash
   dotnet run
   ```

---

## 🔮 Futuras mejoras

- Captura de imágenes además de texto.  
- Filtros de búsqueda en los resultados.  
- Ordenamiento dinámico por fecha, relevancia o categoría.  
- Scraping programado con tareas automáticas.  

---

## 🌐 Portfolio

👉 [Volver al Portfolio](https://lechudev.github.io/Porfolio)
