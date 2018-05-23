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

namespace FormJugador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (EPuesto item in Enum.GetValues(typeof(EPuesto)))
            {
                this.cbPuesto.Items.Add(item);
            }
            this.cbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbPuesto.SelectedItem = EPuesto.Arquero;

           
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            Jugador j1 = new Jugador(this.txtNombre.Text, this.txtApellido.Text, (EPuesto)this.cbPuesto.SelectedItem);

            SaveFileDialog archivo = new SaveFileDialog();

            string path_original = "", path_aux = "";

                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    path_original = archivo.FileName;

                    string linea;

                    if ((AdministradorDeArchivos.Escribir(path_original, j1.ToString(), true) != false))
                    {
                        MessageBox.Show("Se creo el archivo exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No Se creo el archivo exitosamente");
                    }

                    

                    //if ((AdministradorDeArchivos.Leer(path_original, out linea)) != null)
                    //{
                    //    MessageBox.Show("Se a leido exitosamente el archivo.\nLos siguientes jugadores son:\n" + linea);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No Se pudo abrir el archivo exitosamente");
                    //}

                }
                else
                {
                    MessageBox.Show("No se pudo guardar ni crear el archivo");
                    this.Close();
                }
            }


        }

        private void cbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}


// MessageBox.Show(j1.ToString());

//StreamWriter escribe = new StreamWriter(@"D:\jugadores.txt",true);

//escribe.WriteLine(j1.ToString());

//escribe.Close();

//StreamReader lee = new StreamReader(@"D:\jugadores.txt");

//MessageBox.Show("lo escrito en el archivo es :\n" +  lee.ReadToEnd());

//lee.Close();

//while ((linea = lee.ReadLine()) != null)
//{
//    MessageBox.Show(linea);
//}

//@"C:\Users\alumno\Desktop\jugadores.txt"


/* 
            string linea;
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\jugadores.txt");



            if ((AdministradorDeArchivos.Escribir(path, j1.ToString(), true) != false))
            {
                MessageBox.Show("Se creo el archivo exitosamente");
            }
            else
            {
                MessageBox.Show("No Se creo el archivo exitosamente");
            }

            if ((AdministradorDeArchivos.Leer(path, out linea)) != null)
            {
                MessageBox.Show("Se a leido exitosamente el archivo.\nLos siguientes jugadores son:\n" + linea);
            }
            else
            {
                MessageBox.Show("No Se pudo abrir el archivo exitosamente");
            }
 */