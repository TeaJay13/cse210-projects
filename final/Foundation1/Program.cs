using System;

public class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.title = "Video 1";
        video1.author = "Author 1";
        video1.length = 11.11;
        video1.comments = new List<Comment>
        {
            new Comment { commenterName = "UserA", text = "Great video!" },
            new Comment { commenterName = "UserB", text = "I learned a lot from this video." },
            new Comment { commenterName = "UserC", text = "Could you make a tutorial on this topic?" }
        };

        Video video2 = new Video();
        video2.title = "Video 2";
        video2.author = "Author 2";
        video2.length = 12.12;
        video2.comments = new List<Comment>
        {
            new Comment { commenterName = "UserD", text = "That was a good video!" },
            new Comment { commenterName = "UserE", text = "I got to learn alot from watching this." },
            new Comment { commenterName = "UserF", text = "Could you show us more about this topic?" }
        };

        Video video3 = new Video();
        video3.title = "Video 3";
        video3.author = "Author 3";
        video3.length = 13.13;
        video3.comments = new List<Comment>
        {
            new Comment { commenterName = "UserG", text = "Loved the video!" },
            new Comment { commenterName = "UserH", text = "There are so many new things I learned." },
            new Comment { commenterName = "UserI", text = "Could you make a more in depth video about this?" }
        };

        List<Video> videos = new List<Video>{ video1, video2, video3};

        foreach (var video in videos)
        {
            Console.WriteLine($"Title:{video.title}, Author:{video.author}, Length:{video.length}, # of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.comments)
            {
                Console.WriteLine($" Commenter:{comment.commenterName}, Comment:{comment.text}");
            }
            Console.WriteLine("");
        }
    }
}