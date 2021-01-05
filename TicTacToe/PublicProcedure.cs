using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class PublicProcedure
    {

        public bool move;
        public bool moves5;
        public bool start;
        public string signOne;
        public string signTwo;
        public List<Button> btn = new List<Button>();

        public PublicProcedure()
        {
            if (ClassStatistic.sign)
            {
                
                signTwo = "O";
                signOne = "X";
            }
            else
            {
                signTwo = "X";
                signOne = "O";
            }
        }
        public PublicProcedure(List < Button > btn)
        {
            this.btn = btn;

                
        }

        public void NewGame()
        {
            for (int i = 0; i < 9; i++)
            {
                btn[i].Text = "";
                btn[i].Tag = null;
            }
            start = true;
            move = false;
            moves5 = false;
        }

        void MyShowMessage(Button publicButton)
        {
            MessageBox.Show("Победили " + publicButton.Text);
            NewGame();
        }

        /*Если можно выиграть на углах */
        public void AnglesO()
        {
            if ((btn[0].Tag == null || btn[2].Tag == null || btn[6].Tag == null || btn[8].Tag == null) && !move)
            {
                if (btn[0].Tag == null && ((btn[1].Text == signTwo && btn[2].Text == signTwo) || (btn[3].Text == signTwo && btn[6].Text == signTwo) || (btn[4].Text == signTwo && btn[8].Text == signTwo)))
                {
                    MovesX(btn[0]);
                }
                else if (btn[2].Tag == null && ((btn[0].Text == signTwo && btn[1].Text == signTwo) || (btn[5].Text == signTwo && btn[8].Text == signTwo) || (btn[4].Text == signTwo && btn[6].Text == signTwo)))
                {
                    MovesX(btn[2]);
                }
                else if (btn[6].Tag == null && ((btn[7].Text == signTwo && btn[8].Text == signTwo) || (btn[0].Text == signTwo && btn[3].Text == signTwo) || (btn[2].Text == signTwo && btn[4].Text == signTwo)))
                {
                    MovesX(btn[6]);
                }
                else if (btn[8].Tag == null && ((btn[6].Text == signTwo && btn[7].Text == signTwo) || (btn[2].Text == signTwo && btn[5].Text == signTwo) || (btn[0].Text == signTwo && btn[4].Text == signTwo)))
                {
                    MovesX(btn[8]);
                }
            }
        }

        /*Если можно выиграть на средних клетках*/
        public void MidO()
        {
            if ((btn[1].Tag == null || btn[3].Tag == null || btn[5].Tag == null || btn[7].Tag == null) && !move)
            {
                if (btn[1].Tag == null && ((btn[0].Text == signTwo && btn[2].Text == signTwo) || (btn[4].Text == signTwo && btn[7].Text == signTwo)))
                {
                    MovesX(btn[1]);
                }
                else if (btn[3].Tag == null && ((btn[4].Text == signTwo && btn[5].Text == signTwo) || (btn[0].Text == signTwo && btn[6].Text == signTwo)))
                {
                    MovesX(btn[3]);
                }
                else if (btn[5].Tag == null && ((btn[3].Text == signTwo && btn[4].Text == signTwo) || (btn[2].Text == signTwo && btn[8].Text == signTwo)))
                {
                    MovesX(btn[5]);
                }
                else if (btn[7].Tag == null && ((btn[6].Text == signTwo && btn[8].Text == signTwo) || (btn[1].Text == signTwo && btn[4].Text == signTwo)))
                {
                    MovesX(btn[7]);
                }
            }
        }

        public void MovesX(Button publicButton)
        {
            publicButton.Text = signTwo;
            publicButton.Tag = "1";
            CheckWin(publicButton);
            move = true;
        }

        public bool CheckWin(Button publicButton)
        {
            if (btn[0].Text == btn[1].Text && btn[1].Text == btn[2].Text && btn[2].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }
            else if (btn[3].Text == btn[4].Text && btn[4].Text == btn[5].Text && btn[5].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }
            else if (btn[6].Text == btn[7].Text && btn[7].Text == btn[8].Text && btn[8].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }

            else if (btn[0].Text == btn[3].Text && btn[3].Text == btn[6].Text && btn[6].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }
            else if (btn[1].Text == btn[4].Text && btn[4].Text == btn[7].Text && btn[7].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }
            else if (btn[2].Text == btn[5].Text && btn[5].Text == btn[8].Text && btn[8].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }

            else if (btn[0].Text == btn[4].Text && btn[4].Text == btn[8].Text && btn[8].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }
            else if (btn[2].Text == btn[4].Text && btn[4].Text == btn[6].Text && btn[6].Tag != null)
            {
                MyShowMessage(publicButton);
                return true;
            }
            else
                return false;
        }


    }
}
