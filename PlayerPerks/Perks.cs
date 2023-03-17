using System;
namespace PlayerPerks
{
    [Flags]
    public enum Perks
    {
        WaterBreathing = 1 ,
        Stealth = 2,
        AutoHeal = 4,
        DoubleJump = 8
    }
}