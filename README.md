# c-pokemon
messing about with c

Record of setup: 
- making directories src and test
- in test: making PokemonGame.Test folder and running `dotnet new xunit` to... create a new xunit project, surprisingly. 
- in src: making PokemonGame folder and running `dotnet new console` to create a new console project. Again, surprisingly. 
- in root folder: running `dotnet new sln`, which creates a new .sln file, where I can add projects to execute in one go.
- `dotnet sln add <path>` for both PokemonGame.Test and PokemonGame projects. 
- `dotnet build` to make sure it works; this command will build all projects which were added to the .sln file and run all the tests found. In this way I don't need to navigate folders, run build and test commands separately.

Current folder structure: 
C-Pokemon
|__.vscode
|__src
  |__PokemonGame
    |__bin
    |__obj
    |__PokemonGame.csproj
    |__Program.cs
|__test
  |__PokemonGame.Test
    |__bin
    |__obj
    |__PokemonGame.Test.proj
    |__UnitTest1.cs (to be renamed)
|__c-pokemon.sln
|__LICENSE
|__README.md


