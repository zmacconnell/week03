# HiLo Game
HiLo is a simple game of guessing and calculated risk. The game
starts by shuffling a deck of cards and returns a value between
1-13. You goal is to properly guess if the next card that gets 
shown is higher or lower than the current one. A correct guess
gets you 100 points, whereas an incorrect one takes 75 points 
away. Reach 0 points and you're out!

## Project Structure
---
The project files and folders are organized as follows:
```
root                    (project root folder)
+-- Game                (source code folder)
+-- Program.cs          (program entry point)    
+-- README.md           (general info)
+-- week03.csproj       (dotnet project file)
```

## Required Software
---
* dotnet 6.0

## Author
---
Zach MacConnell (mac21007@byui.edu)

# Randomly shuffles a "deck" of cards and returns a number between 1-13
# Asks for a user input of "h" or "l" indicating higher or lower respectively
# Randomly shuffles again and awards/negates points based on if the users input was correct
# Asks the user if they want to continue playing
# Ends if the user says they don't want to continue playing or if their score drops below 0
