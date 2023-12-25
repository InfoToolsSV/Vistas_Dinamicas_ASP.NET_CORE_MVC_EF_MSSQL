
# ASP.NET Core MVC - Vistas Dinámicas con Entity Framework

Este proyecto explora la creación de vistas dinámicas en ASP.NET Core MVC utilizando Entity Framework para interactuar con una base de datos SQL Server. Se demuestra cómo combinar .ToList() y .FirstOrDefault() para lograr una presentación dinámica de datos en las vistas.

## Tech Stack

- ASP.NET Core MVC
- Entity Framework
- C#
- SQL Server
## Patrón de arquitectura MVC

El proyecto sigue la arquitectura MVC (Model-View-Controller) de ASP.NET Core.
## Archivos del Proyecto

- HomeController.cs: Controlador principal que maneja las solicitudes y contiene acciones para la presentación dinámica de datos.

- Producto.cs: Modelo que define la estructura de los productos.

- ProductosViewModel.cs: ViewModel para manejar la presentación dinámica de datos en las vistas.

- Detalles.cshtml: Vista que muestra la lista de productos y los detalles del producto seleccionado.

## Instrucciones de Ejecución

Para ejecutar y probar este proyecto, siga estos pasos:

1. Asegúrese de tener instalados el .NET Core SDK y Visual Studio Code en su sistema.

2. Clone este repositorio en su máquina local.

3. Abra el proyecto en Visual Studio Code.

4. Configure la cadena de conexión de la base de datos en el archivo appsettings.json.

5. Ejecuta el comando dotnet ef database update para aplicar las migraciones y crear la base de datos.

6. Ejecute el proyecto con el comando dotnet run.

7. Abra su navegador web y vaya a https://localhost:5001 para acceder a la aplicación.
## License

Este proyecto se distribuye bajo una **Licencia Educativa** que permite el uso exclusivamente con fines educativos. No está permitido vender el proyecto ni compartirlo con fines comerciales. La licencia no permite la redistribución o el uso del proyecto en aplicaciones comerciales o de producción.

## Agradecimientos Especiales

Quiero expresar mi profundo agradecimiento a los miembros del canal InfoToolsSV que han sido una parte fundamental de este proyecto. Su apoyo constante y entusiasta ha sido una fuente de inspiración y motivación para crear no solo este proyecto, sino también mis videos y contenido educativo. 

Agradezco su tiempo, sus valiosas sugerencias y comentarios, y su continua participación en este viaje de aprendizaje y crecimiento. Sin su apoyo, este proyecto no sería posible.

Gracias por ser una comunidad tan comprometida y apasionada. Espero que este proyecto y mi contenido continúen siendo de utilidad para todos ustedes. ¡Sigamos construyendo juntos!
