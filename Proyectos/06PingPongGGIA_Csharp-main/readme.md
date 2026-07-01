
# 🏓 PINGPONG GG

Juego clásico **Pong** desarrollado en **C# WinForms** con dos modos de juego:  

- **PvP (Jugador vs Jugador)**  
- **PvIA (Jugador vs Computadora)**  

Forma parte de mi portafolio de proyectos, mostrando lógica de colisiones, control de eventos y diseño de menús en aplicaciones de escritorio.

---

## 🚀 Características

- **Menú inicial**:
  - Título: *PINGPONG GG*  
  - Botón para iniciar **PvP a 3 puntos**  
  - Botón para iniciar **PvIA a 3 puntos**  

- **Modo PvP**:
  - Jugador izquierdo: teclas **W / S**  
  - Jugador derecho: teclas **↑ / ↓**  
  - Gana el primero que llegue a **3 puntos**  

- **Modo PvIA**:
  - Jugador izquierdo: teclas **W / S**  
  - Paleta derecha controlada por la IA (sigue la pelota con retraso para hacerlo jugable)  
  - Gana el primero que llegue a **3 puntos**  

- **Pausa con ESC**:
  - Botón **Reanudar**  
  - Botón **Reiniciar partida**  
  - Botón **Salir del juego**  

- **Marcador visible** en la parte superior, mostrando el puntaje actual.  
- **Pelota con rebotes** en paredes y paletas.  
- **Velocidad progresiva** de la pelota al reiniciar tras cada punto.  

---

## 📂 Estructura del proyecto

```cmd
PongGame/
│
├── Program.cs
├── MainMenuForm.cs
├── MainMenuForm.Designer.cs
├── PongForm.cs
├── PongForm.Designer.cs
├── PauseForm.cs
├── PauseForm.Designer.cs
├── PongGame.csproj
└── README.md
```

---

## ⚙️ Requisitos

- .NET 9.0 (Windows Desktop)  
- Visual Studio o VS Code con extensiones de C#  

Compilación y ejecución:

```bash
dotnet restore
dotnet build
dotnet run
```

---

## 🖥️ Uso

1. Ejecuta la aplicación.  
2. En el menú inicial selecciona **PvP** o **PvIA**.  
3. Controla las paletas con las teclas asignadas.  
4. El primero que llegue a **3 puntos gana la partida**.  
5. Presiona **ESC** para abrir el menú de pausa (Reanudar, Reiniciar, Salir).  

---

## 📜 Licencia

Este proyecto está bajo la licencia MIT.  
Puedes usarlo, modificarlo y compartirlo libremente, siempre dando crédito.

---

## ✨ Autor

Desarrollado por **Jorge "Lechugas"** 🌱🔥  
Ingeniero en Sistemas Computacionales, apasionado por la creación de herramientas modulares y proyectos con UI moderna.
