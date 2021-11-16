// program.cs is like your main.js in JavaScript
// void means your just pringting things to the terminal
using System;

Main();
void Main()
// 
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    // we take all the positive, negative and questions and call all of the MooseQuestions. This cleans up the code and calls all of the answers and questions in the same place.
    MooseQuestions("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    MooseQuestions("Are you enthusiastic?", "Yay!", "You should try it!");
    MooseQuestions("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    MooseQuestions("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
    bool MooseAsks(string question)
    // this string asks a question instead of presenting a message
    {
        Console.Write($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();
        // asks a question in the console and allows for a T/F answer

        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        if (answer == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // define the type if variable "string" : you will need a question, positive answer and negative answer
    void MooseQuestions(string question, string positive, string negative)
    {
        bool response = MooseAsks(question);
        if (response)
        {
            MooseSays(positive);
        }
        else
        {
            MooseSays(negative);
        }
    }
}

void MooseSays(string message)
// string message refers to "MooseSays" 
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
