namespace Sticker_Generator
{
    partial class MarkerGenerator
    {
        struct OctalNumber
        {
            public byte Value { get; set; }

            public OctalNumber(bool firstBit, bool secondBit, bool thirdBit)
            {
                if (!thirdBit && !secondBit && !firstBit)       //000
                {
                    Value = 0;
                }
                else if (!thirdBit && !secondBit && firstBit)   //001
                {
                    Value = 1;
                }
                else if (!thirdBit && secondBit && !firstBit)   //010
                {
                    Value = 2;
                }
                else if (!thirdBit && secondBit && firstBit)    //011
                {
                    Value = 3;
                }
                else if (thirdBit && !secondBit && !firstBit)   //100
                {
                    Value = 4;
                }
                else if (thirdBit && !secondBit && firstBit)    //101
                {
                    Value = 5;
                }
                else if (thirdBit && secondBit && !firstBit)    //110
                {
                    Value = 6;
                }
                else if (thirdBit && secondBit && !firstBit)    //111
                {
                    Value = 7;
                }
                else
                {
                    Value = 0;
                }
            }
        }
    }
}