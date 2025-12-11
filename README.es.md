# TalentHub

Primer proyecto backend para un sistema de gestión de reclutamiento. La idea principal fue enfocarme en la calidad de la arquitectura y en cómo organizar el código de forma profesional
Lo construí pensando en cómo escalaría un proyecto real, separando bien las responsabilidades y aplicando principios SOLID

# Tecnologías: 

.NET 10 (C# 14): aprovechar las últimas características del lenguaje, como los constructores primarios que limpian mucho el código
SQL Server/Entity Framework Core: manejo de datos usando el enfoque Code-First
xUnit: tests unitarios
Swagger: documentar y probar la API visualmente

# Arquitectura:

Domain: donde viven las entidades y las reglas de negocio
Application: define qué se puede hacer en el sistema (interfaces y casos de uso)
Infrastructure: quien habla con la base de datos y donde está la implementación de EF y los repositorios
Backend (API): capa que recibe las peticiones HTTP y se comunica con las otras capas mediante inyección de dependencias

# Cómo correr:

1. Clonar el repositorio

2. Abrir TalentHub.sln en Visual Studio.

3. Tener SQL Server (o LocalDB en VS) funcionando.

4. Abrir la consola del administrador de paquetes y ejecutar el comando Update-Database para que se cree la base de datos.

5. Darle a Play. Debería abrirse el navegador con Swagger listo para probar los endpoints.
