using System;


namespace ForestAdventure
{
    class Program
    {
        static void Main()
        {
            string WeaponChoice = " The Sword, The Bow, The Wand";

            Console.WriteLine("Forest Adventure!");

            Console.WriteLine("Your head is pounding. Light from the sun above the clearing is blinding as you first open your eyes."); 
            Console.WriteLine("After a moment you adjust and you realize you have woken up deep within an old growth forest."); 
            Console.WriteLine("You do not remember how you came to be at this place.");
            Console.WriteLine("You begin to realize you don't even know your own name.");
            Console.WriteLine("Just as the panic of being alone in the woods begins to bubble you notice three items and a weathered scroll with shaky,");
            Console.WriteLine("scratched writing, laying at your feet.");
            Console.WriteLine("You unroll and begin to read:  'For all your riches and petty greed, a troubled path you shall lead."); 
            Console.WriteLine("Only one favor I will treat, select one object by your feet.'");
            Console.WriteLine("As you read the last line the scroll burst to flame and leaves nothing but ash and a whisper of smoke.");
            Console.WriteLine("You turn your attention to the objects before you.");
            Console.WriteLine("What do you choose?");
            Console.WriteLine("         The Sword, The Bow, or the Wand?");

            WeaponChoice = Console.ReadLine();

            Console.WriteLine("You pick up " + WeaponChoice + ". You pray you've made the right decision,");
            Console.WriteLine("upon picking up your choice the other two disappear.");
            Console.WriteLine("Just as the scroll before them.");
            Console.WriteLine("With great shaking and rumbling a path opens up in the woods as the trees pop and groan to bend around it.");
            Console.WriteLine("The path is dark. There is no way to know where it leads but you have no other options.");
            Console.WriteLine("You take a breath. Steady your courage and make for the path.");
        Console.ReadKey();
        }
    }
}

