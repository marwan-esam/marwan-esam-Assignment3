# Part G: Short Answer

**1. Paste your .csproj contents and confirm each of the four properties mentioned in Part A is present.**
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
*Confirmed: OutputType, TargetFramework, ImplicitUsings, and Nullable are all present.*

**2. Do #region / #endregion change the compiled output? Why might you still use them?**
No, regions do not change the compiled output at all. You might use them to hide large chunks of code (like fields, boilerplate, or interface implementations) so you can quickly scan a class by collapsing them in your editor.

**3. When would you reach for /// XML doc comments instead of a plain //?**
You would reach for XML comments if you want to document a class or a method so its description shows up when hovering over it (IntelliSense). They can also be extracted into separate files to automatically generate API documentation websites.

**4. Why does C# have no true global variables, and what's the closest equivalent?**
C# is strictly an object-oriented language, meaning every piece of data and behavior must live inside a type (like a class or struct). The closest equivalent to a global variable is using a `public static` field or property on a class, which allows it to be accessed globally without having to instantiate a new object.
