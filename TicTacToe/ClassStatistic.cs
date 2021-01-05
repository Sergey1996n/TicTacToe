using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    static class ClassStatistic
    {
        #region Статические переменные для статистики
        public static int newbielabel1 = 0;
        public static int newbielabel2 = 0;
        public static int newbielabel4 = 0;

        public static int amateurlabel1 = 0;
        public static int amateurlabel2 = 0;
        public static int amateurlabel4 = 0;

        public static int professionallabel1 = 0;
        public static int professionallabel2 = 0;
        public static int professionallabel4 = 0;

        public static int wunderkindlabel1 = 0;
        public static int wunderkindlabel2 = 0;
        public static int wunderkindlabel4 = 0;

        public static int twolabel1 = 0;
        public static int twolabel2 = 0;
        public static int twolabel3 = 0;
        public static int twolabel4 = 0;
        public static int twolabel5 = 0;
        #endregion

        #region Статические поля для параметров
        static public string playerOne = "Player1";
        static public string playerTwo = "Player2";
        static public bool newbie = true;
        static public bool amateur = false;
        static public bool professional = false;
        static public bool wunderkind = false;
        static public bool two = false;
        static public bool sign = true;
        #endregion

        #region Статические поля для оформления
        public static string background = "Control";
        public static int fontSize = 11;
        public static int fontName = 11;
        #endregion

        static string regKeyName = "Software\\MyCompanyName\\TicTacToe";
        public static void WriteStatistic()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("Newbielabel1", newbielabel1);
                rk.SetValue("Newbielabel2", newbielabel2);

                rk.SetValue("Amateurlabel1", amateurlabel1);
                rk.SetValue("Amateurlabel2", amateurlabel2);

                rk.SetValue("Professionallabel1", professionallabel1);
                rk.SetValue("Professionallabel2", professionallabel2);

                rk.SetValue("Wunderkindlabel1", wunderkindlabel1);
                rk.SetValue("Wunderkindlabel2", wunderkindlabel2);

                rk.SetValue("twolabel1", twolabel1);
                rk.SetValue("twolabel2", twolabel2);
                rk.SetValue("twolabel3", twolabel3);

                rk.SetValue("PlayerOne", playerOne);
                rk.SetValue("PlayerTwo", playerTwo);
                rk.SetValue("Newbie", newbie);
                rk.SetValue("Amateur", amateur);
                rk.SetValue("Professional", professional);
                rk.SetValue("Wunderkind", wunderkind);
                rk.SetValue("Two", two);

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadStatistic()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    newbielabel1 = (int)rk.GetValue("Newbielabel1");
                    newbielabel2 = (int)rk.GetValue("Newbielabel2");

                    amateurlabel1 = (int)rk.GetValue("Amateurlabel1");
                    amateurlabel2 = (int)rk.GetValue("Amateurlabel2");

                    professionallabel1 = (int)rk.GetValue("Professionallabel1");
                    professionallabel2 = (int)rk.GetValue("Professionallabel2");

                    wunderkindlabel1 = (int)rk.GetValue("Wunderkindlabel1");
                    wunderkindlabel2 = (int)rk.GetValue("Wunderkindlabel2");

                    twolabel1 = (int)rk.GetValue("twolabel1");
                    twolabel2 = (int)rk.GetValue("twolabel2");
                    twolabel3 = (int)rk.GetValue("twolabel3");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    playerOne = (string)rk.GetValue("PlayerOne");
                    playerTwo = (string)rk.GetValue("PlayerTwo");
                    newbie = Convert.ToBoolean(rk.GetValue("Newbie", true));
                    amateur = Convert.ToBoolean(rk.GetValue("Amateur", false));
                    professional = Convert.ToBoolean(rk.GetValue("Professional", false));
                    wunderkind = Convert.ToBoolean(rk.GetValue("Wunderkind", false));
                    two = Convert.ToBoolean(rk.GetValue("Two", false));
                    sign = Convert.ToBoolean(rk.GetValue("Sign", true));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void WriteParam()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("PlayerOne", playerOne);
                rk.SetValue("PlayerTwo", playerTwo);
                rk.SetValue("Newbie", newbie);
                rk.SetValue("Amateur", amateur);
                rk.SetValue("Professional", professional);
                rk.SetValue("Wunderkind", wunderkind);
                rk.SetValue("Two", two);
                rk.SetValue("Sign", sign);

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadLayout()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    background = (string)rk.GetValue("Background");
                    fontSize = (int)rk.GetValue("FontSize");
                    fontName = (int)rk.GetValue("FontName");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void WriteLayout()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("Background", background);
                rk.SetValue("FontSize", fontSize);
                rk.SetValue("FontName", fontName);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
