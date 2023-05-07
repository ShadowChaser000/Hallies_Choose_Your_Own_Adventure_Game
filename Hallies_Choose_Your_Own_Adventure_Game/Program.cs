using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hallies_Choose_Your_Own_Adventure_Game
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int numberOfRooms = 16;
            string userInput = "";
            Room[] rooms = new Room[numberOfRooms];
            int currentRoom = 0;

            // Build the array of rooms...
            // Create each room (0 to (numberOfRooms - 1)) with the adacent room numbers
            // (north, south, east, west) as instance parameters.
            //  - Specify -1 if there is no adjecent room in a particular direction.

            // Room 0 - north=-1, south=-1, east=-1 west=1
            rooms[0] = new Room(-1, -1, -1, 1);
            rooms[0].name = "Entrance Hall";
            rooms[0].description = "You wake up and find yourself in a dark, damp, and foreboding hallway.";

            // Room 1 - north=-1, south=-1, east=0 west=2
            rooms[1] = new Room(-1, -1, 0, 2);
            rooms[1].name = "Sewers";
            rooms[1].description = "You follow the hallway which leads you to the humid, smelly sewers.";

            // Room 2 - north=-1, south=5, east=1 west=3
            rooms[2] = new Room(-1, 5, 1, 3);
            rooms[2].name = "Dungeon";
            rooms[2].description = "You make your way through the sewers and end up in a cold and musty dungeon, with rusted bars.";

            // Room 3 - north=-1, south=4, east=2 west=-1
            rooms[3] = new Room(-1, 4, 2, -1);
            rooms[3].name = "Skeleton Lair";
            rooms[3].description = "Oh no! You stumble upon an abandoned prison cell, swarming with undead skeletons, who look menacingly at you...";

            // Room 4 - north=3, south=-1, east=5 west=-1
            rooms[4] = new Room(3, -1, 5, -11);
            rooms[4].name = "Dragon Cave";
            rooms[4].description = "Oh my! You stumble upon a slumbering dragon who suddenly wakens as smoke exits from his nostrils!";

            // Room 5 - north=2, south=6, east=-1 west=4
            rooms[5] = new Room(2, 6, -1, 4);
            rooms[5].name = "Hedge Mazes";
            rooms[5].description = "You manage to escape the fearsome dragon and walk into a tall hedge maze. You feel like you might get lost for hours...";

            // Room 6 - north=5, south=7, east=-1 west=-1
            rooms[6] = new Room(5, 7, -1, -1);
            rooms[6].name = "Armory";
            rooms[6].description = "When you finally find the way out of the hedge maze, you come across a large room filled with armor and weapons...";

            // Room 7 - north=6, south=8, east=12 west=13
            rooms[7] = new Room(6, 8, 12, 13);
            rooms[7].name = "Throne Room";
            rooms[7].description = "You walk through a door into a room with marble flooring, high ceilings, and two large, tall thrones at the back wall, with one throne taller than the other.";

            // Room 8 - north=7, south=10, east=11 west=9
            rooms[8] = new Room(7, 10, 11, 9);
            rooms[8].name = "Secret Passage";
            rooms[8].description = "You spot a hidden entryway behind a tapestry and walk inside to discover a secret tunnel that looked as though it hadn't been used in years, with many cobwebs, mossy stone walls, and long since burned out torches.";

            // Room 10 - north=8, south=-1, east=-1 west=-1
            rooms[10] = new Room(8, -1, -1, -1);
            rooms[10].name = "Fairy Tree";
            rooms[10].description = "You take the south passage of the secret tunnel, which leads you outside to a fairy tree. It is illuminated with many different colors as beautiful fairies float by...";

            // Room 11 - north=12, south=-1, east=-1 west=8
            rooms[11] = new Room(12, -1, -1, 8);
            rooms[11].name = "Mermaid Cove";
            rooms[11].description = "You head towards beautiful singing voices and find yourself at the foot of a waterfall, in a beautiful cove, with mermaids singing on the rocks and swimming in the water. Their voices entrance you, and you begin to lose your focus...";

            // Room 12 - north=-1, south=11, east=15 west=7
            rooms[12] = new Room(-1, 11, 15, 7);
            rooms[12].name = "Pirate Lair";
            rooms[12].description = "You walk towards the sounds of blades swishing and clashing against each other, and stumble upon a pirate ship in a large cove. They stare at you menacingly and begin to laugh to themselves...";

            // Room 15 - north=-1, south=-1, east=-1 west=12
            rooms[15] = new Room(-1, -1, -1, 12);
            rooms[15].name = "Bunny Valley";
            rooms[15].description = "You run away from the pirates down the pathway, until you trip over a fluffy white bunny. You look up and there are hundreds of bunnies hopping up and down a steep valley!";

            // Room 9 - north=13, south=-1, east=8 west=-1
            rooms[9] = new Room(13, -1, 8, -1);
            rooms[9].name = "Treasure Room";
            rooms[9].description = "You walk through a door into a room filled to the ceiling with gold pieces, gems, and lavish expensive silks and clothing...";

            // Room 13 - north=-1, south=9, east=7 west=14
            rooms[13] = new Room(-1, 9, 7, 14);
            rooms[13].name = "Royal Nursery";
            rooms[13].description = "You walk into a room that has a crib with silk bedding and an symbol on the wood that was also etched on the tall throne chairs. You recognize this as a royal insignia, which means this must be the nursery of the royal family...";

            // Room 14 - north=-1, south=-1, east=13 west=-1
            rooms[14] = new Room(-1, -1, 13, -1);
            rooms[14].name = "Greenhouses";
            rooms[14].description = "You see a small building outdoors, and enter. It is filled to the brim with herbs, plants, and flowers. The air is full of refreshing aromas!";




            // Continue asking the user for directions until they enter "exit"...
            while (userInput != "exit")
            {

                showBanner(rooms[currentRoom].name);

                // Describe the current room (we are using ToString)
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(rooms[currentRoom]);
                Console.ResetColor();

                // Find out which direction to travel and clear the screen...
                Console.WriteLine("\n\nWhat direction do you want to travel [north(n), south(s), east(e), west(w)]?");
                userInput = Console.ReadLine();

                // Check if the user wants to exit the game...
                if (userInput == "exit" || userInput == "x")
                {
                    break;
                }

                // If the user wants to go north, south, east or west and they can, go to that room... 
                if ((userInput == "north" || userInput == "n") && rooms[currentRoom].north > -1)
                {
                    currentRoom = rooms[currentRoom].north;
                }
                else if ((userInput == "south" || userInput == "s") && rooms[currentRoom].south > -1)
                {
                    currentRoom = rooms[currentRoom].south;
                }
                else if ((userInput == "east" || userInput == "e") && rooms[currentRoom].east > -1)
                {
                    currentRoom = rooms[currentRoom].east;
                }
                else if ((userInput == "west" || userInput == "w") && rooms[currentRoom].west > -1)
                {
                    currentRoom = rooms[currentRoom].west;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOops! You smashed into the wall!\n");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("\nThanks for playing! Goodbye.");
            Console.WriteLine();
        }

        private static void showBanner(string roomName)
        {
            string message = "    [ " + roomName + " ] - enter 'exit(x)' at any time to end the game.";

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}