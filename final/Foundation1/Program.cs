using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> video1Comments = new List<Comment>()
        {
            new Comment("Kaiden", "Patricia loves the sound of nails strongly pressed against the chalkboard."),
            new Comment("Ashlee", "Iguanas were falling out of the trees."),
            new Comment("Jewell", "It must be easy to commit crimes as a snake because you don't have to worry about leaving fingerprints."),
            new Comment("Jerrod", "If any cop asks you where you were, just say you were visiting Kansas.")
        };
        Video video1 = new Video("A New Video", "Maple", 100, video1Comments);

        List<Comment> video2Comments = new List<Comment>()
        {
            new Comment("Raeburn", "The bird had a belief that it was really a groundhog."),
            new Comment("Dolly", "If you spin around three times, you'll start to feel melancholy."),
            new Comment("Murray", "The tour bus was packed with teenage girls heading toward their next adventure."),
            new Comment("Algar", "He found rain fascinating yet unpleasant.")
        };
        Video video2 = new Video("Eating Fifteen Grapes", "Lonny", 50, video2Comments);

        List<Comment> video3Comments = new List<Comment>()
        {
            new Comment("Sydnee", "His thought process was on so many levels that he gave himself a phobia of heights."),
            new Comment("Ronnie", "Martha came to the conclusion that shake weights are a great gift for any occasion."),
            new Comment("Yorick", "When money was tight, he'd get his lunch money from the local wishing well.")
        };
        Video video3 = new Video("Why Am I Here?", "Jimi", 120, video3Comments);

        Console.WriteLine();
        video1.Display();
        Console.WriteLine("\n");
        video2.Display();
        Console.WriteLine("\n");
        video3.Display();
        Console.WriteLine();
    }
}