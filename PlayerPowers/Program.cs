using System;

namespace PlayerPowers
{
    class Program
    {
        [Flags]
        enum Powers
        {
            Fly = 1,
            XRayVision = 2,
            SuperStrength = 4
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of Player?");
            int n;
            bool isValid = Int32.TryParse(Console.ReadLine(), out n);

            if(!isValid){
                Console.WriteLine("Invalid input!");
                return;
            }

            Powers[] playerPowers = new Powers[n];
            string input;
            int i = 0;
            foreach(Powers p in playerPowers)
            {
                Console.WriteLine($"Powers of {i + 1}?");
                input = Console.ReadLine();
                foreach(char c in input){
                    switch(c) 
                    {
                        case 'f':
                            playerPowers[i] ^= Powers.Fly;
                            break;
                        case 'x':
                            playerPowers[i] ^= Powers.XRayVision;
                            break;
                        case 's':
                            playerPowers[i] ^= Powers.SuperStrength;
                            break;
                        default:
                            Console.WriteLine("Unknown power!");
                            Console.WriteLine(c);
                            return;
                    }
                }
                i++;
            }
            foreach(Powers p in playerPowers)
            {
                Console.WriteLine(p);
                if((p & Powers.Fly) == Powers.Fly
                && (p & Powers.SuperStrength) == Powers.SuperStrength){
                    Console.WriteLine("Flying radiation!\n");
                }
            }
            
                
        }
    }
}
