# CSharp.15.AbstractClasses

Para que haya una clase abstracta debe existir herencia:
```csharp
public class Cuadrado : Pieza
```

En la clase base pueden existir 
```csharp
public abstract // este metodo no puede tener logica de negocio
public virtual // tiene logica de negocio en la clase base y tb puede ser implementado en la clase hija
```

Para implementar en la clase hija se debe implementar el metodo declarado en la clase base de esta manera: 
```csharp
public override decimal Area()
```

Para que exista Polimorfismo se debe instanciar de esta manera: Clase base = new Clase Hija
```csharp
Pieza cuadrado2 = new Cuadrado(12);
```
