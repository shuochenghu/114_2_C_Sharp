using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    class Coin
    {
        private string sideUp; // 儲存目前朝上的面

        public Coin()
        {
            sideUp = "Heads"; // 預設為正面朝上
        }

        public void Toss()
        {
            Random rand = new Random();
            int side = rand.Next(2);
            if (side == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
