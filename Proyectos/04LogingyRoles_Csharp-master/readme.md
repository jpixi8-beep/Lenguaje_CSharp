
# Sistema de Login con Roles 🔐

Aplicación de escritorio en **C# WinForms** con **SQLite** que implementa un sistema de login con control de roles.  
Forma parte de mi portafolio de proyectos, mostrando seguridad básica, registro de usuarios y vistas diferenciadas según rol.

---

## 🚀 Características

- **Login seguro**: validación de credenciales contra base de datos SQLite.  
- **Registro de usuarios**: creación de cuentas directamente desde la app.  
- **Roles diferenciados**:
  - **Admin**: acceso completo (gestión de usuarios, reportes).  
  - **Usuario**: acceso limitado (perfil, salir).  
- **UI moderna**:
  - Paleta oscura con verde acento.  
  - Botones planos y estilizados.  
- **Feedback claro**: mensajes de bienvenida según el rol.  

---

## 📂 Estructura del proyecto

```powershell
GestorLogin/
│
├── Program.cs
├── LoginForm.cs
├── LoginForm.Designer.cs
├── RegisterForm.cs
├── RegisterForm.Designer.cs
├── MainForm.cs
├── GestorLogin.csproj
├── users.db   (se genera automáticamente)
├── README.md
└── LICENSE
```

---

## ⚙️ Requisitos

- .NET 9.0 (Windows Desktop)  
- Paquete NuGet:  

```powershell
<PackageReference Include="Microsoft.Data.Sqlite" Version="9.0.0" />
```

Instalación:  

```powershell
dotnet add package Microsoft.Data.Sqlite --version 9.0.0
dotnet restore
dotnet build
dotnet run
```

---

## 🖥️ Uso

1. Abre la aplicación y accede al formulario de login.  
2. Si no tienes cuenta, usa el botón **Registrar usuario** para crear una nueva.  
3. Ingresa usuario y contraseña en el login.  
4. Según el rol asignado:  
   - **Admin**: verá opciones de gestión de usuarios y reportes.  
   - **Usuario**: verá solo perfil y salir.  

---

## 📜 Licencia

Este proyecto está bajo la licencia MIT.  
Puedes usarlo, modificarlo y compartirlo libremente, siempre dando crédito.

---

## ✨ Autor

Desarrollado por **Jorge "Lechugas"** 🌱🔥  
Ingeniero en Sistemas Computacionales, apasionado por la creación de herramientas modulares y proyectos con UI moderna.
¡Gracias por visitar mi portafolio!
