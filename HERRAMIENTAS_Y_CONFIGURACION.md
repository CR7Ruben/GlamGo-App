# GlamGo Móvil — Reporte de herramientas, versiones y configuración

**Fecha del reporte:** 20 de noviembre de 2026  
**Repositorio:** https://github.com/CR7Ruben/GlamGo-App  
**Alcance:** configuración y ejecución del proyecto base de .NET MAUI; no se afirma que las funciones de negocio estén implementadas.

## 1. Herramientas y versiones registradas

| Herramienta / componente | Versión o estado | Evidencia |
|---|---|---|
| Visual Studio Community | 2026, versión **18.12.1**, canal Estable | Ventana «Acerca de Visual Studio» |
| .NET SDK disponible en consola | **11.0.100** | `dotnet --version` |
| Manifiestos de cargas de trabajo | **11.0.100-manifests.5d612b92** | `dotnet workload list` |
| Android workload | **37.2.29/11.0.100** | `dotnet workload list` |
| iOS workload | **27.2.11039/11.0.100** | `dotnet workload list` |
| Mac Catalyst workload | **27.2.11039/11.0.100** | `dotnet workload list` |
| MAUI Windows workload | **11.0.0/11.0.100** | `dotnet workload list` |
| Git para Windows | **2.46.0.windows.1** | `git --version` |
| Lenguaje de aplicación | **C#** | Proyecto .NET MAUI |
| Interfaz de usuario | **XAML** | Archivos `App.xaml`, `AppShell.xaml` y páginas |
| Framework objetivo (`TargetFrameworks`) | **Pendiente de confirmar en el `.csproj`** | El SDK 11 no determina el framework objetivo; se seleccionó .NET 10 durante la creación, pero falta comprobar el archivo |
| Android SDK / versión de plataforma exacta | **Pendiente de registrar** | Consultar SDK Manager o detalles de compilación; la versión del workload no es la versión de Android SDK |
| Sistema operativo de desarrollo | **Windows 11 (observado)**; edición/build sin verificar | Capturas de escritorio |
| Dispositivo de pruebas | **Android físico conectado por USB**; modelo y versión de Android sin verificar | Ejecución mostrada en teléfono |

## 2. Configuración realizada

1. Se instaló la carga de trabajo de desarrollo multiplataforma **.NET MAUI** en Visual Studio.
2. Se creó una solución MAUI con interfaz **XAML** y contenido de ejemplo incluido.
3. Se abrió la solución y se compiló/ejecutó la aplicación en **Windows Machine**.
4. Se activó la **depuración USB** en un teléfono Android, se conectó al equipo y se ejecutó la aplicación desde Visual Studio.
5. Se organizó el repositorio local en `D:\GlamGo-App`, con los archivos de contexto y la solución en `GlamGoApp/`.
6. Se configuró el remoto `origin` hacia `https://github.com/CR7Ruben/GlamGo-App.git` y se utilizó la rama `main`.
7. Se añadió `.gitignore` para excluir archivos generados (`.vs`, `bin`, `obj`, etc.) y se publicó el código base en GitHub.

## 3. Comandos de comprobación

```powershell
dotnet --version
dotnet workload list
git --version
git status
git remote -v
git log --oneline -5
```

**Verificación adicional pendiente:** abrir `GlamGoApp/GlamGoApp/GlamGoApp.csproj` y copiar el valor de `TargetFrameworks` para documentar con exactitud si el proyecto está dirigido a .NET 10 o .NET 11.

## 4. Instrucciones de reproducción

1. Clonar el repositorio: `git clone https://github.com/CR7Ruben/GlamGo-App.git`.
2. Abrir `GlamGoApp/GlamGoApp.slnx` en Visual Studio con .NET MAUI instalado.
3. Restaurar paquetes y seleccionar **Windows Machine** o un teléfono Android autorizado mediante depuración USB.
4. Presionar **F5** y comprobar que inicia la interfaz de ejemplo.

Consultar el archivo `README.md` para el procedimiento detallado.

## 5. Evidencia de repositorio y versionamiento

- Repositorio público: https://github.com/CR7Ruben/GlamGo-App
- Historial: https://github.com/CR7Ruben/GlamGo-App/commits/main
- Archivos de planificación: `PROJECT_CONTEXT.md`, `CURRENT_TASK.md`, `IMPLEMENTATION_PLAN.md`.
- Proyecto de aplicación: carpeta `GlamGoApp/`.
- Evidencia observada: aplicación base iniciada en Windows y en teléfono Android físico.

Para la entrega final, adjuntar capturas de la estructura del repositorio, commits, aplicación ejecutándose en Android y ventana de versiones de Visual Studio. No se incluye aquí una captura embebida porque este reporte es un archivo Markdown de texto.

## 6. Estado y pendientes

**Completado:** proyecto MAUI base, ejecución Windows/Android, repositorio público, commits y archivos de contexto.  
**Pendiente:** registrar `TargetFrameworks` y versión exacta de Android SDK, añadir este reporte y el README al repositorio, e implementar las funcionalidades reales de GlamGo en los incrementos correspondientes.

**Nota técnica:** Node.js/Express y PostgreSQL forman parte de la arquitectura prevista, pero no se reportan como instalados ni configurados porque no hay evidencia de sus versiones en este entorno.
