using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks charPerks = Perks.WaterBreathing | Perks.Stealth
                                | Perks.AutoHeal | Perks.DoubleJump;

            int wCount, aCount, sCount, dCount;
            wCount = aCount = sCount = dCount = 0;

            foreach(char c in args[0]){
                switch(c) 
                {
                case 'w':
                    wCount++;
                    break;
                case 'a':
                    aCount++;
                    break;
                case 's':
                    sCount++;
                    break;
                case 'd':
                    dCount++;
                    break;
                default:
                    Console.WriteLine("Unknown perk!");
                    Console.WriteLine(c);
                    return;
                }
            }

            if(wCount + aCount + sCount+ dCount == 0){
                Console.WriteLine("No perks at all!");
                return;
            }

            if(wCount % 2 == 0 || wCount == 0)
                charPerks ^= Perks.WaterBreathing;
            if(aCount % 2 == 0 || aCount == 0)
                charPerks ^= Perks.AutoHeal;
            if(sCount % 2 == 0 || sCount == 0)
                charPerks ^= Perks.Stealth;
            if(dCount % 2 == 0 || dCount == 0)
                charPerks ^= Perks.DoubleJump;

            Console.WriteLine(charPerks);

            if((charPerks & Perks.DoubleJump) == Perks.DoubleJump
             && (charPerks & Perks.Stealth) == Perks.Stealth){
                Console.WriteLine("Silent jumper!");
            }

            if((charPerks & Perks.AutoHeal) != Perks.AutoHeal)
                Console.WriteLine("Not gonna make it!");

            
        }
    }
}
