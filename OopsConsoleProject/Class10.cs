using System;


namespace OopsConsoleProject
{
    internal class Class10
    {
        static int totalScore = 0;
        int score = 0;
        string name = string.Empty;
        public void ShowScore()  // Accessmodifier return type  MethodName(paramters)
        {
            Console.WriteLine($"Total Score : {totalScore}");
            Console.WriteLine($"Player   {name} Scored : {score}");
        }
        public void Player()
        {
            Console.WriteLine($"Total score : {totalScore}");
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Score : ");
            score = int.Parse( Console.ReadLine());
            totalScore += score;
        }
    }
}
