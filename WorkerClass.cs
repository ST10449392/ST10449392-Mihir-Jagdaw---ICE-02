using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ICE_02___Media_Player__WAV_files_
{
    class WorkerClass
    {
        // Default Constructor
        public WorkerClass()
        {
            
        }

        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of the WAV file you want to play: ");
            Console.WriteLine("1. Mystery Song");
            Console.WriteLine("2. Mystery Sound");
            Console.WriteLine("3. Mystery Noise");
            Console.WriteLine("0. Exit\n");
        }
        public void DisplayMenu(int selection)
        {
            Console.Clear();
            Console.WriteLine("Enter the number of the WAV file you want to play: ");

            printOption(1, "Mystery Song", selection == 1);
            printOption(2, "Mystery Sound", selection == 2);
            printOption(3, "Mystery Noise", selection == 3);
            printOption(0, "Exit", selection == 0);

            Console.ResetColor();
        }

        private void printOption(int num, string text, bool isSelected)
        {
            if (isSelected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            } else
            {
                Console.ResetColor();
            }
            Console.WriteLine($"{num}. {text}");
        }

        public void PlayWavFile()
        {
            var player = new SoundPlayer();
            int wavFileNumber = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the WAV file you want to play:");
                DisplayMenu();

                wavFileNumber = Convert.ToInt32(Console.ReadLine());

                switch (wavFileNumber)
                {
                    case 1:
                        DisplayMenu(1);
                        player.SoundLocation = @"C:\Users\mihir\OneDrive\Documents\Rick Astley - Never Gonna Give You Up (Official Music Video).wav";
                        player.Play();
                        break;
                    case 2:
                        DisplayMenu(2);
                        player.SoundLocation = @"C:\Users\mihir\OneDrive\Documents\Send this to all your friends.wav";
                        player.Play();
                        break;
                    case 3:
                        DisplayMenu(3);
                        player.SoundLocation = @"C:\Users\mihir\OneDrive\Documents\Send this to your friend and say nothing  #share #viral #meme #subscribe.wav";
                        player.Play();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to stop the music.");
                Console.ReadLine();
            }
        }
    }   
}
