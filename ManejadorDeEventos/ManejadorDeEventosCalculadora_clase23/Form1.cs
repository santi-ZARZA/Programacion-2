using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeEventosCalculadora_clase23
{
    public partial class Form1 : Form
    {
        private Double primerNumero;
        private Double segundoNumero;
        private string operador;


        public Form1()
        {
            InitializeComponent();
            this.primerNumero = -1;
            this.segundoNumero = -1;
            this.operador = null;
        }

        public void ManejadorCentral(object sender, EventArgs e)
        {
            Button auxiliar = (Button)sender;

            if(this.groupBox1.Controls.Contains(auxiliar))
            {
                this.AgregaEvento(this.groupBox1);

                switch (auxiliar.Name)
                {
                    case "btn0":
                        this.TxtResultado.Text = "0";
                        break;
                    case "btn1":
                        this.TxtResultado.Text = "1";
                        break;
                    case "btn2":
                        this.TxtResultado.Text = "2";
                        break;
                    case "btn3":
                        this.TxtResultado.Text = "3";
                        break;
                    case "btn4":
                        this.TxtResultado.Text = "4";
                        break;
                    case "btn5":
                        this.TxtResultado.Text = "5";
                        break;
                    case "btn6":
                        this.TxtResultado.Text = "6";
                        break;
                    case "btn7":
                        this.TxtResultado.Text = "7";
                        break;
                    case "btn8":
                        this.TxtResultado.Text = "8";
                        break;
                    case "btn9":
                        this.TxtResultado.Text = "9";
                        break;
                    default:
                        break;
                }
            }

            if(this.groupBox2.Controls.Contains(auxiliar))
            {
                this.EliminarEvento(this.groupBox2);

                switch(auxiliar)
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AgregaEvento(this.groupBox1);
        }

        public void AgregaEvento(GroupBox Grupo)
        {
            this.EliminarEvento(Grupo);

            foreach (Control item in Grupo.Controls)
            {
                item.Click += ManejadorCentral;
            }
        }

        public void EliminarEvento(GroupBox Grupo)
        {
            foreach (Control item in Grupo.Controls)
            {
                item.Click -= ManejadorCentral;
            }
        }
    }
}
