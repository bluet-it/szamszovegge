using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace számszöveggé
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int egesz;
        private static int tizedesjegy;
        private static int osztando;
        private static int oszto;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                domainUpDown1.Enabled = true;
            }
            else
            {
                domainUpDown1.Enabled = false;
            }
            regenerate();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            regenerate();
            if (domainUpDown1.SelectedIndex == 0)
            {
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else if (domainUpDown1.SelectedIndex == 1)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
            }else if (domainUpDown1.SelectedIndex == 2)
            {
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            regenerate();
        }
        void regenerate() {
            label1.Text = "";
            if (radioButton2.Checked)
            {
                egesz = new Random().Next(int.Parse(numericUpDown2.Value.ToString()),int.Parse(numericUpDown3.Value.ToString()));
                textBox2.Text = egesz.ToString();
                if (egesz.ToString().ToCharArray().Length==1)
                {
                    switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                    {
                        case 0:
                            label1.Text = "nulla";
                            break;
                        case 1:
                            label1.Text = "egy";
                            break;
                        case 2:
                            label1.Text = "kettő";
                            break;
                        case 3:
                            label1.Text = "három";
                            break;
                        case 4:
                            label1.Text = "négy";
                            break;
                        case 5:
                            label1.Text = "öt";
                            break;
                        case 6:
                            label1.Text = "hat";
                            break;
                        case 7:
                            label1.Text = "hét";
                            break;
                        case 8:
                            label1.Text = "nyolc";
                            break;
                        case 9:
                            label1.Text = "kilenc";
                            break;
                        default:
                            break;
                    }
                    
                }
                else if (egesz > 10 && egesz < 100 && egesz != 20)
                {
                    switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                    {
                        case 1:
                            label1.Text = "tizen";
                            break;
                        case 2:
                            label1.Text = "huszon";
                            break;
                        case 3:
                            label1.Text = "harminc";
                            break;
                        case 4:
                            label1.Text = "negyven";
                            break;
                        case 5:
                            label1.Text = "ötven";
                            break;
                        case 6:
                            label1.Text = "hatvan";
                            break;
                        case 7:
                            label1.Text = "hetven";
                            break;
                        case 8:
                            label1.Text = "nyolcvan";
                            break;
                        case 9:
                            label1.Text = "kilencven";
                            break;
                        default:
                            break;
                    }
                    switch (Convert.ToInt32(egesz.ToString().ToCharArray()[1].ToString()))
                    {
                        case 0:
                            label1.Text = label1.Text + "";
                            break;
                        case 1:
                            label1.Text = label1.Text + "egy";
                            break;
                        case 2:
                            label1.Text = label1.Text + "kettő";
                            break;
                        case 3:
                            label1.Text = label1.Text + "három";
                            break;
                        case 4:
                            label1.Text = label1.Text + "négy";
                            break;
                        case 5:
                            label1.Text = label1.Text + "öt";
                            break;
                        case 6:
                            label1.Text = label1.Text + "hat";
                            break;
                        case 7:
                            label1.Text = label1.Text + "hét";
                            break;
                        case 8:
                            label1.Text = label1.Text + "nyolc";
                            break;
                        case 9:
                            label1.Text = label1.Text + "kilenc";
                            break;
                        default:
                            break;
                    }
                }
                else if (egesz == 10)
                {
                    label1.Text = "tíz";
                }
                else if (egesz == 20)
                {
                    label1.Text = "húsz";
                }
                else if (egesz == 100)
                {
                    label1.Text = "száz";
                }
            }
            else if (radioButton1.Checked)
            {
                if (domainUpDown1.SelectedIndex == 0)
                {
                    egesz = new Random(new Random().Next(100)).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                    tizedesjegy = new Random(new Random().Next(100) + 1).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                    textBox2.Text = egesz.ToString()+","+tizedesjegy.ToString();
                    if (egesz.ToString().ToCharArray().Length == 1)
                    {
                        switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                        {
                            case 0:
                                label1.Text = "nulla";
                                break;
                            case 1:
                                label1.Text = "egy";
                                break;
                            case 2:
                                label1.Text = "kettő";
                                break;
                            case 3:
                                label1.Text = "három";
                                break;
                            case 4:
                                label1.Text = "négy";
                                break;
                            case 5:
                                label1.Text = "öt";
                                break;
                            case 6:
                                label1.Text = "hat";
                                break;
                            case 7:
                                label1.Text = "hét";
                                break;
                            case 8:
                                label1.Text = "nyolc";
                                break;
                            case 9:
                                label1.Text = "kilenc";
                                break;
                            default:
                                break;
                        }

                    }
                    else if (egesz > 10 && egesz < 100 && egesz != 20)
                    {
                        switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                        {
                            case 1:
                                label1.Text = "tizen";
                                break;
                            case 2:
                                label1.Text = "huszon";
                                break;
                            case 3:
                                label1.Text = "harminc";
                                break;
                            case 4:
                                label1.Text = "negyven";
                                break;
                            case 5:
                                label1.Text = "ötven";
                                break;
                            case 6:
                                label1.Text = "hatvan";
                                break;
                            case 7:
                                label1.Text = "hetven";
                                break;
                            case 8:
                                label1.Text = "nyolcvan";
                                break;
                            case 9:
                                label1.Text = "kilencven";
                                break;
                            default:
                                break;
                        }
                        switch (Convert.ToInt32(egesz.ToString().ToCharArray()[1].ToString()))
                        {
                            case 0:
                                label1.Text = label1.Text + "";
                                break;
                            case 1:
                                label1.Text = label1.Text + "egy";
                                break;
                            case 2:
                                label1.Text = label1.Text + "kettő";
                                break;
                            case 3:
                                label1.Text = label1.Text + "három";
                                break;
                            case 4:
                                label1.Text = label1.Text + "négy";
                                break;
                            case 5:
                                label1.Text = label1.Text + "öt";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hat";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hét";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolc";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilenc";
                                break;
                            default:
                                break;
                        }
                    }
                    else if (egesz == 10)
                    {
                        label1.Text = "tíz";
                    }
                    else if (egesz == 20)
                    {
                        label1.Text = "húsz";
                    }
                    else if (egesz == 100)
                    {
                        label1.Text = "száz";
                    }
                label1.Text = label1.Text + " egész ";
                    if (tizedesjegy.ToString().ToCharArray().Length == 1)
                    {
                        switch (Convert.ToInt32(tizedesjegy.ToString().ToCharArray()[0].ToString()))
                        {
                            case 0:
                                label1.Text = "nulla";
                                break;
                            case 1:
                                label1.Text = "egy";
                                break;
                            case 2:
                                label1.Text = "kettő";
                                break;
                            case 3:
                                label1.Text = "három";
                                break;
                            case 4:
                                label1.Text = "négy";
                                break;
                            case 5:
                                label1.Text = "öt";
                                break;
                            case 6:
                                label1.Text = "hat";
                                break;
                            case 7:
                                label1.Text = "hét";
                                break;
                            case 8:
                                label1.Text = "nyolc";
                                break;
                            case 9:
                                label1.Text = "kilenc";
                                break;
                            default:
                                break;
                        }

                    }
                    else if (tizedesjegy > 10 && tizedesjegy < 100 && tizedesjegy != 20)
                    {
                        switch (Convert.ToInt32(tizedesjegy.ToString().ToCharArray()[0].ToString()))
                        {
                            case 1:
                                label1.Text = label1.Text + "tizen";
                                break;
                            case 2:
                                label1.Text = label1.Text + "huszon";
                                break;
                            case 3:
                                label1.Text = label1.Text + "harminc";
                                break;
                            case 4:
                                label1.Text = label1.Text + "negyven";
                                break;
                            case 5:
                                label1.Text = label1.Text + "ötven";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hatvan";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hetven";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolcvan";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilencven";
                                break;
                            default:
                                break;
                        }
                        switch (Convert.ToInt32(tizedesjegy.ToString().ToCharArray()[1].ToString()))
                        {
                            case 0:
                                label1.Text = label1.Text + "";
                                break;
                            case 1:
                                label1.Text = label1.Text + "egy";
                                break;
                            case 2:
                                label1.Text = label1.Text + "kettő";
                                break;
                            case 3:
                                label1.Text = label1.Text + "három";
                                break;
                            case 4:
                                label1.Text = label1.Text + "négy";
                                break;
                            case 5:
                                label1.Text = label1.Text + "öt";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hat";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hét";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolc";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilenc";
                                break;
                            default:
                                break;
                        }
                    }
                    else if (tizedesjegy == 10)
                    {
                        label1.Text = "tíz";
                    }
                    else if (tizedesjegy == 20)
                    {
                        label1.Text = "húsz";
                    }
                    else if (tizedesjegy == 100)
                    {
                        label1.Text = "száz";
                    }

                }
                else if (domainUpDown1.SelectedIndex == 1)
                {
                    egesz = new Random(new Random().Next(100)).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                    osztando = new Random(new Random().Next(100) + 1).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                    oszto = new Random(new Random().Next(100) + 2).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                    textBox2.Text = egesz.ToString();
                    textBox3.Text = osztando.ToString();
                    textBox4.Text = oszto.ToString();
                    if (egesz.ToString().ToCharArray().Length == 1)
                    {
                        switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                        {
                            case 0:
                                label1.Text = "nulla";
                                break;
                            case 1:
                                label1.Text = "egy";
                                break;
                            case 2:
                                label1.Text = "kettő";
                                break;
                            case 3:
                                label1.Text = "három";
                                break;
                            case 4:
                                label1.Text = "négy";
                                break;
                            case 5:
                                label1.Text = "öt";
                                break;
                            case 6:
                                label1.Text = "hat";
                                break;
                            case 7:
                                label1.Text = "hét";
                                break;
                            case 8:
                                label1.Text = "nyolc";
                                break;
                            case 9:
                                label1.Text = "kilenc";
                                break;
                            default:
                                break;
                        }

                    }
                    else if (egesz > 10 && egesz < 100 && egesz != 20)
                    {
                        switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                        {
                            case 1:
                                label1.Text = "tizen";
                                break;
                            case 2:
                                label1.Text = "huszon";
                                break;
                            case 3:
                                label1.Text = "harminc";
                                break;
                            case 4:
                                label1.Text = "negyven";
                                break;
                            case 5:
                                label1.Text = "ötven";
                                break;
                            case 6:
                                label1.Text = "hatvan";
                                break;
                            case 7:
                                label1.Text = "hetven";
                                break;
                            case 8:
                                label1.Text = "nyolcvan";
                                break;
                            case 9:
                                label1.Text = "kilencven";
                                break;
                            default:
                                break;
                        }
                        switch (Convert.ToInt32(egesz.ToString().ToCharArray()[1].ToString()))
                        {
                            case 0:
                                label1.Text = label1.Text + "";
                                break;
                            case 1:
                                label1.Text = label1.Text + "egy";
                                break;
                            case 2:
                                label1.Text = label1.Text + "kettő";
                                break;
                            case 3:
                                label1.Text = label1.Text + "három";
                                break;
                            case 4:
                                label1.Text = label1.Text + "négy";
                                break;
                            case 5:
                                label1.Text = label1.Text + "öt";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hat";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hét";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolc";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilenc";
                                break;
                            default:
                                break;
                        }
                    }
                    else if (egesz == 10)
                    {
                        label1.Text = "tíz";
                    }
                    else if (egesz == 20)
                    {
                        label1.Text = "húsz";
                    }
                    else if (egesz == 100)
                    {
                        label1.Text = "száz";
                    }
                    label1.Text = label1.Text + " egész ";
                    if (osztando.ToString().ToCharArray().Length == 1)
                    {
                        switch (Convert.ToInt32(osztando.ToString().ToCharArray()[0].ToString()))
                        {
                            case 0:
                                label1.Text = "nulla";
                                break;
                            case 1:
                                label1.Text = "egy";
                                break;
                            case 2:
                                label1.Text = "kettő";
                                break;
                            case 3:
                                label1.Text = "három";
                                break;
                            case 4:
                                label1.Text = "négy";
                                break;
                            case 5:
                                label1.Text = "öt";
                                break;
                            case 6:
                                label1.Text = "hat";
                                break;
                            case 7:
                                label1.Text = "hét";
                                break;
                            case 8:
                                label1.Text = "nyolc";
                                break;
                            case 9:
                                label1.Text = "kilenc";
                                break;
                            default:
                                break;
                        }

                    }
                    else if (osztando > 10 && osztando < 100 && osztando != 20)
                    {
                        switch (Convert.ToInt32(osztando.ToString().ToCharArray()[0].ToString()))
                        {
                            case 1:
                                label1.Text = label1.Text + "tizen";
                                break;
                            case 2:
                                label1.Text = label1.Text + "huszon";
                                break;
                            case 3:
                                label1.Text = label1.Text + "harminc";
                                break;
                            case 4:
                                label1.Text = label1.Text + "negyven";
                                break;
                            case 5:
                                label1.Text = label1.Text + "ötven";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hatvan";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hetven";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolcvan";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilencven";
                                break;
                            default:
                                break;
                        }
                        switch (Convert.ToInt32(osztando.ToString().ToCharArray()[1].ToString()))
                        {
                            case 0:
                                label1.Text = label1.Text + "";
                                break;
                            case 1:
                                label1.Text = label1.Text + "egy";
                                break;
                            case 2:
                                label1.Text = label1.Text + "kettő";
                                break;
                            case 3:
                                label1.Text = label1.Text + "három";
                                break;
                            case 4:
                                label1.Text = label1.Text + "négy";
                                break;
                            case 5:
                                label1.Text = label1.Text + "öt";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hat";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hét";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolc";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilenc";
                                break;
                            default:
                                break;
                        }
                    }
                    else if (osztando == 10)
                    {
                        label1.Text = "tíz";
                    }
                    else if (osztando == 20)
                    {
                        label1.Text = "húsz";
                    }
                    else if (osztando == 100)
                    {
                        label1.Text = "száz";
                    }
                    label1.Text = label1.Text + " ";
                    if (oszto.ToString().ToCharArray().Length == 1)
                    {
                        switch (Convert.ToInt32(oszto.ToString().ToCharArray()[0].ToString()))
                        {
                            case 0:
                                label1.Text = "nulláad";
                                break;
                            case 1:
                                label1.Text = "egyed";
                                break;
                            case 2:
                                label1.Text = "ketted";
                                break;
                            case 3:
                                label1.Text = "harmad";
                                break;
                            case 4:
                                label1.Text = "negyed";
                                break;
                            case 5:
                                label1.Text = "ötöd";
                                break;
                            case 6:
                                label1.Text = "hatod";
                                break;
                            case 7:
                                label1.Text = "heted";
                                break;
                            case 8:
                                label1.Text = "nyolcad";
                                break;
                            case 9:
                                label1.Text = "kilenced";
                                break;
                            default:
                                break;
                        }

                    }
                    else if (oszto > 10 && oszto < 100 && oszto != 20)
                    {
                        switch (Convert.ToInt32(oszto.ToString().ToCharArray()[0].ToString()))
                        {
                            case 1:
                                label1.Text = label1.Text + "tizen";
                                break;
                            case 2:
                                label1.Text = label1.Text + "huszon";
                                break;
                            case 3:
                                label1.Text = label1.Text + "harminc";
                                break;
                            case 4:
                                label1.Text = label1.Text + "negyven";
                                break;
                            case 5:
                                label1.Text = label1.Text + "ötven";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hatvan";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hetven";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolcvan";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilencven";
                                break;
                            default:
                                break;
                        }
                        switch (Convert.ToInt32(oszto.ToString().ToCharArray()[1].ToString()))
                        {
                            case 0:
                                label1.Text = label1.Text + "";
                                break;
                            case 1:
                                label1.Text = label1.Text + "egyed";
                                break;
                            case 2:
                                label1.Text = label1.Text + "ketted";
                                break;
                            case 3:
                                label1.Text = label1.Text + "harmad";
                                break;
                            case 4:
                                label1.Text = label1.Text + "negyed";
                                break;
                            case 5:
                                label1.Text = label1.Text + "ötöd";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hatod";
                                break;
                            case 7:
                                label1.Text = label1.Text + "heted";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolcad";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilenced";
                                break;
                            default:
                                break;
                        }
                    }
                    else if (oszto == 10)
                    {
                        label1.Text = "tíz";
                    }
                    else if (oszto == 20)
                    {
                        label1.Text = "húsz";
                    }
                    else if (oszto == 100)
                    {
                        label1.Text = "száz";
                    }

                }
                else if (domainUpDown1.SelectedIndex == 2)
                {
                    osztando = new Random(new Random().Next(100)).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                    oszto = new Random(new Random().Next(100)+1).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                    textBox3.Text = osztando.ToString();
                    textBox4.Text = oszto.ToString();
                    if (osztando.ToString().ToCharArray().Length == 1)
                    {
                        switch (Convert.ToInt32(osztando.ToString().ToCharArray()[0].ToString()))
                        {
                            case 0:
                                label1.Text = "nulla";
                                break;
                            case 1:
                                label1.Text = "egy";
                                break;
                            case 2:
                                label1.Text = "kettő";
                                break;
                            case 3:
                                label1.Text = "három";
                                break;
                            case 4:
                                label1.Text = "négy";
                                break;
                            case 5:
                                label1.Text = "öt";
                                break;
                            case 6:
                                label1.Text = "hat";
                                break;
                            case 7:
                                label1.Text = "hét";
                                break;
                            case 8:
                                label1.Text = "nyolc";
                                break;
                            case 9:
                                label1.Text = "kilenc";
                                break;
                            default:
                                break;
                        }

                    }
                    else if (osztando > 10 && osztando < 100 && osztando != 20)
                    {
                        switch (Convert.ToInt32(osztando.ToString().ToCharArray()[0].ToString()))
                        {
                            case 1:
                                label1.Text = label1.Text + "tizen";
                                break;
                            case 2:
                                label1.Text = label1.Text + "huszon";
                                break;
                            case 3:
                                label1.Text = label1.Text + "harminc";
                                break;
                            case 4:
                                label1.Text = label1.Text + "negyven";
                                break;
                            case 5:
                                label1.Text = label1.Text + "ötven";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hatvan";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hetven";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolcvan";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilencven";
                                break;
                            default:
                                break;
                        }
                        switch (Convert.ToInt32(osztando.ToString().ToCharArray()[1].ToString()))
                        {
                            case 0:
                                label1.Text = label1.Text + "";
                                break;
                            case 1:
                                label1.Text = label1.Text + "egy";
                                break;
                            case 2:
                                label1.Text = label1.Text + "kettő";
                                break;
                            case 3:
                                label1.Text = label1.Text + "három";
                                break;
                            case 4:
                                label1.Text = label1.Text + "négy";
                                break;
                            case 5:
                                label1.Text = label1.Text + "öt";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hat";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hét";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolc";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilenc";
                                break;
                            default:
                                break;
                        }
                    }
                    else if (osztando == 10)
                    {
                        label1.Text = "tíz";
                    }
                    else if (osztando == 20)
                    {
                        label1.Text = "húsz";
                    }
                    else if (osztando == 100)
                    {
                        label1.Text = "száz";
                    }
                    label1.Text = label1.Text + " ";
                    if (oszto.ToString().ToCharArray().Length == 1)
                    {
                        switch (Convert.ToInt32(oszto.ToString().ToCharArray()[0].ToString()))
                        {
                            case 0:
                                label1.Text = "nullaáad";
                                break;
                            case 1:
                                label1.Text = "egyed";
                                break;
                            case 2:
                                label1.Text = "ketted";
                                break;
                            case 3:
                                label1.Text = "harmad";
                                break;
                            case 4:
                                label1.Text = "negyed";
                                break;
                            case 5:
                                label1.Text = "ötöd";
                                break;
                            case 6:
                                label1.Text = "hatod";
                                break;
                            case 7:
                                label1.Text = "heted";
                                break;
                            case 8:
                                label1.Text = "nyolcad";
                                break;
                            case 9:
                                label1.Text = "kilenced";
                                break;
                            default:
                                break;
                        }

                    }
                    else if (oszto > 10 && oszto < 100 && oszto != 20)
                    {
                        switch (Convert.ToInt32(oszto.ToString().ToCharArray()[0].ToString()))
                        {
                            case 1:
                                label1.Text = label1.Text + "tizen";
                                break;
                            case 2:
                                label1.Text = label1.Text + "huszon";
                                break;
                            case 3:
                                label1.Text = label1.Text + "harminc";
                                break;
                            case 4:
                                label1.Text = label1.Text + "negyven";
                                break;
                            case 5:
                                label1.Text = label1.Text + "ötven";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hatvan";
                                break;
                            case 7:
                                label1.Text = label1.Text + "hetven";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolcvan";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilencven";
                                break;
                            default:
                                break;
                        }
                        switch (Convert.ToInt32(oszto.ToString().ToCharArray()[1].ToString()))
                        {
                            case 0:
                                label1.Text = label1.Text + "";
                                break;
                            case 1:
                                label1.Text = label1.Text + "egyed";
                                break;
                            case 2:
                                label1.Text = label1.Text + "ketted";
                                break;
                            case 3:
                                label1.Text = label1.Text + "harmad";
                                break;
                            case 4:
                                label1.Text = label1.Text + "negyed";
                                break;
                            case 5:
                                label1.Text = label1.Text + "ötöd";
                                break;
                            case 6:
                                label1.Text = label1.Text + "hatod";
                                break;
                            case 7:
                                label1.Text = label1.Text + "heted";
                                break;
                            case 8:
                                label1.Text = label1.Text + "nyolcad";
                                break;
                            case 9:
                                label1.Text = label1.Text + "kilenced";
                                break;
                            default:
                                break;
                        }
                    }
                    else if (oszto == 10)
                    {
                        label1.Text = "tized";
                    }
                    else if (oszto == 20)
                    {
                        label1.Text = "huszad";
                    }
                    else if (oszto == 100)
                    {
                        label1.Text = "század";
                    }

                }
            }
            else
            {
                egesz = new Random(new Random().Next(10)).Next(int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
                textBox2.Text =egesz.ToString();
                if (egesz.ToString().ToCharArray().Length == 1)
                {
                    switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                    {
                        case 0:
                            label1.Text = "nulla";
                            break;
                        case 1:
                            label1.Text = "egy";
                            break;
                        case 2:
                            label1.Text = "kettő";
                            break;
                        case 3:
                            label1.Text = "három";
                            break;
                        case 4:
                            label1.Text = "négy";
                            break;
                        case 5:
                            label1.Text = "öt";
                            break;
                        case 6:
                            label1.Text = "hat";
                            break;
                        case 7:
                            label1.Text = "hét";
                            break;
                        case 8:
                            label1.Text = "nyolc";
                            break;
                        case 9:
                            label1.Text = "kilenc";
                            break;
                        default:
                            break;
                    }

                }
                else if (egesz > 10 && egesz < 100 && egesz != 20)
                {
                    switch (Convert.ToInt32(egesz.ToString().ToCharArray()[0].ToString()))
                    {
                        case 1:
                            label1.Text = "tizen";
                            break;
                        case 2:
                            label1.Text = "huszon";
                            break;
                        case 3:
                            label1.Text = "harminc";
                            break;
                        case 4:
                            label1.Text = "negyven";
                            break;
                        case 5:
                            label1.Text = "ötven";
                            break;
                        case 6:
                            label1.Text = "hatvan";
                            break;
                        case 7:
                            label1.Text = "hetven";
                            break;
                        case 8:
                            label1.Text = "nyolcvan";
                            break;
                        case 9:
                            label1.Text = "kilencven";
                            break;
                        default:
                            break;
                    }
                    switch (Convert.ToInt32(egesz.ToString().ToCharArray()[1].ToString()))
                    {
                        case 0:
                            label1.Text = label1.Text + "";
                            break;
                        case 1:
                            label1.Text = label1.Text + "egy";
                            break;
                        case 2:
                            label1.Text = label1.Text + "kettő";
                            break;
                        case 3:
                            label1.Text = label1.Text + "három";
                            break;
                        case 4:
                            label1.Text = label1.Text + "négy";
                            break;
                        case 5:
                            label1.Text = label1.Text + "öt";
                            break;
                        case 6:
                            label1.Text = label1.Text + "hat";
                            break;
                        case 7:
                            label1.Text = label1.Text + "hét";
                            break;
                        case 8:
                            label1.Text = label1.Text + "nyolc";
                            break;
                        case 9:
                            label1.Text = label1.Text + "kilenc";
                            break;
                        default:
                            break;
                    }
                }
                else if (egesz == 10)
                {
                    label1.Text = "tíz";
                }
                else if (egesz == 20)
                {
                    label1.Text = "húsz";
                }
                else if (egesz == 100)
                {
                    label1.Text = "száz";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) => regenerate();

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            regenerate();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            regenerate();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            regenerate();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            regenerate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            regenerate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
