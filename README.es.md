# TalentHub API 

Una API Backend diseñada para demostrar **Clean Architecture** y **prácticas modernas de .NET** aplicadas a un contexto de Gestión de Reclutamiento.

> **Objetivo del Proyecto:** Mostrar calidad estructural, mantenibilidad y principios SOLID por encima de la complejidad de funcionalidades. Este proyecto sirve como una prueba de concepto técnica para una base de código escalable de nivel Junior Developer.

## Arquitectura y Decisiones de Diseño

Esta solución implementa **Clean Architecture**, separando responsabilidades en capas distintas para asegurar que la lógica de negocio central permanezca independiente de frameworks externos.

* **TalentHub.Domain:** Contiene la Lógica Empresarial y las Entidades.
* **TalentHub.Application:** Define los Casos de Uso e Interfaces (Patrón Repositorio).
* **TalentHub.Infrastructure:** Implementa el acceso a datos usando **Entity Framework Core** y **SQL Server**.
* **TalentHub.API:** Una capa de presentación ligera usando **endpoints RESTful**.

## Stack Tecnológico

* **Framework:** .NET 10 (C# 14) - *Aprovechando las últimas características como Constructores Primarios.*
* **Base de Datos:** SQL Server.
* **ORM:** Entity Framework Core (Enfoque Code-First).
* **Testing:** xUnit (Pruebas Unitarias para la Lógica de Dominio).
* **Documentación:** Swagger / OpenAPI.

## Características Clave Implementadas

* **Operaciones CRUD Robustas:** Gestión completa de Ofertas de Trabajo.
* **Validación de Lógica de Negocio:** Reglas de validación estrictas asegurando la integridad de datos a nivel de Dominio.
* **Inyección de Dependencias:** Servicios totalmente desacoplados configurados en `Program.cs`.
* **Documentación Automatizada:** Pruebas interactivas de la API vía Swagger UI.

## Cómo Ejecutar

1.  Clona este repositorio.
2.  Abre la solución `TalentHub.sln` en **Visual Studio**.
3.  Asegúrate de tener **SQL Server LocalDB** (viene por defecto con VS) o actualiza los `ConnectionStrings` en `appsettings.json`.
4.  Ejecuta las migraciones de base de datos en la Consola del Administrador de Paquetes (Package Manager Console):
    ```powershell
    Update-Database
    ```
5.  Presiona **F5** para ejecutar. El navegador debería abrirse con Swagger.
    > **Nota:** Si no se abre automáticamente, navega a: `http://localhost:<PUERTO>/swagger/index.html` (revisa la salida de la consola para ver tu puerto específico, ej: 5094).

---
*Desarrollado con .NET 10*
