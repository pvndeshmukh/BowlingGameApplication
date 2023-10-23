## Problem Statement
Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces 
the total score for the game. Here are some things that the program does not need to do:
• Does not need to check for valid rolls.
• Does not need to check for correct number of rolls and frames.
• Does not need to not provide scores for intermediate frames.
You can find more information about how a bowling game is scored below.

X 9/ 5/ 72 X X X 9- 8/ 9/ X

The game consists of 10 frames as shown above. In each frame the player has two opportunities to knock 
down 10 pins. The score for the frame is the total number of pins knocked down, plus bonuses for strikes and 
spares.
A spare is when the player knocks down all 10 pins in two tries. The bonus for that frame is the number of pins 
knocked down by the next roll. So in frame 3 above, the score is 10 (the total number knocked down) plus a 
bonus of 5 (the number of pins knocked down on the next roll.)
A strike is when the player knocks down all 10 pins on his first try. The bonus for that frame is the value of the 
next two balls rolled.
In the tenth frame a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame. 
However no more than three balls can be rolled in tenth frame

## Evaluation criteria
Your solution will be evaluated on the basis of the following:
• Design and object modelling
• Solution structure
• Test cases 
• Overall solution approach
• Readability and maintainability of code

## ***Consideration***
The solution should assume valid inputs at all times and does not need to include unnecessary validations trying to prevent bad input data
Some Examples
1. Problem statement input
   X9/5/72XXX9-8/9/X       -> 187
2. Normal mix game
   X454/32                 -> 46
3. All Misses 
   9-9-9-9-9-9-9-9-9-9-    -> 90
4. Mixed strikes, spares, and open frames 
   X7/9-X-88/-6XXX81       -> 167
5. All gutter 
   --------------------    -> 0
6. Strike, spare, and all misses 
   X5/------------------   -> 30
7. Perfect game 
   XXXXXXXXXXXX            -> 300
