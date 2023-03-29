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

        public void GetTotalVideoPlayCount(int id)
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

    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Review Film <judul> - [Triani Putri Mumpuni]");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    user.GetTotalVideoPlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Frozen 1 - [Triani Putri Mumpuni]");
     
            {
                try
                {
                    video1.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Frozen 2 - [Triani Putri Mumpuni]");

            {
                try
                {
                    video2.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Harry Potter - [Triani Putri Mumpuni]");

            {
                try
                {
                    video3.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Wednesday - [Triani Putri Mumpuni]");

            {
                try
                {
                    video4.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Tomorrow - [Triani Putri Mumpuni]");

            {
                try
                {
                    video5.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Upin&Ipin - [Triani Putri Mumpuni]");

            {
                try
                {
                    video6.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Doraemon - [Triani Putri Mumpuni]");

            {
                try
                {
                    video7.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Boku No Hero Academia - [Triani Putri Mumpuni]");

            {
                try
                {
                    video8.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Jujutsu Kaisen - [Triani Putri Mumpuni]");

            {
                try
                {
                    video9.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Chainsaw Man - [Triani Putri Mumpuni]");

            {
                try
                {
                    video10.IncreasePlayCount(25000000);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            video1.PrintVideoDetails();
            video2.PrintVideoDetails();
            video3.PrintVideoDetails();
            video4.PrintVideoDetails();
            video5.PrintVideoDetails();
            video6.PrintVideoDetails();
            video7.PrintVideoDetails();
            video8.PrintVideoDetails();
            video9.PrintVideoDetails();
            video10.PrintVideoDetails();

            Console.ReadLine();
        }
    }
}