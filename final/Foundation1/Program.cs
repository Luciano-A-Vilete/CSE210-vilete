using System;

class Program
{
    static void Main(string[] args)
    {
        // Videos List
        var videos = CreateVideos();
        // Diaplay the Video Details.
        DisplayVideoDetails(videos);
    }

    // Method to the list of videos creation.
    private static List<Video> CreateVideos()
    {
        return new List<Video>
        {
            new Video
            {
                Title = "Video 1",
                Author = "Author 1",
                Length = 120,
                Comments = new List<Comment>
                {
                    new Comment { UserName = "User 1", Text = "Great video!" },
                    new Comment { UserName = "User 2", Text = "I love this product!" }
                }
            },
            new Video
            {
                Title = "Video 2",
                Author = "Author 2",
                Length = 240,
                Comments = new List<Comment>
                {
                    new Comment { UserName = "User 3", Text = "Very informative." },
                    new Comment { UserName = "User 4", Text = "Thanks for sharing!" }
                }
            }
        };
    }

    // Method for display each video details.
    private static void DisplayVideoDetails(List<Video> videos)
    {
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}s, Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.UserName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}