using System;

namespace _09___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Radio myRadio = new Radio(false, "Sony");
            // // Method of base class
            // myRadio.SwitchOn();
            // // Method of child class
            // myRadio.ListenRadio();

            // TV myTV = new TV(false, "Samsung");
            // // Method of base class
            // myTV.SwitchOn();
            // // Method of child class
            // myTV.WatchTV();

            // Dog dog = new Dog("Sif", 15);
            // Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            // dog.MakeSound();
            // dog.Play();
            // dog.Eat();

            Post post1 = new Post("Thanks for the birthday wishes", true, "User");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my GitHub", "User",
                "https://github.com/Aman07a", true);

            VideoPost videoPost1 = new VideoPost("FailVideo", "User",
                "https://www.youtube.com/results?search_query=failvideo", true, 10);

            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();

            Console.Read();
        }

        // CHALLENGE: Add a deriving class "VideoPost" with a property VideoURL, Length.

        // Create the required constructors to create a VideoPost
        // Adjust the ToString() method accordingly
        // Create an instance of VideoPost and use the ToString method on it

        // More advanced - use Timer and a Callback method here (google it)
        // Create fields as required
        // Add member methods "Play" which should write the current duration of the video
        // And "Stop" which should stop the "timer" and write "stopped at {0}" onto the console
        // Play the video after creating the instance and stop it, when the user presses any key
    }
}
