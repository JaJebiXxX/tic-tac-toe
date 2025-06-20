using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windąs
{
    internal class Logika
    {
        
        public int[,] plansza = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        Boolean TuraO = true;
        String historia;
        public int ruch = 0;
        public int CzyWygrana()
        {
            if (plansza[0,0] + plansza[1,0] + plansza[2,0] == 3 || plansza[1,0] + plansza[1,1] + plansza[1,2] == 3 || plansza[2,0] + plansza[2,1] + plansza[2,2] == 3 || 
                plansza[0,0] + plansza[0,1] + plansza[0,2] == 3 || plansza[0,1] + plansza[1,1] + plansza[2,1] == 3 || plansza[0,2] + plansza[1,2] + plansza[2,2] == 3 ||
                plansza[0,0] + plansza[1,1] + plansza[2,2] == 3 || plansza[2,0] + plansza[1,1] + plansza[0,2] == 3) 
            {
                return 3;
            }
            else if (plansza[0,0] + plansza[1,0] + plansza[2,0] == 12 || plansza[1,0] + plansza[1,1] + plansza[1,2] == 12 || plansza[2,0] + plansza[2,1] + plansza[2,2] == 12 ||
                plansza[0,0] + plansza[0,1] + plansza[0,2] == 12 || plansza[0,1] + plansza[1,1] + plansza[2,1] == 12 || plansza[0,2] + plansza[1,2] + plansza[2,2] == 12 ||
                plansza[0,0] + plansza[1,1] + plansza[2,2] == 12 || plansza[2,0] + plansza[1,1] + plansza[0,2] == 12)
            {
                return 12;
            }
            else if (ruch == 9)
            {
                return -1;
            }
            else 
            {
                return 0;
            }
        }
        private Boolean WhosTurn()
        {
            TuraO = !TuraO;
            return !TuraO;
        }
        public void Ustawienie(int ktory1, int ktory2)
        {
            if (plansza[ktory1,ktory2] == 0) {
				plansza[ktory1, ktory2] = WhosTurn() ? 1 : 4;
                historia += plansza[ktory1, ktory2] == 1 ? "O " : "X ";
                historia += "na (" + ktory1 + "," + ktory2 + ")" + Environment.NewLine;
                ruch++;
			}
        }
        public void reset()
        {
            TuraO = true;
            Array.Clear(plansza,0, plansza.Length);
            historia = "";
            ruch = 0;
        }
        public string GetHistory()
        {
            return historia;
        }
        
    }
}
