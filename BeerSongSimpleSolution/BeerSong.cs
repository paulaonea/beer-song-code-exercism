using System;
using System.Collections.Generic;

namespace BeerSongSimpleSolution
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            var song = new List<string>();
            for (int currentVerse = startBottles; currentVerse > startBottles - takeDown; currentVerse--)
            {
                song.Add(ReciteOneVerse(currentVerse));
            }

            return string.Join("\n\n", song);
        }

        private static string ReciteOneVerse(int currentVerse, int takeDown=1)
        {
            string verse = currentVerse switch
            {
                2 =>
                    $"{currentVerse.ToString()} bottles of beer on the wall, {currentVerse.ToString()} bottles of beer.\n" +
                    $"Take one down and pass it around, {(currentVerse - takeDown).ToString()} bottle of beer on the wall.",
                1 =>
                    $"{currentVerse.ToString()} bottle of beer on the wall, {currentVerse.ToString()} bottle of beer.\n" +
                    "Take it down and pass it around, no more bottles of beer on the wall.",
                0 => "No more bottles of beer on the wall, no more bottles of beer.\n" +
                     "Go to the store and buy some more, 99 bottles of beer on the wall.",
                _ =>
                    $"{currentVerse.ToString()} bottles of beer on the wall, {currentVerse.ToString()} bottles of beer.\n" +
                    $"Take one down and pass it around, {(currentVerse - takeDown).ToString()} bottles of beer on the wall."
            };
        
            return verse;
        }
    }
}