using System.Drawing;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Compiladores
{
    public partial class Form1 : Form
    {
        public String Path_actual;
        public String nombre_actual;
        static private List<Token> lis_toks;
        static private List<ErroresToken> lis_err;

        public Form1()
        {
            InitializeComponent();
            Entrada.ScrollBars = ScrollBars.Both;
            Salida.ScrollBars = ScrollBars.Both;
            Salida2.ScrollBars = ScrollBars.Both;
        }
        private void limpiarEntrada_Click(object sender, EventArgs e)
        {
            Entrada.Text = "";
        }
        private void limpiarSalida_Click(object sender, EventArgs e)
        {
            Salida.Text = "";
            Errores.Text = "";
            Salida2.Text = "";
            
        }
        private void cargarArchivo_Click(object sender, EventArgs e)
        {
            Entrada.Text = File.ReadAllText(@"C:\prueba_final.txt");
        }
        private void cargarDirectorio_Click(object sender, EventArgs e)
        {
            Directorio.Filter = ("Archivos de Texto | *.txt");
            Directorio.ShowDialog();
            Entrada.Text = File.ReadAllText(Directorio.FileName);
        }
        private void analisisLex_Click(object sender, EventArgs e)
        {
            Salida.Text = Entrada.Text;
        }
        private void btnFlujoC_Click(object sender, EventArgs e)
        {
            int line;
            int column;
            line = 1;
            column = 0;
            foreach (char caracter in Entrada.Text)
            {
                if (caracter == ' ')
                {
                    column = column + 1;
                    Salida.Text = Salida.Text + " ESPACIO EN BLANCO" +
                    Environment.NewLine;
                }
                else if (caracter == '\t')
                {
                    column = column + 8;
                    Salida.Text = Salida.Text + " TABULADOR " + Environment.NewLine;
                }
                else if (caracter == '\r')
                {
                    column = +1;
                    Salida.Text = Salida.Text + " FIN DE LINEA" + Environment.NewLine; line = line + 1;
                    column = 0;
                }
                else if (caracter == '\n')
                {
                    column = +1;
                    Salida.Text = Salida.Text + " SALTO DE LINEA" + Environment.NewLine;
                }
                else
                {
                    column = column + 1;
                    Salida.Text = Salida.Text + caracter.ToString() + Environment.NewLine;
                }
            }
        }
        private void btnLineasColumnas_Click(object sender, EventArgs e)
        {
            int line;
            int column;
            line = 1;
            column = 0;
            foreach (char caracter in Entrada.Text)
            {
                if (caracter == ' ')
                {
                    column = column + 1;
                    Salida.Text = Salida.Text + " ESPACIO EN BLANCO" +
                    Environment.NewLine;
                }
                else if (caracter == '\t')
                {
                    column = +8;
                    Salida.Text = Salida.Text + " TABULADOR " + Environment.NewLine;
                }
                else if (caracter == '\r')
                {
                    column = +1;
                    Salida.Text = Salida.Text + " FIN DE LINEA" + Environment.NewLine;
                }
                else if (caracter == '\n')
                {
                    column = +1;
                    Salida.Text = Salida.Text + " SALTO DE LINEA" + Environment.NewLine; line = line + 1;
                    column = 0;
                }
                else
                {
                    column = column + 1;
                    Salida.Text = Salida.Text + caracter.ToString() + " " + line.ToString() + " LINEA " + column.ToString() + " COLUMNA " + Environment.NewLine;
                }
            }
        }
       
        private void token_Click(object sender, EventArgs e)
        {
          
   
                String texto;
                texto = Entrada.Text;
                Analizer analiz = new Analizer();
                analiz.Analizador_cadena(texto);
                    analiz.generarLista();
                
            //Salida.Text = analiz.getRetorno();

            lis_toks = new List<Token>();
                lis_toks = analiz.getListaTokens();

                for (int i = 0; i < lis_toks.Count; i++)
                {
                    Token actual = lis_toks.ElementAt(i);
                }

                lis_err = new List<ErroresToken>();
                lis_err = analiz.getListaErrores();
                string erro_str = "";
                for (int i = 0; i < lis_err.Count; i++)
                {
                    ErroresToken errstr = lis_err.ElementAt(i);
                    erro_str += "[ERROR: " + errstr.getLexema() + errstr.getIdToken() + ", LINEA: " + errstr.getLinea() + ", COLUMNA: " + errstr.getColumna() + "]" + Environment.NewLine; 
                }
                Salida.Text = analiz.getRetorno();
                Errores.Text = erro_str;
                Errores.Visible = true;



        }

    private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void Salida_TextChanged(object sender, EventArgs e)
        {
        }


        

        private void btnParser_Click(object sender, EventArgs e)
        {
            Sintactico sint = new Sintactico();
            sint.parser(lis_toks);

            String errorSint = sint.getErrores();
            Errores.Text = Errores.Text + errorSint;

            String validGrammar = sint.getGrammar();
            Salida2.Text = Salida2.Text + validGrammar;
           

        }



        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        static void EscribirEnArchivo(string datos, string rutaArchivo)
        {
            // Utiliza un bloque using para asegurar que el StreamWriter se cierre correctamente
            using (StreamWriter escritor = new StreamWriter(rutaArchivo))
            {
                // Escribe los datos en el archivo
                escritor.Write(datos);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Datos que deseas escribir en el archivo
            string datos = Salida.Text;

            // Ruta del archivo donde se almacenarán los datos
            string rutaArchivo = "C:/Users/LENOVO/Desktop/Compiladores_Josue/archivo.txt";

            // Llamada a la función para escribir en el archivo
            EscribirEnArchivo(datos, rutaArchivo);

            Console.WriteLine("Datos escritos en el archivo exitosamente.");
        }

        private void iDSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
}


