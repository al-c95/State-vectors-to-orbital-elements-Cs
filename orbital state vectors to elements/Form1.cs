using System;
using System.Windows.Forms;

namespace orbital_state_vectors_to_elements
{
    public partial class main_form : Form
    {
        //Newton's gravitational parameter
        static double G = 6.67408e-11;

        //Mass of central body. Earth mass by default.
        double M = 5.97e24;

        //standard gravitational parameter
        double mu;

        //state vectors
        double[] R = { -2337000, 5167000, 3989000 };
        double[] R_dot = { -7144, 2021, -1567 };

        //orbital angular momentum vector h_vec
        double[] h = new double[3];

        //eccentricity vector e_vec
        double[] ecc = new double[3];

        //eccentricity e
        double e_mag;

        //LAN vector
        double[] n = new double[3];

        //True anomaly nu
        double nu;

        //Orbital inclination i
        double inc;

        //Eccentric anomaly E
        double E;

        //Mean anomaly M
        double MA;

        //Longitude of ascending node LAN
        double LAN;

        //argument of periapsis
        double omega;

        //semi-major axis
        double a;

        //period T (sec)
        double T;

        public main_form()
        {
            InitializeComponent();

            //radio buttons initially checked
            radioButton_metres.Checked = true;
            radioButton_metresPerSecond.Checked = true;
            radioButton_T_sec.Checked = true;

            //output data text boxes are read-only
            textBox_e.ReadOnly = true;
            textBox_T.ReadOnly = true;
            textBox_omega.ReadOnly = true;
            textBox_nu.ReadOnly = true;
            textBox_MA.ReadOnly = true;
            textBox_LAN.ReadOnly = true;
            textBox_a.ReadOnly = true;
            textBox_EA.ReadOnly = true;
            textBox_i.ReadOnly = true;
        }

