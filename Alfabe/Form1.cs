using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string harf;

            harf = comboBox1.Text;

            switch (harf)
            {

                case "A":
                    {
                        label1.Text = "A harfi 1. sıradadır.";
                        break;
                    }

                case "B":
                    {
                        label1.Text = "B harfi 2. sıradadır.";
                        break;
                    }
                case "C":
                    {
                        label1.Text = "C harfi 3. sıradadır.";
                        break;
                    }
                case "Ç":
                    {
                        label1.Text = "Ç harfi 4. sıradadır.";
                        break;
                    }
                case "D":
                    {
                        label1.Text = "D harfi 5. sıradadır.";
                        break;
                    }
                case "E":
                    {
                        label1.Text = "E harfi 6. sıradadır.";
                        break;
                    }
                case "F":
                    {
                        label1.Text = "F harfi 7. sıradadır.";
                        break;
                    }
                case "G":
                    {
                        label1.Text = "G harfi 8. sıradadır.";
                        break;
                    }

                case "Ğ":
                    {
                        label1.Text = "Ğ harfi 9. sıradadır.";
                        break;
                    }
                case "H":
                    {
                        label1.Text = "H harfi 10. sıradadır.";
                        break;
                    }
                case "I":
                    {
                        label1.Text = "I harfi 11. sıradadır.";
                        break;
                    }
                case "İ":
                    {
                        label1.Text = "İ harfi 12. sıradadır.";
                        break;
                    }
                case "J":
                    {
                        label1.Text = "J harfi 13. sıradadır.";
                        break;
                    }
                case "K":
                    {
                        label1.Text = "K harfi 14. sıradadır.";
                        break;
                    }
                case "L":
                    {
                        label1.Text = "L harfi 15. sıradadır.";
                        break;
                    }
                case "M":
                    {
                        label1.Text = "M harfi 16. sıradadır.";
                        break;
                    }
                case "N":
                    {
                        label1.Text = "N harfi 17. sıradadır.";
                        break;
                    }

                case "O":
                    {
                        label1.Text = "O harfi 18. sıradadır.";
                        break;
                    }
                case "Ö":
                    {
                        label1.Text = "Ö harfi 19. sıradadır.";
                        break;
                    }
                case "P":
                    {
                        label1.Text = "P harfi 20. sıradadır.";
                        break;
                    }
                case "R":
                    {
                        label1.Text = "R harfi 21. sıradadır.";
                        break;
                    }
                case "S":
                    {
                        label1.Text = "S harfi 22. sıradadır.";
                        break;
                    }

                case "Ş":
                    {
                        label1.Text = "Ş harfi 23. sıradadır.";
                        break;
                    }
                case "T":
                    {
                        label1.Text = "T harfi 24. sıradadır.";
                        break;
                    }
                case "U":
                    {
                        label1.Text = "U harfi 25. sıradadır.";
                        break;
                    }
                case "Ü":
                    {
                        label1.Text = "Ü harfi 26. sıradadır.";
                        break;
                    }

                case "V":
                    {
                        label1.Text = "V harfi 27. sıradadır.";
                        break;
                    }
                case "Y":
                    {
                        label1.Text = "Y harfi 28. sıradadır.";
                        break;
                    }

                case "Z":
                    {
                        label1.Text = "Z harfi 29. sıradadır.";
                        break;
                    }
                default:
                    {
                        label1.Text = "Geçersiz harf";
                        break;
                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string harf;

            harf = comboBox1.Text;

            switch (harf)
            {
                case "a":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "e":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "ı":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "i":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "u":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "ü":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "o":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "ö":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }

                case "A":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "E":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "I":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "İ":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "U":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "Ü":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "O":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                case "Ö":
                    {
                        MessageBox.Show("Sesli harf");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Sessiz harf");
                        break;
                    }
            }
        }
    }
}
