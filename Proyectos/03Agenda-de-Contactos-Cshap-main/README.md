
# Agenda de Contactos 📒

Aplicación de escritorio en **C# WinForms** con **SQLite** para gestionar contactos de manera sencilla y moderna.  
Forma parte de mi portafolio de proyectos, mostrando CRUD completo, validaciones, exportación CSV y UI personalizada.

---

## 🚀 Características

- **CRUD completo**: Agregar, editar, eliminar contactos.  
- **Validaciones**:
  - Teléfono solo acepta números (7–15 dígitos).  
  - Email validado con formato correcto.  
- **Persistencia en SQLite**: Base de datos `contacts.db` generada automáticamente.  
- **UI moderna**:
  - Paleta de 3 tonos (oscuro, verde acento, texto blanco).  
  - Botones grandes y verticales.  
  - Lista interactiva sensible al hover.  
- **Visualización clara**: Cada contacto se muestra con nombre, teléfono y correo.  
- **Edición directa**: Al seleccionar un contacto en la lista, sus datos se cargan en los campos para facilitar la edición.  
- **Exportación CSV**: Exporta todos los contactos a `contacts_export.csv` con ruta absoluta.  

---

## 📂 Estructura del proyecto

~~~CMD
GestorContactos/
│
├── Program.cs
├── ContactForm.cs
├── ContactForm.Designer.cs
├── GestorContactos.csproj
├── contacts.db   (se genera automáticamente)
├── README.md
└── LICENSE
~~~

---

## ⚙️ Requisitos

- .NET 9.0 (Windows Desktop)  
- Paquete NuGet:  

  ~~~xml
  <PackageReference Include="Microsoft.Data.Sqlite" Version="9.0.0" />
  ~~~

Instalación:  

~~~bash
dotnet add package Microsoft.Data.Sqlite --version 9.0.0
dotnet restore
dotnet build
dotnet run
~~~

---

## 🖥️ Uso

1. Escribe nombre, teléfono, email y dirección del contacto.  
2. Usa los botones:
   - **➕ Agregar**: crea un nuevo contacto.  
   - **✏️ Editar**: modifica el contacto seleccionado.  
   - **🗑️ Eliminar**: borra el contacto seleccionado.  
   - **📤 Exportar CSV**: exporta todos los contactos a un archivo CSV.  
3. Al seleccionar un contacto en la lista, sus datos se cargan automáticamente en los campos para edición rápida.  

---

## 📜 Licencia

Este proyecto está bajo la licencia MIT.  
Puedes usarlo, modificarlo y compartirlo libremente, siempre dando crédito.

---

## ✨ Autor

Desarrollado por **Jorge "Lechugas"** 🌱🔥  
Ingeniero en Sistemas Computacionales, apasionado por la creación de herramientas modulares y proyectos con UI moderna.
¡Gracias por visitar mi portafolio! 🚀
