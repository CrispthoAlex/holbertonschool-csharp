#!/usr/bin/env bash
# Script that initializes, builds, and runs a new C# project from a folder titled 2-new_project

# Create folder and enter it
mkdir -p 2-new_project; cd 2-new_project
dotnet new console
sleep 3
dotnet build
sleep 2
dotnet run
cd ..
