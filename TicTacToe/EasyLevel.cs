using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class EasyLevel : PublicProcedure
    {
        private readonly Random rnd = new Random();
        //public int current = 0;
        //public bool proverka = true;

        public EasyLevel()
        {
        }

        public EasyLevel(List<Button> btn)
        {
            this.btn = btn;
        }

        public void RandomX()
        {
            List<Button> knopka = new List<Button> 
            {
                btn[0], btn[1],btn[2],btn[3],btn[4],btn[5],btn[6],btn[7],btn[8]
            };
            int kl = rnd.Next(9);

            while (knopka.Count != 0 && knopka[kl].Tag != null)
            {
                knopka.RemoveAt(kl);
                kl = rnd.Next(knopka.Count);
            }
            MovesX(knopka[kl]);
            moves5 = true;
        }

    }
}
