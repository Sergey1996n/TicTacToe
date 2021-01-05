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
    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fStatistic_Load(object sender, EventArgs e)
        {
            Statistic();
        }

        void Statistic()
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Проведено игр: " + ClassStatistic.newbielabel1;
                    label2.Text = "Выиграно: " + ClassStatistic.newbielabel2;
                    if (ClassStatistic.newbielabel1 != 0)
                    {
                        Reset.Enabled = true;
                        label3.Text = "Процент выигрышей: "+ 100 * Math.Round(Convert.ToDouble(ClassStatistic.newbielabel2) / Convert.ToDouble(ClassStatistic.newbielabel1), 4) + "%";
                    }
                    else
                    {
                        Reset.Enabled = false;
                        label3.Text = "Процент выигрышей: " + ClassStatistic.newbielabel1 + "%";
                    }
                    label4.Text = "В текущем сеансе: " + ClassStatistic.newbielabel4;
                    break;

                case 1:
                    label1.Text = "Проведено игр: " + ClassStatistic.amateurlabel1;
                    label2.Text = "Выиграно: " + ClassStatistic.amateurlabel2;
                    if (ClassStatistic.amateurlabel1 != 0)
                    {
                        Reset.Enabled = true;
                        label3.Text = "Процент выигрышей: " + 100 * Math.Round(Convert.ToDouble(ClassStatistic.amateurlabel2) / Convert.ToDouble(ClassStatistic.amateurlabel1), 4) + "%";
                    }
                    else
                    {
                        Reset.Enabled = false;
                        label3.Text = "Процент выигрышей: " + ClassStatistic.amateurlabel1 + "%";
                    }
                    label4.Text = "В текущем сеансе: " + ClassStatistic.amateurlabel4;
                    break;

                case 2:
                    label1.Text = "Проведено игр: " + ClassStatistic.professionallabel1;
                    label2.Text = "Выиграно: " + ClassStatistic.professionallabel2;
                    if (ClassStatistic.professionallabel1 != 0)
                    {
                        Reset.Enabled = true;
                        label3.Text = "Процент выигрышей: " + 100 * Math.Round(Convert.ToDouble(ClassStatistic.professionallabel2) / Convert.ToDouble(ClassStatistic.professionallabel1), 4) + "%";
                    }
                    else
                    {
                        Reset.Enabled = false;
                        label3.Text = "Процент выигрышей: " + ClassStatistic.professionallabel1 + "%";
                    }
                    label4.Text = "В текущем сеансе: " + ClassStatistic.professionallabel4;
                    break;

                case 3:
                    label1.Text = "Проведено игр: " + ClassStatistic.wunderkindlabel1;
                    label2.Text = "Выиграно: " + ClassStatistic.wunderkindlabel2;
                    if (ClassStatistic.wunderkindlabel1 != 0)
                    {
                        Reset.Enabled = true;
                        label3.Text = "Процент выигрышей: " + 100 * Math.Round(Convert.ToDouble(ClassStatistic.wunderkindlabel2) / Convert.ToDouble(ClassStatistic.wunderkindlabel1), 4) + "%";
                    }
                    else
                    {
                        Reset.Enabled = false;
                        label3.Text = "Процент выигрышей: " + ClassStatistic.wunderkindlabel1 + "%";

                    }
                    label4.Text = "В текущем сеансе: " + ClassStatistic.wunderkindlabel4;
                    break;
                case 4:
                    label1.Text = "Проведено игр: " + ClassStatistic.twolabel1;
                    label2.Text = "Выиграно первым игроком: " + ClassStatistic.twolabel2;
                    label3.Text = "Выиграно вторым игроком: " + ClassStatistic.twolabel3;
                    label4.Text = "Счёт в текущем сеансе: " + ClassStatistic.twolabel4 + ":" + ClassStatistic.twolabel5;
                    break;

                default:
                    break;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Statistic();
        }
    }
}
