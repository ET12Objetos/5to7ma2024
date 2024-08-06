## Comandos Útiles

Crear proyecto de Biblioteca:

```sh
dotnet new classlib -n NombreProyecto
```

Crear proyecto de Consola:

```sh
dotnet new console -n NombreProyecto
```

Vincular proyecto de biblioteca con el proyecto de consola:

```sh
dotnet add ProyectoConsola/ProyectoConsola.csproj reference ProyectoBiblioteca/ProyectoBiblioteca.csproj
```

## Importante

- Recordar que cada proyecto se debe crear en carpetas independientes y se deben encontrar al mismo nivel.
- Para hacer uso de las clases del **Proyecto de Biblioteca** en el **Proyecto de Consola** se debe importar la dependencia en la clase correspondiente con la palabra reservada `using NombreProyectoBiblioteca;` al comienzo de la clase.
- La dependencia entre proyectos siempre debe ser desde el **Proyecto de Consola** hacia el **Proyecto de Biblioteca**.
- El **Proyecto de Consola** se ejecuta  y compila mientras que el **Proyecto de Biblioteca** unicamente se compila.
- Para verificar si la dependencia entre proyecto se creo correctamente, se debe revisar el archivo **.csproj** del **Proyecto de Consola** y debe tener el siguiente contenido:
```xml
  <ItemGroup>
    <ProjectReference Include="..\NombreProyectoBiblioteca\NombreProyectoBiblioteca.csproj" />
  </ItemGroup>
```