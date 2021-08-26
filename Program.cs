using System;
using System.Collections.Generic;
using System.Linq;


// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is you name Adventurer?");
            string userName = Console.ReadLine();
            

            Robe Silky = new Robe();
            Hat Blinding = new Hat(3);
            Prize Bling = new Prize("Bling, Bling, Boom!");


            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge


            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge twoPlusThree = new Challenge("2 + 3?", 5, 10);
            Challenge waterSymbol = new Challenge(@"What is the chemical formula for water
            1) 2O2
            2) HO2
            3) H2O
            4) HOH
             ",3, 10);
            Challenge bestBand = new Challenge(@"Who is the best band?
            1) Incubus
            2) Pearl Jam
            3) Lord Huron
            4) Mt Joy
            ", 1, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 10);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 10);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 10);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 10
            );

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            // Make a new "Adventurer" object using the "Adventurer" class
            Adventurer theAdventurer = new Adventurer("Jack", Silky, Blinding
            );
            Adventurer CurrentUser = new Adventurer(userName, Silky, Blinding);

            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle,
                twoPlusThree,
                bestBand,
                waterSymbol
            };

            List<Challenge> randoQuestions = new List<Challenge>();

            // Loop through all the challenges and subject the Adventurer to them
            Game();
            void Game()
            {
                CurrentUser.GetDescription(CurrentUser);
            // foreach (Challenge challenge in challenges)
            // {
            //     challenge.RunChallenge(CurrentUser);
            // }

            for (var i = 0; i < 5 ; i++)
            {
                int length = challenges.Count();
                int random = new Random().Next(length); 
                challenges.ElementAt(random).RunChallenge(CurrentUser);
            }
            Bling.ShowPrize(CurrentUser);
            Console.WriteLine(@"Would you like to repeat the adventure?
            1) yes
            2) no
            ");
            string userContinue = Console.ReadLine();
            if (userContinue == "1")
            {   
                // Console.WriteLine(CurrentUser.Awesomeness);
                int repeatGameMultiplier = CurrentUser.numberOfCorrectAnswers * 10;
                CurrentUser.Awesomeness += repeatGameMultiplier;
                // Console.WriteLine(CurrentUser.Awesomeness);
                // Console.WriteLine(repeatGameMultiplier);
                Game();
            }
            else
            {
                Console.WriteLine("See ya later alligator!");
            }
            }

            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
        }
    }
}
