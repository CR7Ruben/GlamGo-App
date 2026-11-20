# GlamGo Móvil

Aplicación móvil para descubrir establecimientos y profesionales de belleza, consultar servicios y, en incrementos posteriores, gestionar reservas. Este repositorio contiene el proyecto base de **.NET MAUI** y la documentación de planificación.

## Estado del proyecto

**Base técnica creada y ejecutada** en Windows y en un dispositivo Android físico. La interfaz actual es el contenido de demostración generado por la plantilla de Visual Studio (`Include sample content`); **no representa aún las funcionalidades definitivas de GlamGo**. Autenticación, catálogo, citas, favoritos, reseñas, pagos y notificaciones son funcionalidades planificadas, no verificadas como implementadas.

## Tecnologías

- .NET MAUI, C# y XAML para la aplicación móvil.
- Visual Studio 2026 Community 18.12.1 (canal estable).
- **Framework objetivo: .NET 10.0 (LTS)**, confirmado en `GlamGoApp/GlamGoApp/GlamGoApp.csproj` mediante `TargetFrameworks`. Plataformas configuradas: Android (`net10.0-android`), iOS (`net10.0-ios`), Mac Catalyst (`net10.0-maccatalyst`) y Windows (`net10.0-windows10.0.19041.0`). Solo se ha verificado la ejecución en Android y Windows.
- **.NET SDK instalado: 11.0.100**. El SDK instalado y el framework objetivo del proyecto son versiones diferentes.
- Git 2.46.0.windows.1.
- Backend previsto: Node.js/Express; base de datos prevista: PostgreSQL. No son necesarios para ejecutar la pantalla de demostración actual.

## Requisitos para ejecutar

1. Windows con Visual Studio 2026 Community o una versión compatible con .NET 10 y .NET MAUI.
2. Carga de trabajo **.NET MAUI** instalada, con herramientas y SDK de Android para probar en teléfono.
3. SDK de .NET compatible con los destinos .NET 10 del `.csproj` (en el equipo de desarrollo se utilizó SDK 11.0.100).
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

El framework del proyecto ya fue confirmado mediante `TargetFrameworks` en `GlamGoApp/GlamGoApp/GlamGoApp.csproj`: .NET 10 para Android, iOS, Mac Catalyst y Windows. No debe confundirse el SDK global 11.0.100 con el framework objetivo .NET 10.

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
