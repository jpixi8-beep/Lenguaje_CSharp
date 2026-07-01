
# 🐍 Snake Game en WinForms

Juego clásico **Snake** desarrollado en **C# WinForms** con **SQLite** para guardar puntuaciones.  
Forma parte de mi portafolio de proyectos, mostrando lógica de juego, UI moderna y persistencia de datos.

---

## 🚀 Características

- **Movimiento con teclado**: Flechas ↑ ↓ ← →.  
- **Marcador en pantalla**: suma puntos cada vez que la serpiente come una manzana.  
- **Velocidad progresiva**: aumenta cada cierto puntaje.  
- **Reinicio correcto**: al perder, la velocidad vuelve al valor inicial.  
- **Menú de pausa (ESC)**:
  - Reanudar partida.  
  - Ver Records (Leaderboard).  
  - Salir del juego.  
- **Leaderboard persistente**:
  - Guarda nombre, score y fecha en SQLite.  
  - Muestra los 10 mejores puntajes.  
  - Se abre automáticamente al morir.  
- **UI moderna**:
  - Fondo negro, serpiente verde, comida roja.  
  - Indicador de pausa junto al marcador: *“Presiona ESC para Pausa”*.  

---

## 📂 Estructura del proyecto

```cmd
SnakeGame/
│
├── Program.cs
├── SnakeForm.cs
├── SnakeForm.Designer.cs
├── PauseForm.cs
├── PauseForm.Designer.cs
├── LeaderboardForm.cs
├── LeaderboardForm.Designer.cs
├── SnakeGame.csproj
├── scores.db   (se genera automáticamente)
├── README.md
└── LICENSE
```

---

## ⚙️ Requisitos

- .NET 9.0 (Windows Desktop)  
- Paquete NuGet:  

```bash
dotnet add package Microsoft.Data.Sqlite --version 9.0.0
dotnet restore
dotnet build
dotnet run
```

---

## 🖥️ Uso

1. Ejecuta la aplicación.  
2. Controla la serpiente con las flechas del teclado.  
3. Presiona **ESC** para abrir el menú de pausa.  
4. Al morir:
   - Ingresa tu nombre.  
   - Se guarda tu score con fecha en SQLite.  
   - Se abre automáticamente el leaderboard mostrando los mejores puntajes.  

---

## 📜 Licencia

Este proyecto está bajo la licencia MIT.  
Puedes usarlo, modificarlo y compartirlo libremente, siempre dando crédito.

---

## ✨ Autor

Desarrollado por **Jorge "Lechugas"** 🌱🔥  
Ingeniero en Sistemas Computacionales, apasionado por la creación de herramientas modulares y proyectos con UI moderna.

---
