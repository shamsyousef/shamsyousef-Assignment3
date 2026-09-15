# Part G — Short Answers

## 1. Project Configuration

My `.csproj` file contains:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

The required properties are present:

- `OutputType` is set to `Exe`.
- `TargetFramework` is set to `net10.0`.
- `ImplicitUsings` is enabled.
- `Nullable` is enabled.

## 2. Do #region / #endregion change the compiled output?

No. `#region` and `#endregion` do not change the compiled output.

They are only used to organize and collapse sections of code in the editor, which can make large files easier to read.

## 3. When would you use /// XML documentation comments instead of //?

I would use `///` XML documentation comments when I want to document classes, methods, properties, or parameters in a way that tools and IntelliSense can understand.

A normal `//` comment is mainly for developers reading the source code.

## 4. Why does C# have no true global variables, and what is the closest equivalent?

C# organizes code inside types such as classes and structs, so variables normally belong to a type or a method instead of existing as true global variables.

The closest equivalent is a `static` field or property in a class, because it can be accessed without creating an object of that class.
