using System.Collections.Generic;

namespace BeerSongSolutionUsingClasses
{
    public class Song
    {
        private int StartBottles { get; set; }
        private int TakeDown { get; set; }

        public Song(int startBottles, int takeDown)
        {
            StartBottles = startBottles;
            TakeDown = takeDown;
        }
        
        public IEnumerable<string> CreatePoem()
        {
            for (var currentNumberOfBottles = StartBottles; 
                currentNumberOfBottles > StartBottles - TakeDown; 
                currentNumberOfBottles--)
            {
                yield return new Verse(currentNumberOfBottles).ComposeVerse();  
            }
        }
        
    }
}