        //Event handlers
        //Click clear button
        private void button_Clear_Click(object sender, EventArgs e)
        {
            //clear values in output text boxes
            textBox_e.Text = null;
            textBox_T.Text = null;
            textBox_omega.Text = null;
            textBox_nu.Text = null;
            textBox_MA.Text = null;
            textBox_LAN.Text = null;
            textBox_a.Text = null;
            textBox_EA.Text = null;
            textBox_i.Text = null;
        }
        //Click calculate button
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            //calculate output values and display them
            try
            {
                mu = G * M;

                R[0] = double.Parse(textBox_Rx.Text);
                R[1] = double.Parse(textBox_Ry.Text);
                R[2] = double.Parse(textBox_Rz.Text);

                R_dot[0] = double.Parse(textBox_Vx.Text);
                R_dot[1] = double.Parse(textBox_Vy.Text);
                R_dot[2] = double.Parse(textBox_Vz.Text);

                //calculate h_vec
                crossProduct3(R, R_dot, h);

                //calculate R_dotxh vector
                double[] R_dotCrossh = new double[3];
                crossProduct3(R_dot, h, R_dotCrossh);
                for (int i = 0; i < 3; i++)
                {
                    R_dotCrossh[i] = R_dotCrossh[i] / mu;
                }

                //Calculate magnitude of position vector R_mag
                double R_mag = vecMag3(R);

                //calculate eccentricity vector
                ecc[0] = R_dotCrossh[0] - (R[0] / R_mag);
                ecc[1] = R_dotCrossh[1] - (R[1] / R_mag);
                ecc[2] = R_dotCrossh[2] - (R[2] / R_mag);

                //calculate eccentricity e
                e_mag = vecMag3(ecc);

                //calculate LAN vector
                n[0] = -h[1];
                n[1] = h[0];
                n[2] = 0;

                //calculate true anomaly nu (degrees)
                if (dotProduct3(R, R_dot) >= 0)
                {
                    nu = (180 / Math.PI) * Math.Acos(dotProduct3(ecc, R) / (e_mag * R_mag));
                }
                else
                {
                    nu = (180 / Math.PI) * (2 * (Math.PI) - Math.Acos(dotProduct3(ecc, R) / (e_mag * R_mag)));
                }

                //calculate orbital inclination i
                inc = (180 / Math.PI) * Math.Acos(h[2] / vecMag3(h));

                //problem
                //calculate eccentric anomaly E
                E = Math.Atan((Math.Sqrt(1 - e_mag * e_mag) * Math.Sin(nu * (Math.PI) / 180)) / (e_mag + Math.Cos(nu * (Math.PI) / 180)));
                //calculate mean anomaly M
                MA = (180 / Math.PI) * (E - e_mag * Math.Sin(E));

                //calculate longitude of ascending node LAN
                if (n[1] >= 0)
                {
                    LAN = (180 / Math.PI) * Math.Acos(n[0] / vecMag3(n));
                }
                else
                {
                    LAN = (180 / Math.PI) * 2 * Math.PI - Math.Acos(n[0] / vecMag3(n));
                }

                //calculate argument of periapsis omega
                if (ecc[2] >= 0)
                {
                    omega = (180 / Math.PI) * Math.Acos(dotProduct3(n, ecc) / (vecMag3(n) * e_mag));
                }
                else
                {
                    omega = (180 / Math.PI) * (2 * Math.PI - Math.Acos(dotProduct3(n, ecc) / (vecMag3(n) * e_mag)));
                }

                //calculate semi-major axis
                a = 1 / (2 / R_mag - (vecMag3(R_dot) * (vecMag3(R_dot) / mu)));

                //calculate period T (sec)
                T = Math.Sqrt(4 * (Math.PI) * (Math.PI) * a * a * a / (G * M));

                textBox_a.Text = a.ToString();
                textBox_e.Text = e_mag.ToString();
                textBox_EA.Text = E.ToString();
                textBox_i.Text = inc.ToString();
                textBox_LAN.Text = LAN.ToString();
                textBox_MA.Text = MA.ToString();
                textBox_nu.Text = nu.ToString();
                textBox_omega.Text = omega.ToString();
                textBox_T.Text = T.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error. Please enter valid data.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void radioButton_T_min_CheckedChanged(object sender, EventArgs e)
        {

        }
        //List box selection (central body) changed
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String central = listBox1.SelectedItem.ToString();

            switch (central)
            {
                case "Earth":
                    M = 5.97e24;
                    break;
                case "Moon":
                    M = 7.342e22;
                    break;
                case "Sun":
                    M = 1.989e30;
                    break;
                case "Mars":
                    M = 6.39e23;
                    break;
                case "Phobos":
                    M = 1.0659e16;
                    break;
                case "Deimos":
                    M = 1.4762e15;
                    break;
                case "Jupiter":
                    M = 1.8982e27;
                    break;
                case "Saturn":
                    M = 5.683e26;
                    break;
                case "Uranus":
                    M = 8.681e25;
                    break;
                case "Neptune":
                    M = 1.024e26;
                    break;
                case "Pluto":
                    M = 1.309e22;
                    break;
                case "Sedna":
                    M = 1.7e21;
                    break;
                case "Eris":
                    M = 1.66e22;
                    break;
                case "Alpha Centauri":
                    M = 2.446e29;
                    break;
                case "Sirius":
                    M = 2.02 * 1.989e30;
                    break;
                case "Betelgeuse":
                    M = 1.531e31;
                    break;
                case "Rigel":
                    M = 3.58e31;
                    break;
                default:
                    M = 5.97e24;
                    break;
            }

            //debugging
            //MessageBox.Show(M.ToString());
        }
        //Magnitude of a vector
        public static double vecMag3(double[] vec)
        {
            double result;
            result = Math.Sqrt(vec[0] * vec[0] + vec[1] * vec[1] + vec[2] * vec[2]);
            return result;
        }
        //Dot product of two vectors with three elements each
        public static double dotProduct3(double[] a, double[] b)
        {
            double result;
            result = a[0] * b[0] + a[1] * b[1] + a[2] * b[2];
            return result;
        }
        //Cross product of two vectors with three elements each
        public static void crossProduct3(double[] a, double[] b, double[] cross_product)
        {
            cross_product[0] = a[1] * b[2] - a[2] * b[1];
            cross_product[1] = -(a[0] * b[2] - a[2] * b[0]);
            cross_product[2] = a[0] * b[1] - a[1] * b[0];
        }
    }
}
