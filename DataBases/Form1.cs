using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Kd_SelectedIndexChanged(object sender, EventArgs e)
        {

            double Kr1 = 0;
            switch (Kd.Text)
            {
                case "1000": Kr1 = 500; break;
                case "870": Kr1 = 435; break;
                case "835": Kr1 = 417.5; break;
            }

            Kr.Text = Convert.ToString(Kr1);
        }



        private void u_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] T11 = new string[4];

            switch (u.Text)
            {
                case "1":
                    {
                        T11[0] = "47";
                        T11[1] = "93";
                        T11[2] = "135";
                        T11[3] = "180";
                        break;
                    }
                case "1,25":
                    {
                        T11[0] = "61";
                        T11[1] = "95";
                        T11[2] = "122";
                        T11[3] = "190";
                        break;
                    }
                case "1,4":
                    {
                        T11[0] = "50";
                        T11[1] = "73";
                        T11[2] = "101";
                        T11[3] = "145";
                        break;
                    }
                case "1,6":
                    {
                        T11[0] = "41";
                        T11[1] = "55";
                        T11[2] = "113";
                        T11[3] = "229";
                        break;
                    }
                case "2":
                    {
                        T11[0] = "49";
                        T11[1] = "69";
                        T11[2] = "99";
                        T11[3] = "141";
                        break;
                    }
                case "2,5":
                    {
                        string[] T111 = new string[3];
                        T111[0] = "71";
                        T111[1] = "118";
                        T111[2] = "157";

                        T1.Items.Clear();
                        T1.Items.AddRange(T111);
                        return;
                    }
                case "3,15":
                    {
                        string[] T111 = new string[2];
                        T111[0] = "105";
                        T111[1] = "152";

                        T1.Items.Clear();
                        T1.Items.AddRange(T111);
                        return;
                    }
                case "4":
                    {
                        string[] T111 = new string[2];
                        T111[0] = "145";
                        T111[1] = "207";

                        T1.Items.Clear();
                        T1.Items.AddRange(T111);
                        return;
                    }
            }

            T1.Items.Clear();
            T1.Items.AddRange(T11);
        }

        private void Kbee_TextChanged(object sender, EventArgs e)
        {
            double Kbe = Convert.ToDouble(Kbee.Text);
            double uu = Convert.ToDouble(u.Text + 1);
            uu = uu - 1;


            double Shirr = (Kbe * uu) / (2.0 - Kbe);

            if(Shirr < 0.3)
            {
                Shirr = 0.2;
            }
            else
            {
                if (Shirr < 0.5)
                {
                    Shirr = 0.4;
                }
                else
                {
                    if (Shirr < 0.7)
                    {
                        Shirr = 0.6;
                    }
                    else
                    {
                        if (Shirr < 0.9)
                        {
                            Shirr = 0.8;
                        }
                        else
                        {
                            if (Shirr >= 0.9)
                            {
                                Shirr = 1;
                            }
                        }
                    }
                }
            }

            Shir.Text = Convert.ToString(Shirr);
        }

        private void Zv_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Shirr = Convert.ToDouble(Shir.Text);

            switch (Op.Text)
            {
                case "Шариковые":
                    {
                        switch (Td.Text)
                        {
                            case "HB > 350":
                                {
                                    switch (Zv.Text)
                                    {
                                        case "Прямые и тангенциальные":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {
                                                            Khb.Text = "1,16";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {
                                                            Khb.Text = "1,37";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1,58";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {

                                                            Khb.Text = "1,80";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "0";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                        case "Круглые":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {

                                                            Khb.Text = "1,08";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {

                                                            Khb.Text = "1,18";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1,29";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {
                                                            Khb.Text = "1,40";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "0";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case "HB =< 350":
                                {
                                    switch (Zv.Text)
                                    {
                                        case "Прямые и тангенциальные":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {

                                                            Khb.Text = "1,07";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {

                                                            Khb.Text = "1,14";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1,23";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {

                                                            Khb.Text = "1,34";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "1,0";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                        case "Круглые":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {

                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {
                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {
                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }

                        break;
                    }
                case "Роликовые":
                    {
                        switch (Td.Text)
                        {
                            case "HB > 350":
                                {
                                    switch (Zv.Text)
                                    {
                                        case "Прямые и тангенциальные":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {

                                                            Khb.Text = "1,08";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {
                                                            Khb.Text = "1,20";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1,32";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {
                                                            Khb.Text = "1,44";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "1,55";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                        case "Круглые":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {

                                                            Khb.Text = "1,04";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {

                                                            Khb.Text = "1,10";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1,15";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {
                                                            Khb.Text = "1,22";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "1,28";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case "HB =< 350":
                                {
                                    switch (Zv.Text)
                                    {
                                        case "Прямые и тангенциальные":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {

                                                            Khb.Text = "1,04";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {

                                                            Khb.Text = "1,08";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1,13";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {
                                                            Khb.Text = "1,18";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "1,23";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                        case "Круглые":
                                            {
                                                switch (Shirr)
                                                {
                                                    case 0.2:
                                                        {

                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 0.4:
                                                        {
                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 0.6:
                                                        {

                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 0.8:
                                                        {
                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                    case 1:
                                                        {

                                                            Khb.Text = "1";
                                                            break;
                                                        }
                                                }
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Krr = Convert.ToDouble(Kr.Text);
            double sigma = Convert.ToDouble(sigmaHP.Text);
            double uu = Convert.ToDouble(u.Text);
            double T11 = Convert.ToDouble(T1.Text);
            double Kh = Convert.ToDouble(Khb.Text);
            double Kb = Convert.ToDouble(Kbee.Text);

            double Ree;

            double pow = Math.Pow(T11 * Kh / ((1.0 - Kb) * Kb * uu * sigma), 1.0 / 3.0);
            double sqr = Math.Sqrt(uu * uu + 1.0);

            Ree = Krr * sqr * pow;

            Re.Text = Convert.ToString(Ree);

        }
    }
}
