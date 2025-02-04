using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> videoComments = new List<Comment>();
        Comment comment;
        Video video;

        comment = new Comment("Hola!","Marie");
        videoComments.Add(comment);
        comment = new Comment("I like it","Jacob");
        videoComments.Add(comment);
        comment = new Comment ("Hi!","Alma");
        videoComments.Add(comment);

        
        video = new Video("Lets Cook!","Maria",300,videoComments);
        videos.Add(video);


        videoComments = new List<Comment>();
        comment = new Comment("Hello!","Lindsay");
        videoComments.Add(comment);
        comment = new Comment("I love it","Ann");
        videoComments.Add(comment);
        comment = new Comment ("Good Idea!","Andrew");
        videoComments.Add(comment);

        
        video = new Video("Handmade Art!","Carl",200,videoComments);
        videos.Add(video);

        videoComments = new List<Comment>();
        comment = new Comment("Good morning!","Joshep");
        videoComments.Add(comment);
        comment = new Comment("I enjoyed your video","Eliza");
        videoComments.Add(comment);
        comment = new Comment ("Good job!","Adam");
        videoComments.Add(comment);

        
        video = new Video("Baking cookis!","Lorey",500,videoComments);
        videos.Add(video);



        foreach(Video videoDisplay in videos)
        {
          videoDisplay.DisplayVideo();
          videoDisplay.DisplayNumberOfComments();

        }

        
    }
}