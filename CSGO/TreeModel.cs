using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    public class TreeModel
    {
        private String result = "null";
        private double betwinner;
        private double bet365;
        private double xbetco;
        private double betway;
        private double thunderpick;
        private double pinnacle;
        private double unibet;
        private double onexbet;
        private double pari_match;
        private double ggbet;

        public TreeModel(double[] userInput){
            this.betwinner = userInput[0];
            this.unibet = userInput[1];
            this.bet365 = userInput[2];
            this.xbetco = userInput[3];
            this.betway = userInput[4];
            this.thunderpick = userInput[5];
            this.pinnacle = userInput[6];
            this.onexbet = userInput[7];
            this.pari_match = userInput[8];
            this.ggbet = userInput[9];
        }
        public void startSearch()
        {
            if (this.betwinner > 2.665)
            {
                leftBrach();
            }
            else if (this.betwinner <= 2.665)
            {
                rightBrach();
            }
        }

        private void leftBrach()
        {
            if (this.unibet <= 2.825)
            {
                this.result = "Lose";
            }
            else if (this.unibet > 2.825)
            {
                lB2L();
            }
        }

        private void lB2L()
        {
            if (this.bet365 <= 2.875)
            {
                lB3LR();
            }
            else if (this.bet365 > 2.875)
            {
                lB3LL();
            }
        }

        private void lB3LR()
        {
            if (this.pinnacle <= 2.61)
            {
                this.result = "Lose";
            }
            else if (this.bet365 > 2.61)
            {
                this.result = "Win";
            }
        }

        private void lB3LL()
        {
            if (this.xbetco <= 3.525)
            {
                this.result = "Lose";
            }
            else if (this.bet365 > 3.525)
            {
                lB4LLL();
            }
        }

        private void lB4LLL()
        {
            if (this.betway <= 3.9)
            {
                this.result = "Win";
            }
            else if (this.betway > 3.9)
            {
                lB5LLLL();
            }
        }

        private void lB5LLLL()
        {
            if (this.thunderpick <= 4.45)
            {
                this.result = "Lose";
            }
            else if (this.thunderpick > 4.45)
            {
                lB6LLLLL();
            }
        }

        private void lB6LLLLL()
        {
            if (this.betway <= 6.125)
            {
                this.result = "Win";
            }
            else if (this.betway > 6.125)
            {
                this.result = "Lose";
            }
        }



        private void rightBrach()
        {
            if (bet365 <= 1.38)
            {
                rB2R();
            }
            else if (bet365 > 1.38)
            {
                rB2L();
            }
        }

        private void rB2R()
        {
            if (this.xbetco > 1.325)
            {
                this.result = "Win";
            }
            else if (this.xbetco <= 1.325)
            {
                rB3RR();
            }
        }

        private void rB3RR()
        {
            if (this.betway > 1.225)
            {
                this.result = "Lose";
            }
            else if (this.betway <= 1.26)
            {
                rB4RRR();
            }
        }

        private void rB4RRR()
        {
            if (this.thunderpick > 1.155)
            {
                this.result = "Win";
            }
            else if (this.thunderpick <= 1.155)
            {
                rB5RRRR();
            }
        }

        private void rB5RRRR()
        {
            if (this.ggbet > 1.135)
            {
                this.result = "Win";
            }
            else if (this.ggbet <= 1.135)
            {
                this.result = "Lose";
            }
        }

        private void rB2L()
        {
            if (this.betwinner > 2.495)
            {
                rB3LL();
            }
            else if (this.betwinner <= 2.495)
            {
                rB3RL();
            }
        }

        private void rB3LL()
        {
            if (this.pinnacle > 2.55)
            {
                this.result = "Lose";
            }
            else if (this.pinnacle <= 2.55)
            {
                this.result = "Win";
            }
        }

        private void rB3RL()
        {
            if (this.thunderpick > 2.345)
            {
                this.result = "Lose";
            }
            else if (this.thunderpick <= 2.345)
            {
                rB4RRL();
            }
        }

        private void rB4RRL()
        {
            if (this.unibet <= 1.315)
            {
                this.result = "Lose";
            }
            else if (this.unibet > 1.315)
            {
                rB5LRRL();
            }
        }

        private void rB5LRRL()
        {
            if (this.xbetco <= 1.39)
            {
                this.result = "Win";
            }
            else if (this.xbetco > 1.39)
            {
                rB6LLRRL();
            }
        }

        private void rB6LLRRL()
        {
            if (this.onexbet <= 1.475)
            {
                this.result = "Lose";
            }
            else if (this.onexbet > 1.475)
            {
                rB7LLLRRL();
            }
        }

        private void rB7LLLRRL()
        {
            if (this.betway <= 1.675)
            {
                rB8RLLLRRL();
            }
            else if (this.betway > 1.675)
            {
                rB8LLLLRRL();
            }
        }

        private void rB8RLLLRRL()
        {
            if (this.xbetco <= 1.43)
            {
                this.result = "Lose";
            }
            else if (this.xbetco > 1.43)
            {
                rB9LRLLLRRL();
            }
        }

        private void rB9LRLLLRRL()
        {
            if (this.unibet > 1.55)
            {
                this.result = "Win";
            }
            else if (this.unibet > 1.55)
            {
                rB10RLRLLLRRL();
            }
        }

        private void rB10RLRLLLRRL()
        {
            if (this.pinnacle > 1.53)
            {
                this.result = "Lose";
            }
            else if (this.pinnacle > 1.53)
            {
                this.result = "Win";
            }
        }

        private void rB8LLLLRRL()
        {
            if (this.xbetco <= 1.705)
            {
                this.result = "Lose";
            }
            else if (this.xbetco > 1.705)
            {
                rB9LLLLLRRL();
            }
        }

        private void rB9LLLLLRRL()
        {
            if (this.pari_match > 2.005)
            {
                rB10LLLLLLRRL();
            }
            else if (this.pari_match <= 2.005)
            {
                rB10RLLLLLRRL();
            }
        }

        private void rB10LLLLLLRRL()
        {
            if (this.pinnacle > 2.259)
            {
                this.result = "Lose";
            }
            else if (this.pinnacle <= 2.259)
            {
                this.result = "Win";
            }
        }

        private void rB10RLLLLLRRL()
        {
            if (this.onexbet > 1.865)
            {
                this.result = "Lose";
            }
            else if (this.onexbet <= 1.865)
            {
                rB11RRLLLLLRRL();
            }
        }

        private void rB11RRLLLLLRRL()
        {
            if (this.pari_match > 1.765)
            {
                this.result = "Win";
            }
            else if (this.pari_match <= 1.765)
            {
                rB12RRRLLLLLRRL();
            }
        }

        private void rB12RRRLLLLLRRL()
        {
            if (this.ggbet > 1.57)
            {
                this.result = "Lose";
            }
            else if (this.ggbet <= 1.57)
            {
                this.result = "Win";
            }
        }


        public String getResult()
        {
            return this.result;
        }

    }
}
