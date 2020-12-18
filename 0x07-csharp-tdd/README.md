![](https://cdn.lynda.com/courses/459492-637286209528406996_338x600_thumb.jpg)

# 0x07. C# - Test Driven Development

# Resources
#### Read or watch:

* Unit Testing Tutorial for C# Developers
* TDD Basics with C#
* Unit Testing C# with NUnit and .NET Core
* NUnit Documentation
* NUnit.Framework Documentation
* NUnit Cheat Sheet
* When to use static classes in C#


## Learning Objectives

## General

* What are solutions in VSCode
* How are solutions different from projects in VSCode
* What is a class library
* What is a unit test
* What are the benefits of unit testing
* How to create and run tests using NUnit
* What is the Arrange, Act, Assert methodology
* How to effectively name your unit tests
* How to utilize the TDD approach
* How to consider edge cases

## Requirements
### C# Tasks
* Allowed editors: ``Visual Studio Code``.
* All files will be compiled on Ubuntu 14.04 LTS using ``dotnet``.
* A ``README.md`` file, at the root of the folder of the project, is mandatory.
* All default C# files named ``Program.cs`` should be renamed to the name given in each task
* Each C# task requires its own folder and .csproj file. Push all task folders to your Github and ensure the task names on the folders are correct.
* You do not need to push your ``obj/`` or ``bin/`` folders.
* In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples.
* All your public classes and their members should have XML documentation tags
* All your private classes and members should be documented but without XML documentation tags

# C# Tests
* Allowed editors: Visual Studio Code
* All tests should be inside a separate folder and named as specified in each task
* All your test files will be executed using dotnet test
* We strongly encourage you to work together on tests so that you don’t miss any edge cases

# More Info

For each task in this project:

1. Create task directory (ex: 0-add)
2. Inside that directory, run dotnet new sln
3. Create a new directory for your task solution based on the namespace given (ex: MyMath). This directory will hold your class library.
4. Inside that directory, run dotnet new classlib. Rename the resulting .cs file after the namespace (ex: MyMath.cs)
5. Enable XML documentation by adding <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile> to MyMath.csproj
6. Change directory back to the root directory of the task (ex: 0-add) and run dotnet sln add <classlibrary/classlibrary.csproj> (ex. dotnet sln add MyMath/MyMath.csproj)
7. Create a new directory for your tests based on the namespace given plus .Tests (ex: MyMath.Tests). This directory will hold your test library.
8. Inside that directory, run dotnet new nunit. Rename the resulting .cs file after the namespace of classes you are testing plus .Tests (ex: MyMath.Tests.cs)
9. To add your class library as a dependency to the project, run dotnet add reference <../classlibrary/classlibrary.csproj> (ex: dotnet add reference ../MyMath/MyMath.csproj)
10. In the task’s root directory, run dotnet sln add <testlibrary/testlibrary.csproj (ex: dotnet sln add MyMath.Tests/MyMath.Tests.csproj)
11. If you’d like to run your class library method in a console application, create a new directory and run dotnet new console inside it. Run dotnet add reference <../classlibrary/classlibrary.csproj> and you can then call your class library methods inside the console application.

For more detail, read the Unit Testing C# with NUnit and .NET Core tutorial.

The resulting directory hierarchy for task #0 will look like this:

````
/0-add
    0-add.sln
    /MyMath
        MyMath.cs
        MyMath.csproj
    /MyMath.Tests
        MyMath.Tests.cs
        MyMath.Tests.csproj

````
| **Filename** | **Description** |
|---|---|
| [0. Add integers](./0-add/) | method that adds 2 numbers. |
| [1. Divide a matrix](./1-divide/) | method that divides all elements of a matrix. |
| [2. Max integer](./2-max_int/) | method that returns the max integer in a list of integers. |
| [3. Desserts, I stressed!](./3-palindrome/) | method that returns True if a string is a palindrome or False if it’s not. |
| [4. Unique character](./4-unique/) | method that returns the index of the first non-repeating character of a string. |
| [5. camelCase](./5-camelcase/) | method that determines how many words are in a string. |

#### Follow me 💬

| Authors | GitHub | Twitter | Linkedin |
| :---: | :---: | :---: | :---: |
| Crispthofer Rincon | [crispthoalex](https://github.com/crispthoalex) | [@crispthoalex](https://twitter.com/crispthoalex) | [carmurrain](https://www.linkedin.com/in/carmurrain) |

### License
*`0x07. C# - Test Driven Development` is open source and therefore free to download and use without permission.*

<a href="url"><img src="https://www.holbertonschool.com/holberton-logo.png" align="middle" width="100" height="30"></a>

##### Holberton School – Advanced Program – AR/VR
##### December, 2020. Cali, Colombia