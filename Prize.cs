using System;


namespace Quest
{

    public class Prize
    {
        private string _text { get; set; }

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {
                for (var i = 0; i < adventurer.Awesomeness; i++)
                {
                    Console.WriteLine($"{_text}");
                }
            }
            else
            {
                Console.WriteLine("Your soul is a lost as Dori...");
            }
        }
    }
}