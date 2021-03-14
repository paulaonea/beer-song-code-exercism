using System;

namespace BeerSongSolutionUsingClasses
{
    public class Verse
    {
        private int NumberOfBottles;
        private string CurrentNumberOfBottles => GetCurrentNumberOfBottles();
        private string RemainingNumberOfBottles => GetRemainingNumberOfBottles();
        private string TakeDown => GetTakeDownExpression();

        public Verse(int bottles) => NumberOfBottles = bottles;

        public string ComposeVerse() =>
            NumberOfBottles >=1
                ? $"{CurrentNumberOfBottles} of beer on the wall, {CurrentNumberOfBottles.ToLower()} of beer.\n" +
                  $"Take {TakeDown} down and pass it around, {RemainingNumberOfBottles} of beer on the wall."
                :  "No more bottles of beer on the wall, no more bottles of beer.\n" +
                   "Go to the store and buy some more, 99 bottles of beer on the wall.";
        
        private string GetCurrentNumberOfBottles() =>
            NumberOfBottles >= 2
                ? $"{NumberOfBottles.ToString()} bottles"
                : $"{NumberOfBottles.ToString()} bottle";

        private string GetRemainingNumberOfBottles() =>
            NumberOfBottles switch
            {
                2 => "1 bottle",
                1 => "no more bottles",
                _ => $"{(NumberOfBottles - 1).ToString()} bottles"
            };

        private string GetTakeDownExpression() =>
            NumberOfBottles >= 2
                ? "one"
                : "it";
    }
}