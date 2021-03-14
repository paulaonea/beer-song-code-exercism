namespace BeerSongSolutionUsingClasses
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            var poem = new Song(startBottles, takeDown).CreatePoem();
            return string.Join("\n\n", poem);
        }
    }
}