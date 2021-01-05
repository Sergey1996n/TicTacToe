using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Wunderkind : PublicProcedure
    {
        private readonly Random rnd = new Random();

        public Wunderkind()
        {
        }

        public Wunderkind(List<Button> btn)
        {
            this.btn = btn;
        }


        /*Если ход попадает на углы*/
        public void AnglesX()
        {
            if ((btn[0].Tag == null || btn[2].Tag == null || btn[6].Tag == null || btn[8].Tag == null) && !move)
            {
                if (btn[0].Tag == null && ((btn[1].Text == signOne && btn[2].Text == signOne) || (btn[3].Text == signOne && btn[6].Text == signOne) || (btn[4].Text == signOne && btn[8].Text == signOne)))
                {
                    MovesX(btn[0]);
}
                else if (btn[2].Tag == null && ((btn[0].Text == signOne && btn[1].Text == signOne) || (btn[4].Text == signOne && btn[8].Text == signOne) || (btn[4].Text == signOne && btn[6].Text == signOne)))
                {
                    MovesX(btn[2]);
}
                else if (btn[6].Tag == null && ((btn[7].Text == signOne && btn[8].Text == signOne) || (btn[0].Text == signOne && btn[3].Text == signOne) || (btn[2].Text == signOne && btn[4].Text == signOne)))
                {
                    MovesX(btn[6]);
                }
                else if (btn[8].Tag == null && ((btn[6].Text == signOne && btn[7].Text == signOne) || (btn[2].Text == signOne && btn[5].Text == signOne) || (btn[0].Text == signOne && btn[4].Text == signOne)))
                {
                    MovesX(btn[8]);
                }
            }
        }

        /*Если ход попадает на средние клетки*/
        public void MidX()
        {
            if ((btn[1].Tag == null || btn[3].Tag == null || btn[5].Tag == null || btn[7].Tag == null) && !move)
            {
                if (btn[1].Tag == null && ((btn[0].Text == signOne && btn[2].Text == signOne) || (btn[4].Text == signOne && btn[7].Text == signOne)))
                {
                    MovesX(btn[1]);
                }
                else if (btn[3].Tag == null && ((btn[4].Text == signOne && btn[5].Text == signOne) || (btn[0].Text == signOne && btn[6].Text == signOne)))
                {
                    MovesX(btn[3]);
                }
                else if (btn[5].Tag == null && ((btn[3].Text == signOne && btn[4].Text == signOne) || (btn[2].Text == signOne && btn[8].Text == signOne)))
                {
                    MovesX(btn[5]);
                }
                else if (btn[7].Tag == null && ((btn[6].Text == signOne && btn[8].Text == signOne) || (btn[1].Text == signOne && btn[4].Text == signOne)))
                {
                    MovesX(btn[7]);
                }
            }
        }

        /*Ход попадает на фигуры*/
        public void Vigure()
        {
            if ((btn[0].Tag == null || btn[2].Tag == null || btn[6].Tag == null || btn[8].Tag == null) && !move)
            {
                if (btn[0].Tag == null && ((btn[1].Text == signOne && (btn[3].Text == signOne || btn[6].Text == signOne)) || (btn[2].Text == signOne && btn[3].Text == signOne)))
                {
                    MovesX(btn[0]);
                }
                else if (btn[2].Tag == null && ((btn[1].Text == signOne && (btn[5].Text == signOne || btn[8].Text == signOne)) || (btn[0].Text == signOne && btn[5].Text == signOne)))
                {
                    MovesX(btn[2]);
                }
                else if (btn[6].Tag == null && ((btn[3].Text == signOne && (btn[7].Text == signOne || btn[8].Text == signOne)) || (btn[0].Text == signOne && btn[7].Text == signOne)))
                {
                    MovesX(btn[6]);
                }
                else if (btn[8].Tag == null && ((btn[5].Text == signOne && (btn[7].Text == signOne || btn[6].Text == signOne)) || (btn[2].Text == signOne && btn[7].Text == signOne)))
                {
                    MovesX(btn[8]);
                }
            }
        }

        public void MidButton()
        {
            List<Button> knopka = new List<Button>
            {
                btn[0], btn[2], btn[6], btn[8]
            };

            int kl = rnd.Next(4);

            while (knopka.Count != 0 && knopka[kl].Tag != null)
            {
                knopka.RemoveAt(kl);
                kl = rnd.Next(knopka.Count);
            }
            if (knopka.Count != 0)
            {
                MovesX(knopka[kl]);
            }
            else
            {
                knopka.Clear();
                knopka.Add(btn[1]);
                knopka.Add(btn[3]);
                knopka.Add(btn[5]);
                knopka.Add(btn[7]);

                kl = rnd.Next(4);

                while (knopka[kl].Tag != null)
                {
                    knopka.RemoveAt(kl);
                    kl = rnd.Next(knopka.Count);
                }

                MovesX(knopka[kl]);
            }
            moves5 = true;
        }
    }
}
