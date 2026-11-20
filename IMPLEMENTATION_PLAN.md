# IMPLEMENTATION_PLAN.md — GlamGo Móvil

## Propósito
Traducir los cinco incrementos del Avance 1 a pasos ejecutables y verificables, manteniendo la arquitectura de tres capas del Entregable 2. El plan es **propuesto**, no un reporte de trabajo ya completado.

## Decisión tecnológica transversal
**Decisión D-01 (aprobada):** la aplicación móvil se implementará en **.NET MAUI con C# y XAML**. Flutter fue la propuesta inicial del Avance 1 y ya fue descartado por el equipo. Usar la estructura `Models/`, `Views/`, `ViewModels/`, `Services/`, `Resources/`, `Platforms/` descrita en el Entregable 2. Se conservan Node.js, PostgreSQL, API REST, Git/GitHub y Scrum adaptado.

## Incremento 1 — Base del proyecto
**Meta:** entorno y acceso de usuarios.

| Paso | Actividad concreta | Evidencia / verificación | Responsable principal |
|---|---|---|---|
| 1 | Configurar solución .NET MAUI (C#/XAML), crear repositorios y ramas | Solución MAUI compilable y repositorios accesibles | Xitzia Fierro (versiones), con equipo |
| 2 | Inicializar app .NET MAUI, navegación y pantalla de inicio | Compila/abre en dispositivo o emulador | Xitzia Fierro |
| 3 | Diseñar tablas iniciales de usuarios y conexión PostgreSQL | Script/migración y consulta exitosa | Rubén González |
| 4 | Crear API Node.js, rutas de registro/login y validaciones | Pruebas Postman con éxito y error | Xitzia Fierro |
| 5 | Integrar formularios y API con manejo de estados | Flujo registro/login funcional | Xitzia Fierro |
| 6 | Ejecutar pruebas y revisión por PR | Resultados documentados y merge revisado | Rubén González (pruebas), Xitzia Fierro (documentación) |

**Aceptación:** CA-01 a CA-09 de `CURRENT_TASK.md`.

## Incremento 2 — Catálogo y perfiles
**Meta:** explorar negocios.
1. Definir entidades y contratos de categorías, negocios, servicios, fotografías y precios.
2. Implementar consultas API y persistencia en PostgreSQL.
3. Crear catálogo móvil, búsqueda y filtros por cercanía, calificación y precio.
4. Crear pantalla de perfil de negocio con servicios, fotos y reseñas visibles.
5. Probar filtros y navegación con datos de ejemplo.

**Criterios propuestos:** búsqueda devuelve negocios pertinentes; filtros modifican resultados; un negocio muestra sus servicios/precios/fotografías; estados vacíos y errores se manejan sin cierre inesperado.

## Incremento 3 — Citas
**Meta:** solicitar y consultar reservaciones.
1. Definir entidad cita, horarios y estados pendiente/confirmada/cancelada.
2. Implementar consulta de disponibilidad en API y validación de horario.
3. Evitar reservas simultáneas del mismo espacio mediante transacción/restricción adecuada.
4. Implementar pantalla de selección de servicio, fecha y hora y envío de solicitud.
5. Implementar "Mis citas", consulta de estado y cancelación.
6. Probar caso disponible, horario ocupado y cancelación; registrar pruebas de integración.

**Criterios propuestos:** una solicitud válida se guarda y aparece en "Mis citas"; un horario ocupado no se duplica; la cancelación cambia el estado; la API devuelve errores comprensibles.

## Incremento 4 — Reseñas, favoritos y perfil
**Meta:** confianza y personalización.
1. Modelar reseñas, calificaciones y favoritos en PostgreSQL.
2. Implementar consulta/alta de reseñas y regla de publicación posterior al servicio.
3. Implementar agregar/quitar favoritos y listado personal.
4. Implementar consulta/edición de perfil con validaciones.
5. Probar persistencia y autorización por usuario.

**Criterios propuestos:** las reseñas cumplen la condición de servicio recibido; favoritos y perfil se conservan tras cerrar/reabrir sesión; un usuario no modifica datos de otro.

## Incremento 5 — Pagos, notificaciones y cierre
**Meta:** completar el flujo y preparar entrega.
1. Seleccionar y documentar proveedor de pagos y mecanismo de notificaciones (pendientes).
2. Integrar pago de reserva desde app mediante backend; mantener secretos en servidor.
3. Implementar confirmaciones y recordatorios.
4. Ejecutar pruebas de sistema, integración, API, rendimiento y usabilidad.
5. Corregir errores, documentar resultados y preparar versión v1.0.0 si se cumplen los criterios de entrega.

**Criterios propuestos:** se refleja correctamente el resultado de pago sin exponer secretos; se generan recordatorios; flujo completo probado; no quedan errores críticos de entrega.

## Reglas de ejecución y control
- Scrum adaptado: planificar tareas pequeñas, demostrar avances funcionales y ajustar por retroalimentación.
- Separar repositorios de móvil y API; `main` estable, ramas personales, PR revisado por el otro integrante.
- Mantener arquitectura: app móvil → API REST Node.js → PostgreSQL; comunicación HTTPS/JSON.
- Documentar decisiones pendientes y cambios de alcance antes de implementarlos.
- Pruebas: unitarias, funcionales, sistema, API, integración, rendimiento y usabilidad. Avance 1 propone Postman, Jest y JMeter, que se mantienen como opciones; las herramientas de Flutter quedan descartadas. Para .NET MAUI se propone xUnit o NUnit y pruebas de interfaz adecuadas a MAUI, sujetas a selección final.
- No incluir chat en tiempo real ni programas avanzados de promociones/lealtad en esta etapa.

## Matriz de decisiones abiertas
| ID | Pendiente | Impacto | Acción |
|---|---|---|---|
| D-01 (resuelta) | .NET MAUI con C# y XAML | Define estructura y pruebas móviles | Decisión confirmada por el equipo; Flutter descartado |
| D-02 | Contrato de autenticación y reglas de contraseña | Incremento 1 | Definir DTO, validaciones y manejo de tokens |
| D-03 | Esquema detallado de citas y concurrencia | Incremento 3 | Diseñar restricciones y pruebas |
| D-04 | Proveedor de pagos | Incremento 5 | Seleccionar, documentar y probar integración |
| D-05 | Proveedor de notificaciones | Incremento 5 | Seleccionar canal y condiciones de envío |
| D-06 | Hospedaje y configuración de entornos | Todos | Definir ambientes, HTTPS y secretos |

## Fuentes
- Avance 1, §§2–7: alcance, tecnologías iniciales, incrementos, responsables, versiones y pruebas.
- Entregable 2, §§1–5: arquitectura actualizada propuesta, patrones, componentes, vistas y seguridad.
