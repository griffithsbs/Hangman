# Hangman

A simple programming challenge.

The scenario:
You have inherited the state-of-the-art game engine, *HangmanRunner.cs*. Finish off *HangmanGame.cs* so as to produce a working Hangman game for two human players.

The rules of Hangman:
- Player one enters a word for Player two to guess.
- Player two takes a turn by guessing a letter which appears in the word, or the whole word itself.
- After each guess, player two is informed of the positions of the letters correctly guessed in the word, and the number of lives remaining.
- Player two starts with 5 lives. Each time s/he guesses incorrectly, s/he loses a life.
- If player two correctly guesses all of the letters in the word, or the whole word itself, the game is over
  and player two wins.
- If all lives are lost, the game is over and player one wins.


#### Potential extra challenges
1. If player two makes a guess that s/he has already tried before, no action is taken.
2. If you were allowed to change *HangmanRunner.cs* itself, how would you improve it? (including, perhaps, masking player one's console input, and its interface with HangmanGame).
3. Implement a bot to play the part of Player two.