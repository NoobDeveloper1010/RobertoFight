using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Timers;

namespace RobertoFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // player stats
            int PlayerHealth = 50;
            int PlayerDamage = 2;
            // enemy stats
            int RobertoHealth = 20;
            int RobertoDamage = 5;
            bool RobertoPhase2;
            // other variables


            // the actual code


            
            Console.WriteLine("Press q to start ");
            Console.WriteLine("Press w to see the stats");
            Console.WriteLine("Press 5 to see the chnages");

            string MenuInput = Console.ReadLine();
            if (MenuInput == "q")
            {
                    Battle();

            }

            if (MenuInput == "w")//add the Stats tabs
            {
                    SoundPlayer sound = new SoundPlayer("MenuButton.wav");
                    sound.Play();
                    InformationTab();
            }

            if (MenuInput == "5") //add the new chnages Tab 
            {
                 SoundPlayer sound = new SoundPlayer("MenuButton.wav");
                 sound.Play();
                 NewsTab();
            }

        
   

            void Battle()
            {
                //the backgorund sound
                SoundPlayer sound = new SoundPlayer("Roberto's Emergance.wav");
                sound.Play();      
                //the actual fight
                Console.WriteLine("ROBERTO");
                Console.WriteLine();
                while (PlayerHealth != 0 && RobertoHealth != 0)
                {
                    Console.WriteLine("Players health: " + PlayerHealth + "    " + "select your action " + "    " + "Roberto health: " + RobertoHealth);
                    Console.WriteLine("Press 1 to attack him or 2 to heal yourself");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player attacked");
                        Console.ResetColor();
                        RobertoHealth -= PlayerDamage;
                        splitter();
                        
                        Console.WriteLine("Roberto attacked player");
                        Console.ResetColor();                        
                        PlayerHealth -= RobertoDamage;
                        splitter();
                        

                    }if (answer == 2)
                    {
                        Console.WriteLine("Player healed");
                        PlayerHealth += 10;
                        splitter();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Roberto attacked player");
                        PlayerHealth -= RobertoDamage;
                        Console.ResetColor();
                        splitter();
                        


                    } else if(PlayerHealth <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("you lost");
                        break;
                    }else if (RobertoHealth == 0)
                    {
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("you won");
                        break;
                    }
                    
                    
                }
                
            }

            void splitter()
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
            }

            void NewsTab()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                 --Update's news-- ");
                Console.WriteLine("- Phase 2 for roberto is coming soon...");
                Console.WriteLine("The reasoon behind this, is because the game is boring and i am a complete lazy falure");
                Console.ResetColor();

            }

            void InformationTab()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine("Player's stats: ");
                Console.WriteLine("Player's health: " + PlayerHealth);
                Console.WriteLine("Player's Damage: " + PlayerDamage);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("Roberto's stats: ");
                Console.WriteLine("Roberto's health: " + RobertoHealth);
                Console.WriteLine("Roberto's Damage: " + RobertoDamage);
                Console.ResetColor();
            }

            Console.ReadLine();
        }

         
    }
}
