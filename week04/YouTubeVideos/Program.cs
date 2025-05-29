using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("The rise of Zimbabwe", "ThatZimGuy", 480);
        video1.AddComment(new Comment("Tinashe", "iblind video leyo!"));
        video1.AddComment(new Comment("Lebo", "Izavuka iZimbabwe!"));
        video1.AddComment(new Comment("Nkomo", "So manje senzeni?"));
        videos.Add(video1);
        Video video2 = new Video("Ukupheka isitshwala", "Chef Nqini", 900);
        video2.AddComment(new Comment("Tanyaradzwa", "Nice!"));
        video2.AddComment(new Comment("Joshua", "Isitshwala simnandi kodwa!!"));
        video2.AddComment(new Comment("Thelma", "Can l use impuphu?"));
        videos.Add(video2);

        Video video3 = new Video("Ukuyakha imba", "Inkabi yang'khona", 720);
        video3.AddComment(new Comment("Dube", "Izaphela kokuphela!"));
        video3.AddComment(new Comment("Ncube", "Inkabi le iblind?"));
        video3.AddComment(new Comment("ED", "Ngizakwenza kokuphela"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
