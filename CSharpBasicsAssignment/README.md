# C# Basics Assignment

This repository contains a C# console application built to demonstrate foundational C# concepts, including project structure, the type system, memory management, and operators.

## Assignment Structure

The project is divided into several focused parts, all executed from `Program.cs`:

* **Part A: Project & Structure** 
  Demonstrates an understanding of C# project files (`.csproj`, `obj/`, `bin/`), solution formats (`.sln` vs `.slnx`), and file-scoped namespaces.
* **Part B: Variables, Types & Casting**
  Explores C#'s type system, including implicit and explicit conversions, the integer division trap, boxing and unboxing, and string parsing using `TryParse`.
* **Part C: Value vs. Reference Types**
  Proves the behavioral differences between structs (value types copied on the stack) and classes (reference types pointing to the heap) using custom `Point` and `Order` types.
* **Part D: Scope & Operators**
  Exercises field, method, and block scope. Also covers compound assignment operators and bitwise logic (`&`, `|`, `^`), including an explanation of short-circuit evaluation.
* **Part E: Draw the Stack & Heap**
  Contains a separate `STACK_HEAP.md` file with ASCII diagrams mapping out exactly how objects and references are allocated in memory line-by-line.
* **Part F: LeetCode Problem**
  An optimized, linear-time $O(N)$ and constant-space $O(1)$ solution to LeetCode 136 (Single Number) utilizing the bitwise XOR (`^`) operator.
* **Part G: Short Answer**
  Contains a separate `ANSWERS.md` file addressing theoretical questions about compilation, XML documentation, and C#'s object-oriented nature.

## How to Run

Ensure you have the .NET SDK installed. Navigate to the project directory and run:

```bash
dotnet run
```
