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
    public partial class fParameters : Form
    {
        public fParameters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassStatistic.newbie = rbNewbie.Checked;
            ClassStatistic.amateur = rbAmateur.Checked;
            ClassStatistic.professional = rbProfessional.Checked;
            ClassStatistic.wunderkind = rbWunderkind.Checked;
            ClassStatistic.two = rbTwo.Checked;
            ClassStatistic.playerOne = tbPlayerOne.Text;
            ClassStatistic.playerTwo = tbPlayerTwo.Text;
            ClassStatistic.WriteParam();
            if (rbX.Checked)
                ClassStatistic.sign = true;
            else
                ClassStatistic.sign = false;
            this.Hide();
        }

        void Set()
        {
            rbNewbie.Checked = ClassStatistic.newbie;
            rbAmateur.Checked = ClassStatistic.amateur;
            rbProfessional.Checked = ClassStatistic.professional;
            rbWunderkind.Checked = ClassStatistic.wunderkind;
            rbTwo.Checked = ClassStatistic.two;
            tbPlayerOne.Text = (string)ClassStatistic.playerOne;
            tbPlayerTwo.Text = (string)ClassStatistic.playerTwo;
            if (ClassStatistic.sign)
                rbX.Checked = true;
            else
                rbO.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void fParameters_Load(object sender, EventArgs e)
        {
            Set();
            TwoChecked();
        }

        private void rbTwo_CheckedChanged(object sender, EventArgs e)
        {
            TwoChecked();
        }

        void TwoChecked()
        {
            if (rbTwo.Checked)
            {
                tbPlayerOne.Enabled = true;
                tbPlayerTwo.Enabled = true;
            }
            else
            {
                tbPlayerOne.Enabled = false;
                tbPlayerTwo.Enabled = false;
            }
        }
    }
}
