using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruleta
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        int pocetzetonu;
        int aktualnipocetzetonu = 500;
        int vysledekrng = 0;

        private int randomnumbergenerator()
        {
            Random rnd = new Random();
            vysledekrng = rnd.Next(1, 8);
            RNG.Text = vysledekrng.ToString();
            return vysledekrng;
        }

        private void vsazenyzetony_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);
            }
            catch
            {

            }

        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void one_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();

            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 1)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void two_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();
            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 2)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void three_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();

            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 3)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void four_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();

            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 4)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void five_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();

            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 5)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void six_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();

            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 6)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void seven_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();
            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 7)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }
//-----------------------------------------------------------------------------------------------------------------------------------------
        private void eight_Click(object sender, EventArgs e)
        {
            randomnumbergenerator();
            int cislo = randomnumbergenerator();

            try
            {
                pocetzetonu = int.Parse(vsazenyzetony.Text);

                if (aktualnipocetzetonu < pocetzetonu)
                {
                    MessageBox.Show("Tolik Zetonu nemas !!");
                }
                else
                {
                    if (pocetzetonu > 0)
                    {
                        if (cislo == 8)
                        {
                            MessageBox.Show("Vyhrál si !!");
                            int vyhra = pocetzetonu * 3;
                            if (aktualnipocetzetonu > 0)
                            {
                                aktualnipocetzetonu += vyhra;
                            }
                            zetony.Text = aktualnipocetzetonu.ToString();
                        }
                        else
                        {
                            aktualnipocetzetonu -= pocetzetonu;
                            MessageBox.Show("Bohužel , jindy to třeba vyjde");
                            zetony.Text = aktualnipocetzetonu.ToString();
                            if (aktualnipocetzetonu == 0)
                            {
                                MessageBox.Show("Vypadá to že jsi švorc , tak padej domů ");
                                Close();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Zadal jsi špatnou hodnotu");
                    }

                }
            }
            catch
            {
                MessageBox.Show("nezadal jsi zadny zeton");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
