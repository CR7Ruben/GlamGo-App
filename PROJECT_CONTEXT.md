# PROJECT_CONTEXT.md — GlamGo Móvil

## 1. Contexto y problema
GlamGo es una plataforma para que clientes encuentren estéticas, barberías, spas y profesionales independientes, comparen servicios, precios, reseñas y disponibilidad, y soliciten citas sin depender de búsquedas dispersas en redes sociales o comunicación directa con cada negocio.

## 2. Objetivo y alcance del componente móvil
Desarrollar una aplicación móvil para clientes que permita:
- Registrarse e iniciar sesión con correo y contraseña.
- Explorar categorías (estética, barbería, uñas, spa, peluquería, masajes y otras).
- Buscar negocios y filtrarlos por cercanía, calificación y precio.
- Consultar perfiles de negocios, servicios, fotografías, precios y reseñas.
- Solicitar citas seleccionando servicio, fecha y horario disponible.
- Consultar y cancelar citas; visualizar estados **pendiente, confirmada y cancelada**.
- Guardar negocios favoritos, publicar reseñas después del servicio y editar el perfil.
- Recibir notificaciones y recordatorios y pagar reservaciones dentro de la aplicación.

### Fuera del alcance de esta etapa
- Chat en tiempo real entre cliente y negocio.
- Programas avanzados de lealtad, cupones y promociones.
- Desarrollo de la interfaz web administrativa en este incremento/documentación móvil.

## 3. Arquitectura y tecnologías
Arquitectura cliente-servidor de tres capas:
1. **Presentación:** aplicación móvil.
2. **Negocio:** API REST Node.js; se propone Express.js para rutas y controladores.
3. **Datos:** PostgreSQL para usuarios, negocios, servicios, horarios, citas, reseñas, favoritos y pagos.

Comunicación móvil ↔ API mediante **HTTPS/JSON**. La aplicación no accede directamente a PostgreSQL. El servidor valida disponibilidad y aplica reglas de reservación. Se proponen los patrones **MVVM** en móvil y **Service + Repository** en backend. Las credenciales de terceros permanecen en servidor; contraseñas con hash seguro y sesiones basadas en tokens (mecanismos específicos por concretar).

## 4. Registro de decisiones
| Estado | Decisión | Sustento / aclaración |
|---|---|---|
| Documentada en ambos avances | Node.js para API, PostgreSQL para datos, Git/GitHub | Avance 1, §§2.3–2.4 y 6; Entregable 2, §§1–2 y 5 |
| Documentada en Entregable 2 | Arquitectura de tres capas, MVVM, Repository, Service, HTTPS | Entregable 2, §§1 y 5 |
| **Aprobada por el equipo (confirmación posterior)** | Aplicación móvil con **.NET MAUI, C# y XAML** | Flutter fue la propuesta inicial del Avance 1, sustituida posteriormente. El Entregable 2 refleja .NET MAUI y el equipo confirmó que ya no utilizará Flutter. |
| Propuesta, pendiente de especificación | Express.js en Node.js | Entregable 2 §1.2 lo presenta como propuesta adicional |
| Pendiente | Proveedor de pagos y servicio de notificaciones | Entregable 2 §§2.1–2.2 los contempla sin seleccionar proveedor |
| Pendiente | Contratos exactos de API, esquema SQL, manejo de autenticación, permisos y despliegue | Los documentos indican responsabilidades, no detalles de implementación |

## 5. Reglas y restricciones de desarrollo
- Mantener separación entre vistas, ViewModels, servicios y modelos en la aplicación móvil; y entre rutas/controladores, servicios y repositorios en la API.
- No conectar la aplicación directamente a PostgreSQL.
- Validar disponibilidad en servidor y evitar reservas simultáneas del mismo horario mediante una operación consistente/transaccional (detalle técnico por definir).
- No almacenar contraseñas en texto plano ni secretos de proveedores en la aplicación.
- Mantener repositorios separados para móvil y API, según Avance 1.
- Trabajar con Git/GitHub: `main` estable, ramas personales, pull request revisado por la otra persona y commits claros en español.
- Utilizar versionado semántico; incremento completado → versión menor, correcciones → parche, primera versión completa → v1.0.0.
- Scrum adaptado a equipo pequeño; entregar avances funcionales y ajustar con retroalimentación docente.

## 6. Responsabilidades documentadas
- Diseño de interfaces y mockups: **Rubén González** (principal), Xitzia Fierro (apoyo).
- App móvil y API: **Xitzia Fierro** (principal), Rubén González (apoyo).
- PostgreSQL y pruebas: **Rubén González** (principal), Xitzia Fierro (apoyo).
- Documentación y control de versiones: **Xitzia Fierro** (principal), Rubén González (apoyo).

## 7. Calidad y validación
Se prevén pruebas unitarias, funcionales, de sistema, de API, integración, rendimiento y usabilidad. El Avance 1 menciona herramientas de Flutter, que ya no aplican al desarrollo móvil actual. Para **.NET MAUI** se propone usar pruebas unitarias con **xUnit o NUnit** y pruebas de interfaz/integración adecuadas a MAUI; Jest para backend, Postman para API y Apache JMeter para rendimiento siguen como propuestas. La selección final de herramientas móviles específicas queda por documentar.

## 8. Fuentes
- **Avance 1 — Proyecto integrador GlamGo**, 10 de noviembre de 2026: descripción, alcance, incrementos, responsabilidades, Git y pruebas.
- **Entregable 2 — Especificación de arquitectura y decisiones técnicas**, 19 de noviembre de 2026: tres capas, .NET MAUI, MVVM, patrones Repository/Service, C4, 4+1, HTTPS y seguridad.
