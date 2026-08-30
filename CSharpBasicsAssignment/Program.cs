/*
  .csproj: A project-specific configuration file that includes: the SDK used, Framework version, Output type, Whether
    implicit usings are enabled, And whether reference types are nullable
*/

/*
  Program.cs: Contains the Main method entry point for the entire project
*/

/*
  obj/: A folder that holds temporary, and unlinked object files and metadata such as the individual, and intermediate
    .dll files. This folder acts as a cache storing builds so when rebuilding the project, it checks for only the modified files
    compiling only what changes.
*/

/*
  bin/: A folder that holds the final executable application (.exe and class library .dll) after linking completes. 
*/


/*
  This project uses the newer .slnx format. An advnatage of using the .sln format would be backward compatibility
  and widespread tooling support. Older tools have been configured to correctly identify and deal with the .sln format.
  The newer .slnx format is still preview, meaning older tools might fail to open or build the solution.
*/

// Note: I removed the line below because C# does not allow a file-scoped namespace in the same file as top-level statements
// namespace CSharpBasicsAssignment; // This line ending with a semicolon replaces the one with curly braces, preventing the entire file contents from being intended.

Console.WriteLine("=== PART A: Project & Structure ===");