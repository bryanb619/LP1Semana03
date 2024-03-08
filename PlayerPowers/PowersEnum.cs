using System;

namespace PlayerPowers
{

    [Flags]
    public enum PowersEnum
    {
        Fly = 1 << 0, 
        XRayVision = 1 << 1,
        SuperStrength = 1 << 2,

    }
}