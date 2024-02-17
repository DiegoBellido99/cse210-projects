using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos= new List<Video>();

       Video video1 = new Video("Elektra","Buy our Tv",120);
       video1.AddComment("diego","I think the video is too long");
       video1.AddComment("Arian","I don't like the video ");
       video1.AddComment("raffo","the video is interesting");
       videos.Add(video1);

       Video video2 = new Video("National Bank","Get a new credit card",180);
       video2.AddComment("diego","I dont have a good experiencie with this bank");
       video2.AddComment("Patrick","I  like the video very much ");
       video2.AddComment("Sebastian","This video has encourage me to get a new card");
       video2.AddComment("Frankie","I will think if it is a good idea to have a credit card");
       videos.Add(video2);

       Video video3 = new Video("Topitop","Buy the new shoes",60);
       video3.AddComment("diego","I think the video is too long");
       video3.AddComment("Raul","I don't like the video ");
       video3.AddComment("raffo","I like those shoes");
       videos.Add(video3);

       foreach(var video in videos)
       {
        video.DisplayVideoInfo();
        Console.WriteLine();
       }
    }




}