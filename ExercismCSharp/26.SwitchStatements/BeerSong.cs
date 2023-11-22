namespace ExercismCSharp;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string lyrics = string.Empty;

        for(int currentBottle = startBottles; currentBottle > startBottles - takeDown; currentBottle--)
        {
            lyrics += currentBottle switch
            {
                2 => "2 bottles of beer on the wall, 2 bottles of beer.\n" +
                     "Take one down and pass it around, 1 bottle of beer on the wall.\n\n",
                1 => "1 bottle of beer on the wall, 1 bottle of beer.\n" +
                     "Take it down and pass it around, no more bottles of beer on the wall.\n\n",
                0 => "No more bottles of beer on the wall, no more bottles of beer.\n" +
                     "Go to the store and buy some more, 99 bottles of beer on the wall.\n\n",
                _ => $"{currentBottle} bottles of beer on the wall, {currentBottle} bottles of beer.\n" +
                     $"Take one down and pass it around, {currentBottle - 1} bottles of beer on the wall.\n\n",
            };
        }

        return lyrics.Trim();
    }
}