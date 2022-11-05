using System;


namespace ForestAdventure
{
    class TheSword
    {
        
        static void Main()
        {
            string WeaponChoice = " The Sword, The Bow, The Wand";

System.Console.WriteLine("You pick up " + WeaponChoice + " and notice that the blade had seen action before.");
            Console.WriteLine("With it's nicks and blunted edges you may as well have chosen a sturdy stick. You pray you've made the right decision,");
            Console.WriteLine("upon picking up your choice the other two disappear.");
            Console.WriteLine("Just as the scroll before them.");
            Console.WriteLine("With great shaking and rumbling a path opens up in the woods as the trees pop and groan to bend around it.");
            Console.WriteLine("The path is dark. There is no way to know where it leads but you have no other options.");
            Console.WriteLine("You take a breath. Steady your courage and make for the path.");
            Console.WriteLine("For some time you walk along the parted path until you come upon a mighty oak with a hole in the trunk. Do you reach in and risk your limb? Or do you choose to protect thy fingies?");
            Console.WriteLine("REACH in or WALK on");
            
            string TreeChoice = "REACH, WALK";

            //if REACH IN "What great fortune! You have found a stone for sharpening your blade. 
            //would you like to use stone now? y= The edge on the blade is razor sharp and not a speck of damage insight! n= maybe you hit your head a little harder than you thought, huh champ?
            //if WALK ON " you eye the tree nervously while flexing your hand. You decide a hand attached is worth two in the bush... maybe thats not how it goes?
            //! Suggested respawn if  not full restart
            Console.WriteLine("You pick the pace up back up and continue down the darkened path. After a while you feel the hair on the back of your neck begin to stand and just as you go to turn around you are struck on the back of your leg. Taking you to a kneel. 'That's right bow you fool! For I am the Goblin Gilgamere and you shall not make it out of here!");
            Console.WriteLine ("do you FIGHT or do you FLEE?");

            string FightChoice = "FIGHT, FLEE";

            // if FIGHT Console.WriteLine("'Who are you calling a fool?' You right yourself and and tower over your opponent. You raise your mighty sword. (if you sharpened it, that is) and Gilgamere shreaks like a wee lass. 'Please! Please don't kill me! I was paid off! Its not me you want its him!!!");
            //Console.WriteLine("Your grip on sword hilt slacks and you ask 'Who's he?'. Gilgamere starts to answer but a boulder the size of a cow, flies from the tree line and Gilgamere and his last word disappears beneath it. You waste no time in making good distance between yourself and what ever could be capable of hurling a rock that large.

            /*if FLEE Console.WriteLine("Off you run and try to flee, but you fall down and skin your knee. You and Gilgamere now stare at each other awkwardly, before he puts you out of your misery. Thats it? Game over!? What a waste of thee!");
            Console.WriteLine("Restart the Game NAH or YEEYEE!");  

            //! TEAM!!  IF YES, DO YOU WANT THEM TO START WHOLE GAME OVER, OR JUST BACK TO LAST DIALOG CHOICE??

            string RestartChoice = "NAH , YEEYEE"; */

            //continue plot here 

            Console.WriteLine("You run without looking back or forward really just trying to make tracks but this is why your mother always yells at you to watch where your going, because as you find yourself now, you may just trip on a log in the path and end up with your face in the mud and your ass in the air. Its honestly impressive how much flexibility you have or, uhhh, had in your spine. You manage to get yourself right side up, wipe the mud from your face, you big disgrace. And you look around to make sure no one saw that. You curse and kick the log and realize its hollow. 'Probably rotten,' you think.");

            Console.WriteLine("Do you move it off the PASS so the next head trauma-ed dumb-dumb who isn't watching where he's going doesn't trip? Or do you throw a tantrum and SMASH that rude log that had the nerve to have landed in your future self's way?");

            Console.WriteLine ("SMASH or PASS?");

            string LogChoice = "SMASH, PASS";

            //if SMASH Console.WriteLine("you found the limb is recently abandoned honey hive from a special bee with Healing Honey! You being to eat the honey comb in huge bites feeling your energy restored. And your spine feels a little less uhhhhh broken. Once your belly is full of the sweet sticky stuff,");

            //if PASS 

            Console.WriteLine("You stand and stretch your sore muscles into places. You turn around to find your self nose to belly with an 10-foot tall, 800 pound, super funky smelling bear with glowing green eyes. In your panic you notice one side of its head dented in at a funny angle. You now realized what brought down such a large tree limb. And if your not careful it will bring down you too.");
            Console.WriteLine("Before you can make your next move the bear begins to speak. 'To think your people call you a King! HA! When it was soooo easy to take you off your steed with a single blow?! I figured why waste my time when even the carcass of this ratty old bear will do!'");
            Console.WriteLine("Shrill laughter fills the air as one of the undead bear's massive paws tipped with near daggers comes swinging toward you! You only have seconds! Do you FIGHT or PLAY-DEAD?");

            /*if PLAY-DEAD             Console.WriteLine("Play dead. Nah man, you like dead, dead. That is a haunted possessed zombie bear that is being controlled by an unseen person.... Did I mention Head Trauma? Cause I'm pretty sure I mentioned Head Trauma. Terrible choice bro. Like I wanna feel bad for you. But I don't.")
            Console.WriteLine("So like try again or whatever? But seriously who the heck just plays dead in front of a Zom-Bear? What a freaking idiot LOL! XD ");
            Console.WriteLine("START over, or become the EMBARRASSMENT of the entire royal line?");*/

            string Zombear = " START, EMBARRASSMENT";

            //if FIGHT 
            Console.WriteLine("You manage to block the worst of the blow but one errant claw rakes down the left side of your face marking you as a legend forever. Whether the blood or sweat stings your eyes worse you do not know. You can see a steep cliff side just past the bear. Out of instinct you use the sword to slice against the mighty creature's paw and blow it back away from you. The bear rears back and you run for the boulders at the far end of the clearing attempting to claim the high ground. The decomposing bear is faster than you expected and it knocks you to the ground at the base of the boulders. You land hard, leaving you breathless, head reeling, eyes nearly blinded from dust and salt. You find yourself between literal rocks and an 800 lb hard place made of matted fur, teeth, claws, and the smell of rot. As all 800 pounds crashed down at you teeth first you do the only thing you can think of. Draw your sword up, curl into a ball, and cry for your mommy.");

            Console.WriteLine("Instead of the piercing and ripping of teeth and flesh, you feel a cool, semi-moist rough spongy feeling on the back of your hand. You slowly open your eyes to see a massive tongue black and mottled resting on the back of your hand. Your blade between them juts out and disappears into the poor creatures soft pallet. You feel deep relief but also great sadness for the once majestic creature now allowed to rest in peace. You manage to wrench yourself from beneath the stilled pile and find the end of your sword reappearing from being the dented, once soft ear.");

            Console.WriteLine("Before you can fully understand all that has transpired the wind picks up ferociously. Whipping around the previous arena. The eerie green light that had previously been glowing from within the bear now burst forth with a piercing scream. 'How could you have defeated me!!! The Head Mage for the Ashen Army!!! You haven't heard the last of me!' The light shoots to the sky lifting the bear hide from the ground and disappearing it too in a whisper of smoke and ash. This too is violently swept up into the vortex. It hovers 100 feet in the air churning and green lightening streaking through the cloud and with a terrible explosion of thunder all is gone.");

            Console.WriteLine("You stand dumbstruck. Everything that has happened today has only served to make you more confused. Who are you? A King? and Who is the Ashen Army? Before your thoughts are able to carry you away you hear voices in the distance. Many voices! A village! You run as quickly as you can leaving behind all that has happened in the wake of your dust. You run so fast you don't realize you've broken through the treeline until it has blinded you from the intensely bright sun. you hear the cries first. Your Majesty! We've found him! Your eyes finally adjust to the light and you see a glorious castle gleaming and rising high in the distance!");

            Console.WriteLine("You are King of this land and this is home. Your memories come back in flashes but you know you are safe. You recognize your second in command. Your most trusted friend and confidant. They tell you about you leaving for a ride one morning as usual. But only your horse ever returned home. The kingdom had done a massive search of the grounds but not so much a strip of cloth was ever able to be found. What had seemed to you only a day had actually been three months. suddenly a memory of all your failed loops through the evil mages trap. All of the times your were forced to test and fail and re-try and fail. A thousand or more times you had died and been brought back to start again. Thankfully that hellish trap has ended and you are free.");

            Console.WriteLine("After a desperately needed bath, some medical care and a hot meal, your knight gather and await your orders. Do you STRIKE back, or LAY in wait for the next attack?");

            string FinalChoice = "STRIKE, LAY"

            // if STRIKE Console.WriteLine("WE RIDE AT DAWN!");

            //if LAY Console.WriteLine("Ready our reinforcements, send word to our allies, and set the bait!");

            //tada game play THE SWORD finished.
            







        Console.ReadKey();


        }
    }
}