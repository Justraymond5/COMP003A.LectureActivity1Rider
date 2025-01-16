namespace COMP003A.LectureActivity1Rider
{
    //class level
    internal class Program
    {
        //mail level
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter your name: Raymond\nHello Rodrigo? My name is Raymond Gonzalez\n\n\nHere are 10 things about me:\n 1. My name starts with an R.\n 2.I am a son.\n 3.I have a math class.\n 4.I am an SI.\n 5. I go to Lemoore Collge\n 6.I have a sister named Maria\n 7. I have another sister names Susie\n 8. Lastly I have one more sister names Lupe\n 9.I forgot to mention I have an older brother\n 10. My brothers's name is Jose");
            string username = Console.ReadLine(); // gets the user input and save it to a variable names username
            Console.WriteLine("Hi" + username + ".My name is Raymond");

        }
    }
}