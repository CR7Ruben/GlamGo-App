# GlamGo Móvil

Aplicación móvil para descubrir establecimientos y profesionales de belleza, consultar servicios y, en incrementos posteriores, gestionar reservas. Este repositorio contiene el proyecto base de **.NET MAUI** y la documentación de planificación.

## Estado del proyecto

**Base técnica creada y ejecutada** en Windows y en un dispositivo Android físico. La interfaz actual es el contenido de demostración generado por la plantilla de Visual Studio (`Include sample content`); **no representa aún las funcionalidades definitivas de GlamGo**. Autenticación, catálogo, citas, favoritos, reseñas, pagos y notificaciones son funcionalidades planificadas, no verificadas como implementadas.

## Tecnologías

- .NET MAUI, C# y XAML para la aplicación móvil.
- Visual Studio 2026 Community 18.12.1 (canal estable).
- .NET SDK instalado: 11.0.100. **El framework objetivo debe verificarse** en `GlamGoApp/GlamGoApp/GlamGoApp.csproj`, en la propiedad `TargetFrameworks` (puede ser .NET 10 aunque esté instalado SDK 11).
- Git 2.46.0.windows.1.
- Backend previsto: Node.js/Express; base de datos prevista: PostgreSQL. No son necesarios para ejecutar la pantalla de demostración actual.

## Requisitos para ejecutar

1. Windows con Visual Studio 2026 Community o una versión compatible con el framework objetivo del proyecto.
2. Carga de trabajo **.NET MAUI** instalada, con herramientas y SDK de Android para probar en teléfono.
3. SDK de .NET compatible con el valor `TargetFrameworks` del `.csproj`.
4. Git para clonar el repositorio.
5. Para Android físico: teléfono Android, cable USB de datos, opciones de desarrollador y depuración USB activadas.

## Obtener el proyecto

```powershell
git clone https://github.com/CR7Ruben/GlamGo-App.git
cd GlamGo-App
```

La solución de Visual Studio está en `GlamGoApp/GlamGoApp.slnx`. El proyecto MAUI está en `GlamGoApp/GlamGoApp/GlamGoApp.csproj`.

## Ejecutar en Visual Studio

1. Abre `GlamGoApp/GlamGoApp.slnx` en Visual Studio.
2. Espera la restauración de dependencias NuGet. Si hace falta, utiliza **Compilar > Recompilar solución**.
3. Para probar en Windows, selecciona **Windows Machine** y presiona **F5**.
4. Para probar en Android físico, conecta el teléfono por USB, habilita **Depuración USB**, acepta el aviso de autorización en el teléfono y selecciónalo en el desplegable de dispositivos de Visual Studio.
5. Presiona **F5** y espera a que se instale y abra la aplicación.

La primera compilación puede tardar por la descarga/restauración de dependencias y herramientas. Si no aparece el dispositivo, verifica cable, autorización de depuración y controladores USB; opcionalmente usa `adb devices` desde un entorno con ADB configurado.

## Verificar herramientas

```powershell
dotnet --version
dotnet workload list
git --version
```

Para comprobar el framework del proyecto, abre `GlamGoApp/GlamGoApp/GlamGoApp.csproj` y busca `TargetFrameworks`. No debe confundirse el SDK global con el framework objetivo de la aplicación.

## Estructura general

```text
GlamGo-App/
├── .gitignore
├── PROJECT_CONTEXT.md
├── CURRENT_TASK.md
├── IMPLEMENTATION_PLAN.md
├── README.md
├── HERRAMIENTAS_Y_CONFIGURACION.md
└── GlamGoApp/
    ├── GlamGoApp.slnx
    └── GlamGoApp/
        ├── GlamGoApp.csproj
        ├── App.xaml
        ├── AppShell.xaml
        ├── MauiProgram.cs
        ├── Data/
        ├── Models/
        ├── PageModels/
        ├── Pages/
        ├── Platforms/
        ├── Resources/
        ├── Services/
        └── Utilities/
```

## Documentación y versionamiento

- `PROJECT_CONTEXT.md`: contexto, alcance y decisiones técnicas.
- `CURRENT_TASK.md`: incremento actual y criterios de aceptación.
- `IMPLEMENTATION_PLAN.md`: fases y tareas previstas.
- `HERRAMIENTAS_Y_CONFIGURACION.md`: entorno de desarrollo y evidencias.

Historial de commits: https://github.com/CR7Ruben/GlamGo-App/commits/main

## Limitaciones actuales

El proyecto base se ejecuta sin necesidad de una API propia. El backend Node.js/Express, PostgreSQL y las funciones de negocio se incorporarán en incrementos posteriores. La ejecución en Windows y Android fue reportada por el equipo; para reproducirla en otro equipo se requiere instalar los componentes compatibles indicados arriba.
