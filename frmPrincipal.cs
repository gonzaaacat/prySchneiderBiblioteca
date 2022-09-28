using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySchneiderBiblioteca
{
    public partial class frmPrincipal : Form
    {
        char separador = Convert.ToChar(",");
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public string[,] baseLibro = new string[20, 5];
        public int contador = 0;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {          
            int i = 0;
          
            StreamReader objLector = new StreamReader("./Libro.txt", true);

            while (!objLector.EndOfStream)
            {
                string[] vecLibro = objLector.ReadLine().Split(separador);

                if (i < 20)
                {                   
                    baseLibro[i, 0] = vecLibro[0];
                    baseLibro[i, 1] = vecLibro[1];
                    baseLibro[i, 2] = vecLibro[2]; //Las columnas de la matriz cargan la informacion al vector 
                    baseLibro[i, 3] = vecLibro[3];
                    baseLibro[i, 4] = vecLibro[4];
                 
                    NombreEditorial(i); //Llamar estructura NombreEditorial que va a cambiar los números por los códigos

                    NombreDistribuidora(i); //Llamar estructura NombreDistribuidora que va a cambiar los números por los códigos correspondientes
                    i++;
                }
            }
            objLector.Close();

            //Cargar en las cajas de texto la información de la matriz
            txtCodigodelLibro.Text = baseLibro[0, 0];
            txtNombredelLibro.Text = baseLibro[0, 1];
            txtCodigodeEditorial.Text = baseLibro[0, 2];
            txtCodigodelAutor.Text = baseLibro[0, 3];
            txtCodigodeDistribuidor.Text = baseLibro[0, 4];
            
            btnRetroceder.Enabled = false;
        }       
        int indiceRecorrido = 0;

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            
            contador++; //Incrementar el contador para recorrer la base de datos

            

            txtCodigodelLibro.Text = baseLibro[contador, 0];
            txtNombredelLibro.Text = baseLibro[contador, 1];
            txtCodigodeEditorial.Text = baseLibro[contador, 2]; //Mostrar la información que contiene la matriz en las cajas de texto
            txtCodigodelAutor.Text = baseLibro[contador, 3];
            txtCodigodeDistribuidor.Text = baseLibro[contador, 4];

            btnRetroceder.Enabled = true;

            if (contador == baseLibro.GetLength(0) - 1)
            {
                btnAvanzar.Enabled = false;
            }
        }
        private void btnRetroceder_Click(object sender, EventArgs e)
        {           
            contador--;

            //Si el contador es menor o igual que 0 disminuye y muestra en la caja de texto la información de la matriz
            if (contador >= 0)
            {
                txtCodigodelLibro.Text = baseLibro[contador, 0];
                txtNombredelLibro.Text = baseLibro[contador, 1];
                txtCodigodeEditorial.Text = baseLibro[contador, 2];
                txtCodigodelAutor.Text = baseLibro[contador, 3];
                txtCodigodeDistribuidor.Text = baseLibro[contador, 4];
                
                if (contador == 0)
                {
                    btnRetroceder.Enabled = false;
                }
            }           
            else
            {
                btnRetroceder.Enabled = true;
            }
        }
        private void NombreEditorial(int iMatriz)
        {           
            StreamReader LectorEditorial = new StreamReader("./EDITORIAL.txt");

            while (!LectorEditorial.EndOfStream)
            {
                //Comparar el código del libro con el código de Editorial
                //En vez de devolver el código, devuelve el nombre de la editorial.

                string[] vecEditorial = LectorEditorial.ReadLine().Split(separador);

                //Cambio el código por el nombre correspondiente
                if (vecEditorial[0] == baseLibro[iMatriz, 2])
                {               
                    baseLibro[iMatriz, 2] = vecEditorial[1];
                }
            }
            LectorEditorial.Close();
        }
        private void NombreDistribuidora(int iMatriz)
        { 
            StreamReader LectorDistribuidora = new StreamReader("./DISTRIBUIDORA.txt");

            while (!LectorDistribuidora.EndOfStream)
            {
                //Comparar el codigo del libro con el codigo de Distruibuidor 
                //En vez de devolver el codigo, devuelve el nombre del distribuidor

                string[] vecDistribuidora = LectorDistribuidora.ReadLine().Split(separador);

                //Cambio el código por el nombre correspondiente
                if (vecDistribuidora[0] == baseLibro[iMatriz, 4])
                {
                    //Sobrescribo en la columna el nombre de la editorial almacenado en el vector
                    baseLibro[iMatriz, 4] = vecDistribuidora[1];
                }
            }
        }
    }

    
}
