# ConsoleHangman

ConsoleHangman is a command-line based Hangman game developed in C# using .NET 6. It offers a classic hangman gameplay experience with additional features like hints for each word and enhanced visual display.

## Features

- Command-line Hangman game with random word selection.
- Hints provided for each chosen word.
- ASCII art representing the game title.
- Display of already guessed letters and user input handling.
- Docker utilization for easy deployment and execution.

## Prerequisites

To run this project, you will need:

- .NET 6 SDK
- Docker (for running via Docker container)

## Installation and Execution

**Cloning the Project:**

```bash
git clone https://your_repo.git
cd ConsoleHangman
```

**Local Execution:**

```bash
dotnet run
```

**Execution via Docker:**

Build the Docker image:

```bash
docker build -t consolehangman .
```

Run the Docker container:

```bash
docker run --name consolehangman-container -it consolehangman
```

## Usage

Launch the game and then follow the on-screen instructions to enter letters. The game will indicate whether your attempts are correct or not, and you will be able to see the already tried letters as well as the remaining number of attempts.