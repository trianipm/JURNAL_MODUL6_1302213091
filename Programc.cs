// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

namespace SayaTubeVideo
{
    class SayaTubeUser
    {
        private int id;
        private string title;
        private string UserName;

        public SayaTubeUser(string username)
        {
            UserName = username;
        }

        public GetTotalVideoPlayCount(int id)
        {
            Random rand = new Random();
            id = rand.Next(10000, 99999);
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null);
            Debug.Assert(video.GetTotalVideoPlayCount);
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("User: " + UserName);
            Console.WriteLine("Video 1 Judul: " + title);
            Console.WriteLine("Video 2 Judul: " + title);
        }
    }
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            id = rand.Next(10000, 99999);

            this.title = title;
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 25000000)
            {
                throw new ArgumentOutOfRangeException("count", "Input penambahan play count maksimal 10.000.000 per panggilan method-nya.");
            }

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play count: " + playCount);
        }
    }
}