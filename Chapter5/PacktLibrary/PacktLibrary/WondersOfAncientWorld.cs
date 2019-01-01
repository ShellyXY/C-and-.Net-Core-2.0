using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    [System.Flags]
    public enum WonderOfTheAncientWorld:byte
    {
        None = 0,
        GreatPyramidOfGiza = 1,
        HangingGardensOfBabylon = 1 << 1, // i.e. 2
        StatueOfZeusAtOlympia = 1 << 2, // i.e. 4
        TempleOfArtemisAtEphesus = 1 << 3, // i.e. 8
        MausoleumAtHalicarnassus = 1 << 4, // i.e. 16
        ColossusOfRhodes = 1 << 5, // i.e. 32
        LighthouseOfAlexandria = 1 << 6 // i.e. 64
    }
}
