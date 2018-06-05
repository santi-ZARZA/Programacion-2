using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace WF
{
    //[Serializable()]
    public partial class Form1 : Form
    {
        SaveFileDialog saveFile = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
            foreach (Jugador.EPuesto item in Enum.GetValues(typeof(Jugador.EPuesto)))
            {
                this.comboBox1.Items.Add(item);
            }
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedItem = Jugador.EPuesto.Arquero;
            //this.btnSerializaXML.Enabled = false;
            //this.btnSerializaXML.Visible = false;
            //this.btnDescerializaXML.Enabled = false;
            //this.btnDescerializaXML.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Jugador aux = new Jugador(this.txtNombre.Text, this.txtApellido.Text, (Jugador.EPuesto)this.comboBox1.SelectedItem);

            if(this.saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = "";

                    path = this.saveFile.FileNames[0];

                    if (AdministraDeArchivos.Escribir(path, aux.ToString(), true) == true)
                    {
                        try
                        {
                            string linea = "";

                            if (AdministraDeArchivos.Leer(path, out linea))
                            {
                                MessageBox.Show("Jugador Abierto:\n"+ linea);
                            }
                        }
                        catch (Exception exception)
                        {
                            throw exception;
                        }

                    }
                }
                catch(Exception excep)
                {
                    throw excep;
                }

            }
            else
            { MessageBox.Show("Se ha producido un error al seleccionar archivo. Intente de nuevo"); }
        }

        private void BtnTraer_Click(object sender, EventArgs e)
        {
            Jugador jugadorBuscado;

            if (this.saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = this.saveFile.FileNames[0];
                    jugadorBuscado = new Jugador(this.txtNombre.Text, this.txtApellido.Text, (Jugador.EPuesto)this.comboBox1.SelectedItem);
                    Jugador auxiliar;

                    if (Jugador.TraerUno(path,jugadorBuscado,out auxiliar)== true)
                    {
                        MessageBox.Show("Jugador encontrado.");
                        this.txtNombre.Text = auxiliar.Nombre;
                        this.txtApellido.Text = auxiliar.Apellido;
                        this.comboBox1.SelectedItem = auxiliar.Puesto;
                    }
                    else
                    {
                        MessageBox.Show("Jugador no Encontrado.");
                    }
                }
                catch(Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            else
            {
                MessageBox.Show("Hubo un error porfavor reintente.");
            }

        }

        private void btnSerializaBinario_Click(object sender, EventArgs e)
        {
            Jugador jugadorNuevo = new Jugador(this.txtNombre.Text, this.txtApellido.Text, (Jugador.EPuesto)this.comboBox1.SelectedItem);

            ((ISerializacionBinaria)jugadorNuevo).Serializar();

            MessageBox.Show("Serializado con Exito.");
        }

        private void btnDescerializaBinario_Click(object sender, EventArgs e)
        {
            Jugador jugadorSerializado = new Jugador();
            Jugador auxJugador;

            auxJugador = ((ISerializacionBinaria)jugadorSerializado).Deserializar();

            MessageBox.Show("Jugador Deserializado:\n" + auxJugador.ToString());
        }

        private void btnSerializaXML_Click(object sender, EventArgs e)
        {
            //Jugador jugador = new Jugador(this.txtNombre.Text, this.txtApellido.Text, ((Jugador.EPuesto)this.comboBox1.SelectedItem));

            //((ISerializacionXML)jugador).Serializar();

            //MessageBox.Show("Jugador Serializado a XML.");
            Jugador auxJugador = new Jugador(this.txtNombre.Text, this.txtApellido.Text, ((Jugador.EPuesto)this.comboBox1.SelectedItem));

            ((ISerializacionXML)auxJugador).Serializar(); //Requiere que la clase posea un constructor por default, y que todos los atributos a serializar sean publicos o tengan propiedades de lecto-escritura
            MessageBox.Show("Serializado");
        }

        private void btnDescerializaXML_Click(object sender, EventArgs e)
        {
            //Jugador jugador = new Jugador("", "", Jugador.EPuesto.Arquero);
            //Jugador deserializa = ((ISerializacionXML)jugador).Deserializar();

            //MessageBox.Show("Jugador Deserializado:\n" + deserializa.ToString());

            Jugador auxJugador = new Jugador("", "", Jugador.EPuesto.Arquero);
            Jugador auxJugador2 = ((ISerializacionXML)auxJugador).Deserializar();

            MessageBox.Show("DeSerializado\n" + auxJugador2.ToString());
        }
    }
}
