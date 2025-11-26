using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to Cook Pasta", "Chef Mario", 340);
        v1.AddComment(new Comment("Ana", "Great video!"));
        v1.AddComment(new Comment("Luis", "I love pasta!"));
        v1.AddComment(new Comment("Carlos", "Very helpful."));
        videos.Add(v1);

        Video v2 = new Video("Minecraft Survival Ep. 1", "RoosGaming", 820);
        v2.AddComment(new Comment("Diego", "Nice episode!"));
        v2.AddComment(new Comment("Martha", "Can't wait for part 2."));
        v2.AddComment(new Comment("Pedro", "You are getting better!"));
        videos.Add(v2);

        Video v3 = new Video("Learn C# Classes", "CodeAcademyMX", 600);
        v3.AddComment(new Comment("Jimena", "Explained so well!"));
        v3.AddComment(new Comment("Roberto", "Thanks for the tutorial!"));
        v3.AddComment(new Comment("Fernanda", "Very clear examples."));
        videos.Add(v3);

         foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length (sec): {video._lengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($"  - {c._name}: {c._text}");
            }

            Console.WriteLine();
        }
    }
}