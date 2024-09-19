# Number game
This C# console application presents a classic number guessing game. The computer randomly selects a number within a specified range, and the player's objective is to guess this correct number. To cater to different skill levels, the game offers three difficulty settings: Easy, Medium, and Hard.

## Gameplay:

- **Difficulty Selection:** Upon starting the game, players are prompted to choose their desired difficulty level.
  - **Easy:** A smaller range of numbers and more attempts are provided, making it accessible to beginners.
  - **Medium:** A bigger range and fewer attempts are offered, increasing the challenge.
  - **Hard:** The highest range and minimum effort, designed for experienced players seeking a significant challenge.

- **Number Generation:** Once a difficulty is selected, the game generates a random number within the corresponding range.

- **Guessing:** Players are then asked to input their guesses. After each guess, the game provides feedback indicating whether the guessed number is too high, too low, or correct.

- **Win or Lose:** If the player correctly guesses the number within the allotted attempts, they win the game otherwise they lose. 

- **Replay:** Players can choose to replay the game after winning or losing or just quite the game.

## Potential Enhancements:
- Allow the player to choose the difficulty level without deciding how they type Easy, Medium and Hard.
- Implement a count of number of attempts made by the player and show the result in the end of the game.
