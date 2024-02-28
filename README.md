<div align="center">
  <img src="https://github.com/Isaac640/IncidenciasDI/blob/Imagenes/imagenes/IRIS%20sin%20fondo%20y%20nombre%20banner.png?raw=true" alt="Banner cabecera">
</div>

# IRIS

El proyecto I.R.I.S (Incidencias Resueltas de forma Inteligente y Segura) es una solución completa para la gestión de incidencias en el entorno educativo del Instituto Miguel Herrero de Pereda. Consta de dos componentes principales de código abierto, una aplicación móvil desarrollada en Kotlin destinada al profesorado como usuarios y una aplicación de escritorio desarrollada en Windows Form.NET, que cumple las funcionalidades de la aplicación móvil pero desde el escritorio, además de contar con un apartado para administradores que permite gestionar dichas incidencias y modificar sus estados según cómo vayan resolviéndose.

## Índice

* [Versiones](#versiones)
* [Documentación API](#documentación-de-la-api)
* [Seguridad](#seguridad)
* [IRIS móvil](#iris-móvil)
* [Aplicación Escritorio](#apliación-de-escritorio)
  * [Características](#características)
  * [Uso](#uso)
    * [Gestión de incidencias](#gestión-de-incidencias)
    * [Seguridad integrada](#seguridad-integrada)
* [Miembros](#miembros)
* [Contribución](#contribución)
* [Contacto](#contacto)
* [Licencia](#licencia)

## Versiones

En este proyecto, de momento utilizamos una única versión de prueba para nuestra aplicación móvil y de escritorio, ya que se trata de un proyecto educativo y no estamos realizando lanzamientos completos. 

Versión de prueba 1.0 (Prueba): Esta versión es una demostración de nuestro trabajo escolar, que incluye tanto la aplicación móvil en Kotlin como la aplicación de escritorio en Windows Form .NET. Aunque no está destinada para su uso en producción, permite visualizar y probar las funcionalidades básicas desarrolladas durante el curso.

Cada versión se identifica con un número de versión y puede estar acompañada de notas adicionales para describir los cambios y mejoras realizadas en el proyecto.

## Documentación de la API

- [Documentación oficial de la API mediante Swagger](http://localhost:8089/swagger-ui/index.html)

La documentación oficial de nuestra API proporciona mediante Swagger una descripción detallada de los endpoints disponibles, los parámetros de solicitud, las respuestas esperadas y cualquier otra información relevante para interactuar con nuestra API.

**Notas adicionales**:
- Asegúrate de que la API esté en funcionamiento para acceder a la documentación.
- Si cambias el puerto por el que la API escucha (8089), recuerda actualizar también el puerto en la dirección del enlace.

- [Listado de endpoints](https://github.com/Isaac640/IncidenciasAPI/blob/main/ENDPOINTS.md)

Para más información sobre nuestra API, consulte el [repositorio API](https://github.com/Isaac640/IncidenciasAPI)

## Seguridad

En nuestro proyecto, nos tomamos muy en serio la seguridad de nuestros usuarios y sus datos. Aquí hay algunas consideraciones de seguridad importantes:

- **Política de contraseñas seguras**: Todos los usuarios deben tener contraseñas seguras que cumplan con ciertos criterios de complejidad.
- **Autenticación y autorización**: Utilizamos un sistema de autenticación robusto para garantizar que solo los usuarios autorizados puedan acceder a los recursos protegidos de nuestra aplicación.
- **Protección de datos sensibles**: Implementamos medidas de protección para garantizar la seguridad de los datos sensibles de nuestros usuarios, como la encriptación de datos en reposo y en tránsito.
- **Reporte de problemas de seguridad**: Si encuentras alguna vulnerabilidad en nuestra aplicación, por favor contáctanos de manera confidencial a [contacto@iris.com].


## IRIS Móvil
La apliación de Iris para dispositivos móviles está diseñada para proporcionar una forma rápida y conveniente para que el profesorado del Instituto Miguel Herrero de Pereda registre incidencias y problemas relacionados con equipos, conexiones o cuentas del centro. Con una interfaz intuitiva y fácil de usar, nuestros usuarios pueden reportar incidentes desde cualquier lugar y en cualquier momento, lo que permite una gestión eficiente y oportuna de los problemas en el entorno educativo.

Para más información y manual de uso de la aplicación, consulte el [ReadMe del repositorio de Iris móvil](https://github.com/Tania105/Android_Grupo1).


## Apliación de Escritorio
Nuestra aplicación de escritorio en Windows Form .NET es una herramienta poderosa diseñada para brindar una experiencia eficiente y conveniente en la gestión de incidencias en el entorno educativo del Instituto Miguel Herrero de Pereda. Con una interfaz intuitiva y funcionalidades robustas, nuestra aplicación permite al profesorado y al equipo administrativo registrar, gestionar y resolver problemas relacionados con equipos, conexiones o cuentas del centro de manera eficaz y oportuna. Desde la asignación de tareas hasta el seguimiento del progreso de las incidencias, nuestra aplicación de escritorio es una herramienta indispensable para mantener el funcionamiento fluido del instituto.

### Características

El proyecto IRIS está diseñado para proporcionar una solución completa para la gestión de incidencias en el entorno educativo del Instituto Miguel Herrero de Pereda. La aplicación móvil ofrece una serie de características que ayudan a los usuarios(profesorado)a gestionar eficazmente las incidencias y resolver los problemas de manera inteligente y segura. Algunas de las principales características incluyen:

1. Gestión avanzada de incidencias: 
Los administradores pueden gestionar y resolver incidencias de manera centralizada desde el escritorio.
2. Asignación de tareas: 
Los administradores pueden asignar tareas y seguimiento a los miembros del equipo para resolver las incidencias de manera eficiente.
3. Seguridad integrada: 
La aplicación de escritorio ofrece características de seguridad avanzadas para proteger la información sensible y garantizar la integridad de los datos.

### Uso

#### Gestión de incidencias:

Abre la aplicación de escritorio IRIS en tu computadora.
Inicia sesión con tus credenciales de administrador.
Utiliza la interfaz de usuario para ver y gestionar las incidencias registradas por el profesorado.
Asigna tareas y seguimiento para resolver las incidencias de manera eficiente.

#### Seguridad integrada:

La aplicación de escritorio IRIS ofrece características de seguridad avanzadas para proteger la información sensible y garantizar la integridad de los datos.
Inicia sesión con tus credenciales de administrador para acceder a las funciones de seguridad.

## Miembros

- Tania Chocán (Desarrollador principal)
  - GitHub: [Tania105](https://github.com/Tania105)
  - Correo de contacto: [tania.chocanalexandre@iesmiguelherrero.com](mailto:tania.chocanalexandre@iesmiguelherrero.com)

- Raúl Casas Gómez (Desarrollador principal)
  - GitHub: [RaulKas07](https://github.com/RaulKas07)
  - Correo de contacto: [raul.casasgomez@iesmiguelherrero.com](mailto:raul.casasgomez@iesmiguelherrero.com)

- Miguel Ángel Calderón (Desarrollador principal)
  - GitHub: [miguelangelcalderon3](https://github.com/miguelangelcalderon3)
  - Correo de contacto: [miguelangel.calderonzuleta@iesmiguelherrero.com](mailto:miguelangel.calderonzuleta@iesmiguelherrero.com)

- Ignacio Sáez González (Desarrollador principal)
  - GitHub: [Ignaciosgh](https://github.com/Ignaciosgh)
  - Correo de contacto: [ignacio.saezgonzalez@iesmiguelherrero.com](mailto:ignacio.saezgonzalez@iesmiguelherrero.com)  

- Diego Sañudo Rodríguez (Desarrollador principal)
  - GitHub: [naego-sarophiel](https://github.com/naego-sarophiel)
  - Correo de contacto: [diego.sanudorodriguez@iesmiguelherrero.com](mailto:diego.sanudorodriguez@iesmiguelherrero.com) 

- Isaac Cabria Díez (Desarrollador principal)
  - GitHub: [isaac640](https://github.com/isaac640)
  - Correo de contacto: [isaac.cabriadiez@iesmiguelherrero.com](mailto:isaac.cabriadiez@iesmiguelherrero.com) 

Agradecemos a todos los miembros del equipo por su arduo trabajo y dedicación en el desarrollo y mantenimiento de este proyecto.

## Contribución

Si deseas contribuir al proyecto, sigue estos pasos:

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b el-nombre-de-tu-rama`).
3. Realiza tus cambios y haz commit (`git commit -am 'He cambiado el diseño de la pantalla inicial'`).
4. Haz push a la rama (`git push origin el-nombre-de-tu-rama`).
5. Crea un nuevo Pull Request.

Si las contribuciones son efectivas y corrigen u optimizan en algún sentido el código base, se añadirán a la rama main y pasarás a ser parte del apartado de miembros como colaborador.

## Contacto

Si tienes alguna pregunta, sugerencia o problema, no dudes en contactarnos a través de:

- Correo electrónico: [contacto@iris.com](mailto:contacto@iris.com)
- Twitter: [@ProyectoIris](https://twitter.com/ProyectoIris)
- Discord: [Servidor de Discord del Proyecto](enlace-al-servidor-de-discord)
- [Foro de discusión del proyecto](https://www.ProyectoIris.com/foro)
- [Formulario de contacto en mi sitio web](https://www.ProyectoIris.com/contacto)


## Licencia

Este proyecto está licenciado bajo la [Licencia MIT](LICENSE).

La Licencia MIT es una licencia de software libre que permite a los usuarios utilizar, modificar y distribuir el software con pocos o ningún requisito. Bajo esta licencia, los usuarios pueden hacer lo que deseen con el software, siempre y cuando se incluya el aviso de copyright y la renuncia de garantía.

Para obtener más detalles, consulta el [texto completo de la Licencia MIT](https://opensource.org/licenses/MIT).

Agradecemos a los autores de la Licencia MIT por proporcionar una estructura legal que permita compartir nuestro trabajo con otros de manera abierta y accesible.

