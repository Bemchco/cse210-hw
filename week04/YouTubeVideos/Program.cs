using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.Title = "Sample Video";
        video1.Description = "This is a sample video description.";
        video1.Length = 10;
        video1.Comments = new List<Comment>();
        Comment comment1 = new Comment("User1", "This is a great video!");
        Comment comment2 = new Comment("User2", "Very informative.");

        video1.add_comment(comment1);
        video1.add_comment(comment2);

        videos.Add(video1);

        Video video2 = new Video();
        video2.Title = "Another Video";
        video2.Description = "This is another video description.";
        video2.Length = 15;
        video2.Comments = new List<Comment>();
        Comment comment3 = new Comment("User3", "Nice video!");
        Comment comment4 = new Comment("User4", "Learned a lot.");

        video2.add_comment(comment3);
        video2.add_comment(comment4);

        videos.Add(video2);

        Video video3 = new Video();
        video3.Title = "Third Video";
        video3.Description = "This is the third video description.";
        video3.Length = 20;
        video3.Comments = new List<Comment>();
        Comment comment5 = new Comment("User5", "Awesome content!");   
        Comment comment6 = new Comment("User6", "Keep it up!");
        video3.add_comment(comment5);
        video3.add_comment(comment6);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Description: {video.Description}");
            Console.WriteLine($"Length: {video.Length}:00");
            Console.WriteLine($"Comments ({video.get_comment_count()}):");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}