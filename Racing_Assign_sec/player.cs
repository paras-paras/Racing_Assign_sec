using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Assign_sec
{
   public class player
    {

        Random rd = new Random();
        //genreate the random no to move the dog to forward
        public int Dog_run() {
            return rd.Next(45);
        }

        // this code i used to check the budget of the btter is he ha enough balance for bet or not 
        public int checkBudget(int budget,int bet) {
            if ( bet<= budget)
            {
                return 1;
            }
            else {
                return 0;
            }
        }

    }
}
