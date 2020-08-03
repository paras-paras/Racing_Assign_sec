using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Assign_sec
{
   public class better:player
    {
        //this code is used to check the blance after winning or lossing the game 
        public int result(String Record, int winner, int Budget) {
            String []Recrd = Record.Split(' ');
            int Dog = Convert.ToInt32(Recrd[3]);
            int betAmount= Convert.ToInt32(Recrd[9]);
           // MessageBox.Show("" + Dog);
           // MessageBox.Show(""+betAmount);

            if (Dog == winner)
            {
                return Budget += betAmount;
            }
            else {
                return Budget -= betAmount;
            }
            
        }
    }
}
