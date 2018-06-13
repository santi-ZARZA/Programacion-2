using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeEventos_clase23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.txtbilletes2.Enabled = false;
            //this.txtbilletes5.Enabled = false;
            //this.txtbilletes10.Enabled = false;
            //this.txtbilletes20.Enabled = false;
            //this.txtbilletes50.Enabled = false;
            //this.txtbilletes100.Enabled = false;

            foreach (Control itemA in this.groupBox2.Controls)
            {
                if (itemA is TextBox)
                {
                    itemA.Enabled = false;
                    itemA.BackColor = Color.White;
                    itemA.Text = "0";
                }
            }
        }

        #region Metodos

        private void Calcular(object sender, EventArgs e)
        {
            int[] cantidades = new int[6];// [0]= 2,[1]= 5,[2]= 10,[3]= 20,[4]= 50,[5]= 100,
            string Extrae = this.txtRetirar.Text;
            double aux = 0;
            double.TryParse(Extrae, out aux);


            if (aux > 0)
            {

                while (aux >= 2)
                {
                    if (aux >= 100)
                    {
                        aux -= 100;
                        cantidades[5]++;
                    }
                    else if (aux >= 50)
                    {
                        aux -= 50;
                        cantidades[4]++;
                    }
                    else if (aux >= 20)
                    {
                        aux -= 20;
                        cantidades[3]++;
                    }
                    else if (aux >= 10)
                    {
                        aux -= 10;
                        cantidades[2]++;
                    }
                    else if (aux >= 5)
                    {
                        aux -= 5;
                        cantidades[1]++;
                    }
                    else if (aux >= 2)
                    {
                        aux -= 2;
                        cantidades[0]++;
                    }
                }

            }

            this.txtbilletes2.Text = cantidades[0].ToString();
            this.txtbilletes5.Text = cantidades[1].ToString();
            this.txtbilletes10.Text = cantidades[2].ToString();
            this.txtbilletes20.Text = cantidades[3].ToString();
            this.txtbilletes50.Text = cantidades[4].ToString();
            this.txtbilletes100.Text = cantidades[5].ToString();

            if (aux < 2 && aux > 0)
            {
                MessageBox.Show("le queda $ "+aux);
            }
        }

        private void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpiar la pantalla para seguir operando.");
            this.btnAceptar.Click -= new EventHandler(Informar);

        }

        private void Limpiar(object sender, EventArgs e)
        {
            foreach (Control item in this.groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "0";
                }
            }
            this.txtRetirar.Text = "";
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAceptar.Click += new EventHandler(Calcular);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Click -= new EventHandler(Calcular);
            this.btnLimpiar.Click += new EventHandler(Limpiar);
            this.btnAceptar.Click += new EventHandler(Informar);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Click -= new EventHandler(Informar);
            this.btnAceptar.Click += new EventHandler(Calcular);
            this.btnLimpiar.Click -= new EventHandler(Limpiar);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
