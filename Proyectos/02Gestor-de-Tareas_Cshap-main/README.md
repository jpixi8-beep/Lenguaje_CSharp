Va, Lechugas 🌱⚡. Te dejo un **README.md completo y actualizado** para tu proyecto **Gestor de Tareas**, ya con las mejoras que implementamos (UI moderna, checklist interactivo, CRUD con SQLite, etc.). Lo puedes copiar directo a tu repo.

---

## 📄 README.md

```markdown
# Gestor de Tareas ✅

Aplicación de escritorio en **C# WinForms** con **SQLite** para gestionar tareas de manera sencilla y moderna.  
Forma parte de mi portafolio de proyectos, mostrando CRUD completo, UI personalizada y funcionalidades interactivas.

---

## 🚀 Características

- **CRUD completo**: Agregar, editar, eliminar tareas.
- **Persistencia en SQLite**: Base de datos `tasks.db` generada automáticamente.
- **UI moderna**:
  - Paleta de 3 tonos (oscuro, verde acento, texto blanco).
  - Botones grandes y verticales.
  - Distribución clara: inputs a la izquierda, lista de tareas a la derecha.
- **Checklist interactivo**:
  - Cada tarea aparece con un checkbox.
  - Al marcar/desmarcar, el estado se actualiza automáticamente en la base de datos.
- **Eliminación múltiple**: puedes seleccionar varias tareas y eliminarlas de golpe.
- **Responsivo al hover**: los ítems del listado cambian de color al pasar el mouse.

---

## 📂 Estructura del proyecto

```bash
GestorTareas/
│
├── Program.cs
├── TaskForm.cs
├── TaskForm.Designer.cs
├── GestorTareas.csproj
├── tasks.db   (se genera automáticamente)
├── README.md
└── LICENSE
```

---

## ⚙️ Requisitos

- .NET 9.0 (Windows Desktop)
- Paquete NuGet:  
  ```xml
  <PackageReference Include="Microsoft.Data.Sqlite" Version="9.0.0" />
  ```

Instalación:
```bash
dotnet restore
dotnet build
dotnet run
```

---

## 🖥️ Uso

1. Escribe el título y descripción de la tarea.  
2. Selecciona el estado inicial (Pendiente, En progreso, Completada).  
3. Usa los botones:
   - **➕ Agregar**: crea una nueva tarea.
   - **✏️ Editar**: modifica la tarea seleccionada.
   - **🗑️ Eliminar**: borra una o varias tareas seleccionadas.
4. Marca/desmarca tareas en el checklist para cambiar su estado automáticamente.

---

## 📜 Licencia

Este proyecto está bajo la licencia MIT.  
Puedes usarlo, modificarlo y compartirlo libremente, siempre dando crédito.

---

## ✨ Autor

Desarrollado por **Jorge "Lechugas"** 🌱⚡  
Ingeniero en Sistemas Computacionales, apasionado por la creación de herramientas modulares y proyectos con UI moderna.
```

---
