using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame=0; frame <10; frame++)
            {
                if (rolls[frameIndex] + rolls[frameIndex+1] == 10)
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
                else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }
       
    }
}
