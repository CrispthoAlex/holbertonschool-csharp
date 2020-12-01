#!/usr/bin/env bash
# Script that initializes a new C# project inside a folder titled 0-new_project

# Create folder and enter it
mkdir -p 0-new_project; cd 0-new_project
dotnet new console
cd ..
