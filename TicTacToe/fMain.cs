using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class fMain : Form
    {

        bool xTurn = true;
        //public bool start = true;
        public List<Button> btn = new List<Button>();

        EasyLevel easyLevel = new EasyLevel();
        MiddleLevel middleLevel = new MiddleLevel();
        HardLevel hardLevel = new HardLevel();
        Wunderkind wunderkind = new Wunderkind();
        TwoLevel twoLevel = new TwoLevel();

        public fMain()
        {
            InitializeComponent();
            btn.Add(button1);
            btn.Add(button2);
            btn.Add(button3);
            btn.Add(button4);
            btn.Add(button5);
            btn.Add(button6);
            btn.Add(button7);
            btn.Add(button8);
            btn.Add(button9);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderB = (Button)sender;
            /*На двоих*/
            if (ClassStatistic.two)
            {
                if (twoLevel.start)
                    ClassStatistic.twolabel1 += 1;
                twoLevel.start = false;
                if (senderB.Tag == null)
                {
                    if (xTurn)
                    {
                        senderB.Text = twoLevel.signOne;
                        senderB.Tag = "1";
                        label1.Text = "Ходит " + ClassStatistic.playerTwo;
                        if (twoLevel.CheckWin(senderB))
                        {
                            ClassStatistic.twolabel2 += 1;
                            ClassStatistic.twolabel4 += 1;
                        }
                    }
                    else
                    {
                        senderB.Text = twoLevel.signTwo;
                        senderB.Tag = "1";
                        label1.Text = "Ходит " + ClassStatistic.playerOne;
                        if (twoLevel.CheckWin(senderB))
                        {
                            ClassStatistic.twolabel3 += 1;
                            ClassStatistic.twolabel5 += 1;
                        }
                    }
                    
                    xTurn = !xTurn;
                    if (button1.Tag == button2.Tag && button2.Tag == button3.Tag && button3.Tag == button4.Tag && button4.Tag == button5.Tag && button5.Tag == button6.Tag && button6.Tag == button7.Tag && button7.Tag == button8.Tag && button8.Tag == button9.Tag && button9.Tag == "1")
                    {
                        MessageBox.Show("Произошла ничья!!");
                        NewGame();
                    }
                }
                
            }
            else
            {
                if (senderB.Tag == null)
                {
                    MovePlayer(senderB);

                    #region ИИ
                    /*Лёгкий*/
                    if (ClassStatistic.newbie)
                    {
                        if (easyLevel.start)
                            ClassStatistic.newbielabel1 += 1;
                        easyLevel.start = false;

                        if (button1.Tag == button2.Tag && button2.Tag == button3.Tag && button3.Tag == button4.Tag && button4.Tag == button5.Tag && button5.Tag == button6.Tag && button6.Tag == button7.Tag && button7.Tag == button8.Tag && button8.Tag == button9.Tag)
                        {
                            MessageBox.Show("Произошла ничья!!");
                            NewGame();
                        }
                        else
                        {
                            if (easyLevel.CheckWin(senderB))
                            {
                                ClassStatistic.newbielabel2 += 1;
                                ClassStatistic.newbielabel4 += 1;
                            }
                            if (!easyLevel.start)
                            {
                                easyLevel.AnglesO();
                                easyLevel.MidO();
                                easyLevel.RandomX();
                            }
                        }
                    }
                    /*Средний*/
                    else if (ClassStatistic.amateur)
                    {
                        if (middleLevel.start)
                            ClassStatistic.amateurlabel1 += 1;
                        middleLevel.start = false;

                        if (button1.Tag == button2.Tag && button2.Tag == button3.Tag && button3.Tag == button4.Tag && button4.Tag == button5.Tag && button5.Tag == button6.Tag && button6.Tag == button7.Tag && button7.Tag == button8.Tag && button8.Tag == button9.Tag)
                        {
                            MessageBox.Show("Произошла ничья!!");
                            NewGame();
                        }
                        else
                        {
                            if (middleLevel.CheckWin(senderB))
                            {
                                ClassStatistic.amateurlabel2 += 1;
                                ClassStatistic.amateurlabel4 += 1;
                            }
                            if (!middleLevel.start)
                            {
                                if (button5.Tag == null)
                                {
                                    middleLevel.MovesX(button5);
                                    middleLevel.moves5 = true;
                                }

                                middleLevel.AnglesO();
                                middleLevel.MidO();
                                middleLevel.AnglesX();

                                /*Если пользователь нажал на середину*/
                                if (!middleLevel.moves5)
                                    middleLevel.MidButton();

                                if (!middleLevel.move)
                                    middleLevel.RandomX();
                                middleLevel.move = !middleLevel.move;
                                middleLevel.start = false;
                            }
                        }
                    }
                    /*Сложный*/
                    else if (ClassStatistic.professional)
                    {
                        if (hardLevel.start)
                            ClassStatistic.professionallabel1 += 1;
                        hardLevel.start = false;

                        if (button1.Tag == button2.Tag && button2.Tag == button3.Tag && button3.Tag == button4.Tag && button4.Tag == button5.Tag && button5.Tag == button6.Tag && button6.Tag == button7.Tag && button7.Tag == button8.Tag && button8.Tag == button9.Tag)
                        {
                            MessageBox.Show("Произошла ничья!!");
                            NewGame();
                        }
                        else
                        {
                            if (hardLevel.CheckWin(senderB))
                            {
                                ClassStatistic.professionallabel2 += 1;
                                ClassStatistic.professionallabel4 += 1;
                            }
                            if (!hardLevel.start)
                            {
                                if (button5.Tag == null)
                                {
                                    hardLevel.MovesX(button5);
                                    hardLevel.moves5 = true;
                                }

                                hardLevel.AnglesO();
                                hardLevel.MidO();
                                hardLevel.AnglesX();
                                hardLevel.MidX();

                                /*Если пользователь нажал на середину*/
                                if (!hardLevel.moves5 && !hardLevel.start)
                                    hardLevel.MidButton();

                                if (!hardLevel.move && !hardLevel.start)
                                    hardLevel.RandomX();
                                hardLevel.move = !hardLevel.move;
                                hardLevel.start = false;
                            }
                        }
                    }
                    /*Непроходимый*/
                    else if (ClassStatistic.wunderkind)
                    {
                        if (wunderkind.start)
                            ClassStatistic.wunderkindlabel1 += 1;
                        wunderkind.start = false;
                        if (!wunderkind.start)
                        {
                            if (button1.Tag == button2.Tag && button2.Tag == button3.Tag && button3.Tag == button4.Tag && button4.Tag == button5.Tag && button5.Tag == button6.Tag && button6.Tag == button7.Tag && button7.Tag == button8.Tag && button8.Tag == button9.Tag)
                            {
                                MessageBox.Show("Произошла ничья!!");
                                NewGame();
                            }
                            else
                            {
                                if (wunderkind.CheckWin(senderB))
                                {
                                    ClassStatistic.wunderkindlabel2 += 1;
                                    ClassStatistic.wunderkindlabel4 += 1;
                                }
                                if (button5.Tag == null)
                                {
                                    wunderkind.MovesX(button5);
                                    wunderkind.moves5 = true;
                                }
                                wunderkind.AnglesO();
                                wunderkind.MidO();
                                wunderkind.AnglesX();
                                wunderkind.MidX();
                                wunderkind.Vigure();

                                /*Если пользователь нажал на середину*/
                                if (wunderkind.moves5 == false && wunderkind.start == false)
                                    wunderkind.MidButton();

                                if (button5.Tag == "1" && ((button1.Tag == "1" && button9.Tag == "1") || (button3.Tag == "1" && button7.Tag == "1")) && !wunderkind.move)
                                    wunderkind.MidButton();
                                wunderkind.move = !wunderkind.move;
                                wunderkind.start = false;
                            }

                        }
                    }
                    
                }
                #endregion
            }
        }

        void MovePlayer(Button senderB)
        {
            if (ClassStatistic.sign)
                senderB.Text = "X";
            else
                senderB.Text = "O";
            senderB.Tag = "1";
        }
        void NewGame()
        {
            label1.Visible = false;
            FontSize();
            if (ClassStatistic.newbie)
            {
                EasyLevel easy = new EasyLevel(btn);
                easyLevel = easy;
                easyLevel.NewGame();
            }
            else if (ClassStatistic.amateur)
            {
                MiddleLevel middle = new MiddleLevel(btn);
                middleLevel = middle;
                middleLevel.NewGame();
            }
            else if (ClassStatistic.professional)
            {
                HardLevel hard = new HardLevel(btn);
                hardLevel = hard;
                hardLevel.NewGame();
            }
            else if (ClassStatistic.wunderkind)
            {
                Wunderkind wunder = new Wunderkind(btn);
                wunderkind = wunder;
                wunderkind.NewGame();
            }
            else if (ClassStatistic.two)
            {
                TwoLevel two = new TwoLevel(btn);
                twoLevel = two;
                twoLevel.NewGame();
                label1.Visible = true;
                label1.Text = "Ходит " + ClassStatistic.playerOne;

            }
        }

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void tsmiStatistics_Click(object sender, EventArgs e)
        {
            fStatistic fStatistic = new fStatistic();
            fStatistic.ShowDialog(this);
        }

        private void tsmiParameters_Click(object sender, EventArgs e)
        {
            fParameters fParameters = new fParameters();
            fParameters.ShowDialog(this);
            NewGame();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            fAboutBox fAboutBox = new fAboutBox();
            fAboutBox.ShowDialog();
        }

        private void tsmiOtherGames_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Упс! Пока ничего другого не имеется");
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassStatistic.WriteStatistic();
            ClassStatistic.WriteLayout();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            ClassStatistic.ReadStatistic();
            ClassStatistic.ReadParam();
            ClassStatistic.ReadLayout();
            NewGame();
        }

        private void tsmiChangeLayout_Click(object sender, EventArgs e)
        {
            fChangeLayout changeLayout = new fChangeLayout();
            changeLayout.ShowDialog();
            FontSize();
        }

        private void tsmiViewHelp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Упс! Это ещё не доработали!");
            Help.ShowHelp(this, helpProvider1.HelpNamespace);

        }

        private void FontSize()
        {
            for (int i = 0; i < btn.Count; i++)
            {
                btn[i].BackColor = Color.FromName(ClassStatistic.background);
                btn[i].Font = new Font(this.Font.Name, ClassStatistic.fontSize);
            }
            label1.Font = new Font(label1.Font.Name, ClassStatistic.fontName);

        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            
        }

        private void fMain_Activated(object sender, EventArgs e)
        {
          
        }

        private void fMain_Enter(object sender, EventArgs e)
        {
        
        }
    }

    
}
