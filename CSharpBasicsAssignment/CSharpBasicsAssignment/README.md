# CSharpBasicsAssignment

A C# console application created for **Assignment 4: Console Apps, Types & Memory Model**.

The project demonstrates the main topics covered in Lecture 01, including project structure, variables and data types, casting, value vs. reference types, scope, operators, and the basic stack/heap memory model.

## Technologies

- C#
- .NET 10
- Console Application

## Assignment Parts

### Part A — Project & Structure
Covers:
- `.csproj`
- `Program.cs`
- `bin/`
- `obj/`
- `.slnx` solution format
- project configuration properties

### Part B — Variables, Types & Casting
Covers:
- `int`
- `long`
- `double`
- `decimal`
- `bool`
- `char`
- `string`
- `var`
- implicit conversion
- explicit conversion
- integer division
- boxing and unboxing
- parsing with `Parse` and `TryParse`
- `float` to `decimal` casting

### Part C — Value vs. Reference Types
Includes:
- `Point` struct
- `Order` class
- struct copy semantics
- class reference semantics
- `object.ReferenceEquals`
- stack and heap explanation

### Part D — Scope & Operators
Covers:
- field scope
- method scope
- block scope
- compound assignment operators
- bitwise `&`, `|`, and `^`

### Part E — Stack & Heap
The `STACK_HEAP.md` file contains three diagrams showing how `o1` and `o2` reference the same `Order` object on the heap.

### Part F — Single Number
Implements `FindSingleNumber(int[] nums)` using the XOR (`^`) operator.

Example:

```text
Input:  [4, 1, 2, 1, 2]
Output: 4
```

### Part G — Short Answers
The `ANSWERS.md` file contains the required short-answer questions about:
- project configuration
- `#region` / `#endregion`
- XML documentation comments
- global variables in C#

## Project Structure

```text
CSharpBasicsAssignment/
├── CSharpBasicsAssignment.csproj
├── Program.cs
├── Order.cs
├── STACK_HEAP.md
├── README.md
└── ANSWERS.md
```

## How to Run

Open a terminal inside the project folder and run:

```bash
dotnet run
```

## Author

Shams Ashraf
