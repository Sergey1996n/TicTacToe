using Microsoft.VisualBasic.Compatibility.VB6;
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
    public partial class fChangeLayout : Form
    {
        public fChangeLayout()
        {
            InitializeComponent();
        }

        private void fChangeLayout_Load(object sender, EventArgs e)
        {
            Set();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassStatistic.background = listView1.Items[listView1.SelectedIndices[0]].Text;
            ClassStatistic.fontSize = (int)nupXO.Value;
            ClassStatistic.fontName = (int)nupName.Value;
            this.Close();
        }

        void Set()
        {
            nupName.Value = ClassStatistic.fontName;
            nupXO.Value = ClassStatistic.fontSize;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == ClassStatistic.background)
                    listView1.Items[i].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Set();
            this.Close();
        }
    }
}
