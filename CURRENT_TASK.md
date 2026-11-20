# CURRENT_TASK.md — GlamGo Móvil

## Incremento activo propuesto: 1. Base del proyecto
**Estado:** planificado; no se cuenta en estos documentos con evidencia de código implementado o pruebas ejecutadas.

### Objetivo
Preparar el entorno y el acceso de usuarios, incluyendo proyecto móvil, API base, esquema inicial PostgreSQL, registro, inicio de sesión, navegación y pantalla principal.

### Decisión tecnológica aprobada
**La aplicación móvil se desarrollará en .NET MAUI con C# y XAML.** Flutter fue descartado por el equipo después del Avance 1. La estructura, las tareas y las pruebas de este incremento deben corresponder a .NET MAUI.

## Qué se implementará en este incremento
1. Crear/configurar repositorios separados para aplicación móvil y API, con ramas y reglas de revisión.
2. Preparar proyecto .NET MAUI (C#/XAML) y navegación entre inicio, registro e inicio de sesión.
3. Diseñar y crear esquema inicial de usuarios en PostgreSQL y conexión segura desde API.
4. Crear API REST base Node.js para registro e inicio de sesión, con validaciones y respuestas JSON.
5. Integrar formularios móviles con API, gestionar estado de carga, éxito y error.
6. Construir pantalla de inicio con navegación a categorías (el catálogo completo corresponde al Incremento 2).
7. Realizar pruebas unitarias de validaciones, pruebas de API y un recorrido funcional básico.

## Qué no se implementará todavía
- Catálogo completo, filtros y perfiles de negocios (Incremento 2).
- Reserva, cancelación, estados de citas y disponibilidad (Incremento 3).
- Reseñas, favoritos y edición del perfil (Incremento 4).
- Pagos y notificaciones (Incremento 5).
- Chat en tiempo real y promociones avanzadas (fuera del alcance de la etapa).
- Panel web de administración (fuera del alcance del componente móvil documentado).

## Criterios de aceptación verificables propuestos
- **CA-01.** El proyecto móvil abre en emulador o dispositivo de prueba sin errores de inicio.
- **CA-02.** La pantalla inicial permite navegar a Registro e Iniciar sesión y volver sin bloqueos.
- **CA-03.** El formulario de registro rechaza correo inválido, contraseña vacía y campos obligatorios incompletos; muestra mensajes comprensibles.
- **CA-04.** Con datos válidos, el registro envía una petición a la API y el usuario queda persistido en PostgreSQL; el correo duplicado produce error controlado.
- **CA-05.** El inicio de sesión permite acceder con credenciales válidas y rechaza credenciales incorrectas sin revelar contraseñas.
- **CA-06.** La API entrega respuestas JSON y códigos HTTP coherentes para éxito y errores de validación/autenticación.
- **CA-07.** La app no incluye credenciales de base de datos ni se conecta directamente a PostgreSQL; la comunicación remota usa HTTPS en el entorno de entrega.
- **CA-08.** Existen pruebas registradas de registro, login y navegación, con resultados y evidencia de ejecución.
- **CA-09.** Los cambios se integran a `main` mediante pull request revisado, con commits claros y una etiqueta de versión al cerrar el incremento.

Estos criterios **son una propuesta operativa para el incremento**, derivados de los objetivos de Avance 1; no son criterios ya aprobados literalmente en los documentos.

## Pendientes por resolver
- [x] Framework móvil seleccionado: .NET MAUI con C# y XAML (confirmado por el equipo).
- [ ] Definir campos obligatorios y reglas de contraseña.
- [ ] Definir endpoints, DTO, códigos de error y política de tokens.
- [ ] Definir entorno de despliegue/API y configuración de secretos.
- [ ] Seleccionar herramientas concretas de pruebas para .NET MAUI (por ejemplo, xUnit/NUnit y pruebas de interfaz).
- [ ] Registrar evidencia real de avances y resultados de pruebas.

## Definición de terminado del incremento (propuesta)
Todos los criterios CA-01 a CA-09 verificados, PR aprobado, sin errores críticos conocidos en el flujo de registro/login, documentación actualizada y versión etiquetada.

## Fuentes
Avance 1, §§2, 4, 6 y 7; Entregable 2, §§1, 4.2 y 5.
