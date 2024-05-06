# Binary Game

This is a binary game created in VB.NET to help students learn how to translate binary into denary.

## Project Structure

The project is structured as follows:

- `Binary Game/` - The main project directory.
    - `App.config` - The application configuration file.
    - `Binary Game.vbproj` - The Visual Basic project file.
    - `Difficulty select.vb` - The code for the difficulty selection screen.
    - `Game.vb` - The main game logic is contained in this file.
    - `GameOver.vb` - The code for the game over screen.
    - `Instructions.vb` - The code for the instructions screen.
    - `Module1.vb` - A module file.
    - `Form1 - Copy.vb` - A form file.
    - `Form2.vb` - Another form file.
    - `Easy_highscore.txt`, `Med_highscore.txt`, `Hard_highscore.txt` - Text files for storing high scores for each difficulty level.

## Game Logic

The game logic is primarily contained in the `Game.vb` file. It includes functions for generating random binary numbers for different difficulty levels:

- `Easy_mode()` - Generates a 4-bit binary number.
- `Medium_mode()` - Generates a 6-bit binary number.
- `Hard_mode()` - Generates an 8-bit binary number.

The binary number is displayed to the user, who must then translate it into denary.

## Scoring

When the game is over, the user's score is written to a text file corresponding to the difficulty level they played at. This is handled in the `GameOver.vb` file.

## Building the Project

The project can be built using Visual Studio. The output path for the build is specified in the `Binary Game.vbproj` file. The project is configured to build for any CPU, and the output is placed in the `bin\Debug\` or `bin\Release\` directory, depending on the build configuration.

## Running the Project

To run the project, execute the `Binary Game.exe` file in the output directory of the build.# Binary Game

This is a binary game created in VB.NET to help students learn how to translate binary into denary.

## Project Structure

The project is structured as follows:

- `Binary Game/` - The main project directory.
  - `App.config` - The application configuration file.
  - `Binary Game.vbproj` - The Visual Basic project file.
  - `Difficulty select.vb` - The code for the difficulty selection screen.
  - `Game.vb` - The main game logic is contained in this file.
  - `GameOver.vb` - The code for the game over screen.
  - `Instructions.vb` - The code for the instructions screen.
  - `Module1.vb` - A module file.
  - `Form1 - Copy.vb` - A form file.
  - `Form2.vb` - Another form file.
  - `Easy_highscore.txt`, `Med_highscore.txt`, `Hard_highscore.txt` - Text files for storing high scores for each difficulty level.

## Game Logic

The game logic is primarily contained in the `Game.vb` file. It includes functions for generating random binary numbers for different difficulty levels:

- `Easy_mode()` - Generates a 4-bit binary number.
- `Medium_mode()` - Generates a 6-bit binary number.
- `Hard_mode()` - Generates an 8-bit binary number.

The binary number is displayed to the user, who must then translate it into denary.

## Scoring

When the game is over, the user's score is written to a text file corresponding to the difficulty level they played at. This is handled in the `GameOver.vb` file.

## Building the Project

The project can be built using Visual Studio. The output path for the build is specified in the `Binary Game.vbproj` file. The project is configured to build for any CPU, and the output is placed in the `bin\Debug\` or `bin\Release\` directory, depending on the build configuration.

## Running the Project

To run the project, execute the `Binary Game.exe` file in the output directory of the build.