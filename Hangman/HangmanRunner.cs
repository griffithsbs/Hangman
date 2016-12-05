using System;
using System.Linq;
using System.Threading;

namespace Hangingman {

    static class HangmanRunner {

        const string QUIT_WORD = "_QUIT_";

        static string ReadWord() {
            return Console.ReadLine().Split(' ').First();
        }

        static void Main(string[] args) {

            Console.WriteLine("Welcome to Hangman.");
            Console.WriteLine("First, player one must choose a word for player two to guess:");
            string word = ReadWord();

            if (word == QUIT_WORD) {
                return;
            }

            HangmanGame game = HangmanGame.StartNewGame(word);
            while (!game.IsOver) {
                Console.WriteLine("Player two, please make a guess:");
                string guess = ReadWord();
                if (guess == QUIT_WORD) {
                    Console.WriteLine("Goodbye");
                    break;
                }
                string result = game.Play(guess);
                Console.WriteLine(result);
            }
            Thread.Sleep(3000);
        }

    }

}
