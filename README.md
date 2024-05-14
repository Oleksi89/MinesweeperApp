# MinesweeperApp

### The classic functionality of the "Minesweeper" game has been implemented and some functionality has been added.

#### Classic Minesweeper main rules:

 - To start the game again, click on the yellow smiley face.
 - To reveal the cell press the left mouse button on it
 - To flag a cell as a suspected mine, press the right mouse button on it.
 - The goal of the game is to open all the cells that do not contain mines.
 - It is not necessary to place flags!

## Launching the program

To launch the program, you only need to compile the project.

After compiling the project, to ensure the game statistics are not empty, you can move the [gamesHistory.dat](./GamesHistoryData/gamesHistory.dat) file to the directory with the executable file of the project.


## Program Functionality

### Main Form

When launching the program, a board is immediately generated with saved settings (by default - easy difficulty level, other parameters are disabled)

The Pause menu button, the "Game Preparation" button (yellow smiley) and inscriptions that correspond to the count of unmarked mines and the game timer are available.

To start the game, you need to press LMB on any cell.

When App  is closing it saves current game settings. 

When clicking on the Pause menu button, the game timer will pause (if the game has started), the cells will become unavailable for clicks and the Pause Menu will appear.

### Pause Menu

In the **Pause Menu**, the following options are available:

### Resume game

### Settings

In the **Settings**, we can view, change and apply the appropriate settings to the game (when applied, the game will restart).

 -  **Easy**. Board generates 9x9 with 10 mines.
 
 -  **Medium**. Board generates 16x16 with 40 mines.

 -  **Hard**. Board generates 30x16 with 99 mines.

  - [ ] **Safe start**. The first time you click on any cell, that cell will always 
be empty and a large zone will open. If this setting is disabled, the playing
 field is formed completely randomly, so on the first click there may be
 a number or even a mine!

 - [ ] **Safe zone**. If you click on the number displaying the number of 
surrounding mines marked with flags, the remaining adjacent cells 
will open. If this setting is disabled, clicking on a number will do nothing.

 - [ ] **Revealing the remaining ones**. If you find all the mines and mark 
them with flags, and the remaining mines indicator shows "000",
 you can click on it and all the remaining cells will open.

 - [ ] **Neutralization**. If you click on the mine, you won`t end the game. If this 
 setting is disabled, you simply loose outright.

### Game statistics

In the **Statistics**, we can view the results and statistics of past games by filters.

### Rules and tips

In **Rules and tips**, you can view useful tips and explanations of game settings.

### Exit from the application

## Design Patterns

### Singleton

Used to create only one game object: [Game](./Main/GameLogic/Game.cs#L10)

### Observer

Used to notify the UI of game changes (game preparation, win, loss, pause, resume) [Observer](./Main/GameLogic/Observers)

### Factory Method

[CellFactory](./Main/GameLogic/Cells/CellFactory.cs) - This is a factory class that has a static createCell method. This method accepts the cell type and its coordinates.

Based on the transferred cell type, it creates the corresponding object.

Depending on the type of game, it creates an EmptyCell, MineCell, or NumberCell class object.


### Strategy

The "strategy" pattern is used in the logic of substituting the parameters of the board generation depending on the chosen difficulty of the game. [DifficultyLevelStrategy](./Main/GameLogic/DifficultyLevelStrategy)

### Lightweight

The "lightweight" pattern allows to save memory when changing the [CellControl](./Main/Controls/CellControl.cs) display. 

The [CellAppearanceFactory](./Main/CellAppearance/CellAppearanceFactory.cs) class stores already created [CellAppearance](./Main/CellAppearance/CellAppearance.cs) objects in the _appearances dictionary and reuses them when an object of the same type needs to be created.

 So, when changing the display of a CellControl with the same CellAppearance types, a new image will not be initialized, but the same CellAppearance object will be used.


## Refactoring Techniques

###  Extract Method

During the development phase, it was often used to avoid code duplication.

### Inline Method

During the development phase, it was used to simplify the understanding of the code.

### Inline Temp

During the development phase, it was used to reduce the size of the code.

### Move method 

Methods that didn`t related to class were moved.

### Rename method 

 Was often used to set methods names that are describing actual method functionality.

### Move Field

During the development phase, it was used to simplify the code, improve logic, and align the field with the class.

## Programming Principles

### Single Responsibility

Majority of classes have only one purpose.

### Open/Closed Principle
Majority of classes are open for extending, but closed for changes.

### Interface Segregation Principle

Each class do not contains unnecessary methods for child classes.

### Dependency Inversion Principle

The Game class [depends](./Main/GameLogic/Game.cs#L19) on the [IGameHistorySaver](./Main/GameHistory/IGameHistorySaver.cs) abstraction, not on the concrete [JsonGameHistorySaver](./Main/GameHistory/JsonGameHistorySaver.cs) class.

### KISS

The code is simple and clear. It does not include complex or obscure structures.

### DRY
Solution doesn`t contains repeating code, classes are well-structurized.
