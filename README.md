### Comandos


Para crear un proyecto
```
dotnet new project_template
```

Para crear un nuevo proyecto indicandole el nombre. Estariamos creando un proyeto con nombre 'Dependencies' utilizando la template 'webapi'
```
dotnet new webapi -n Dependencies
```

No devuelve una lista de templates que podemos utilizar
```
dotnet new --list
```

Para ejecutar el proyecto
```
dotnet run
```

Compila un proyecto y todas sus dependencias, tambien verificar que toda la sintaxis este bien y no se tengan problemas con dependencias
```
dotnet build
```

Para restaurar las dependencias o las librerias del proyecto
```
dotnet restore
```

Nos permite ejecutar el proyecto y va revisando los cambios del proyecto en tiempo real (similar a nodemon en node)
```
dotnet watch run
```


https://www.nuget.org/