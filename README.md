# c#-pokemon
messing about with c# by replicating base functionality of Pokemon, writing up commentary as I go along. 

## Record of setup: 
- making directories src and test
- in test: making PokemonGame.Test folder and running `dotnet new xunit` to... create a new xunit project, surprisingly. 
- in src: making PokemonGame folder and running `dotnet new console` to create a new console project. Again, surprisingly. 
- in root folder: running `dotnet new sln`, which creates a new .sln file, where I can add projects to execute in one go.
- `dotnet sln add <path>` for both PokemonGame.Test and PokemonGame projects. 
- `dotnet build` to make sure it works; this command will build all projects which were added to the .sln file. Then can run `dotnet test` to run all tests. In this way I don't need to navigate folders, run build and test commands separately.

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

## Set up cont...
- link PokemonGame with PokemonGame.Test projects using `dotnet add reference ../../src/PokemonGame/PokemonGame.csproj` in PokemonGame.Test folder. 

## Working on Trainer Class

Concept: An abstract Trainer class which has a name and a pocket to store Pokemon. Extends to create Player and NPTrainer. Player class has a personality, and NPTrainer has animosity level.

Implementation: 
- Trainer.cs contains abstract class with base set up. This cannot be tested without being extended, as abstract.
- Player.cs extends Trainer.cs and adds personality. 
- Testing for base properties, as well as personality. 
- The compiler prevents a lot of foolishness pretty much there and then, so difficult to see a test fail before passing. 

## Working on Pokemon Class 

Concept: Pokemon class provides base stats, neutral type, and can be changed if made a specific type
- Neutral - basic stats: attack: 5, HP: 20, evade: 0.2
- Fire - Higher attack, lower HP, basic chance to evade, weak against Water
- Water - Basic attack and HP, Higher chance to evade, weak against Grass
- Grass - Lower attack, higher HP, basic chance to evade, weak against Fire

- Pokemon abilities: generic attack and special attack. Extended classes must be able to override base class. 

Implementation: 
- Pokemon base class in Pokemon.cs, stats as above. Added sound property with default value and private set method, cannot be changed outside of constructor. 
- The need for a separate pokemon folder has arisen, so all pokemon now exist there. 
- File for each different pokemon, which will make more sense once methods are added.
- Most pokemon attributes are fields, which can be overridden and are in extending classes' constructors. Maintaining default value of sound throughout extensions. 

- _All fields in Pokemon changed to properties, to apply encapsulation and protect the setting of the attributes. ATM using generic get and set property methods, .NET provides the background private fields automatically. 'set' property added as 'internal', if 'private' nothing can change it, but I want to be able to change it from extending classes, so with restriction level of 'internal' that can now happen. 'get' is public. Attributes cannot be chanced outside the class chain._

## Trainers cont
- Trainers now have their own folder
- Non-Playable Trainer class in respective file, have animosity, which will determine how likely they are to flee a fight

## Battle
Concept:
- keeps track of turn
- meets two trainers who have caught pokemon
- attack method for a single attack
- fight method which repeats attack and swaps turn until one pokemon has fainted
- method to calc if missed
- method to calc damage
- ability to choose which skill to use? default to base attack


Implementation
- protected turn property
- does take trainer instances
- methods work as expected, not implemented choosing skill _yet_
- not quite sure how to test battle class.....

### Changes after working on Battler: 
- Pokemons now have names.
- changed access modifier of Pokemon attributes to protected so only changeable in class and derived classes, apart from Health, which is internal as needs to change during battle. 