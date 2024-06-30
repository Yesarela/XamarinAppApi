# XamarinApiApp

## Descripción
Aplicación móvil creada con Xamarin Forms que consume una API creada con .NET Core y SQL Server en Azure.

## Pre-Requisitos
- Visual Studio 2022
- .NET Core SDK
- Cuenta de Azure

## Configuración del Proyecto

### API con .NET Core
1. Crear un nuevo proyecto de ASP.NET Core Web API.
2. Configurar cadena de conexión en `appsettings.json`.
3. Crear el modelo y el contexto de base de datos.
4. Crear el controlador de la API.

### Aplicación de Xamarin
1. Crear un nuevo proyecto de Xamarin Forms.
2. Instalar el paquete NuGet `System.Net.Http`.
3. Crear el servicio para consumir la API.
4. Crear el modelo, vista y ViewModel.

## Despliegue
1. Publicar la API en Azure App Service.
2. Configurar la URL base de la API en la aplicación de Xamarin.

## Ejecución
1. Ejecutar la aplicación en un emulador o dispositivo.