using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Compiladores
{
    class Sintactico
    {
        
        List<Token> listaTokens;

        int numPreAnalisis;
        int numPreNext;
        Token getToken; //getToken
        Token NextToken; //NextToken

        public string ErrorSintactico;
        public string AnalisisSintactico;

        public void parser(List<Token> list)
        {
            listaTokens = list;
            listaTokens.Add(new Token("UltimoToken", "UltimoToken",0,0,0,"UltimoToken")); //uno es Lexema y el otro ID.. Construye el token.. Le pongo senal

            getToken = list.ElementAt(0); //getToken obtengo tokens de un listado segun la posicion
            numPreAnalisis = 0; //guarda la posicion en que se encuentra del listado (getToken)
            numPreNext = 0;
            NextToken = list.ElementAt(0);

            S();

        }

        //cuando es terminal es con funcion y cuando es no terminal se usa comparar
        void S()  //funcion
        {
            Main();
        }

        void Main()  //funcion
        {
            comparar("Main");
            comparar("(");
            comparar(")");
            comparar("{");
            BODY();
            comparar("}");
            
            
            //MessageBox.Show(getToken.getIdToken());
            if (!getToken.getIdToken().Equals("UltimoToken")) //valida si existe un token siguiente
            {
                
                numPreAnalisis++;
                numPreNext++;
                getToken = listaTokens.ElementAt(numPreAnalisis);
                NextToken = listaTokens.ElementAt(numPreNext);
                //MessageBox.Show("¡¡¡ P R O G A M A    NO     V À L I D O !!!     Error en: " + " Línea: " + getToken.getLinea() + " Columna: " + getToken.getColumna());
                ErrorSintactico = ErrorSintactico + "\n" + "¡¡¡PROGAMA NO VÀLIDO!!! Error en: " + " Línea: " + getToken.getLinea() + " Columna: " + getToken.getColumna();
            }
            else
            {
                //MessageBox.Show("¡¡¡ P R O G A M A    V À L I D O !!!");
                //MessageBox.Show(getToken.getIdToken());
            }

            //comparar("");
            //comparar("");
        }

        void ASIG()  //funcion asignacion
        {
            compararToken(" Id");
            compararToken(" Operador Asignacion");
            R();
            comparar(";");
        }


        void R()  //funcion asignacion
        {
            if (getToken.getIdToken() == " Id")
            {
                compararToken(" Id");
            }
            else if (getToken.getIdToken() == " Número Decimal")
            {
                compararToken(" Número Decimal");
            }
            else if (getToken.getIdToken() == " Número Entero")
            {
                compararToken(" Número Entero");
            }
            else if (getToken.getIdToken() == " Cadena")
            {
                compararToken(" Cadena");
            }
            else 
            {
                //MessageBox.Show("Error Sintáctico, se esperaba un numero o una cadena o un identificador " +  " Línea: " + getToken.getLinea() + " Columna: " + getToken.getColumna());
                ErrorSintactico = ErrorSintactico + "\n" + "Error Sintáctico, se esperaba un numero o una cadena o un identificador " + " en Línea: " + getToken.getLinea() + " y Columna: " + getToken.getColumna();
            }
        }
        void BODY() 
        {
            if (getToken.getLexema() == "Dim")
            {
                List_Declaracion();
                BODY();
            }
            else if (getToken.getIdToken() == " Id")
            {
                List_ASIG();
                BODY();
            }
            else if (getToken.getLexema() == "If")
            {
                List_If();
                BODY();
            }
            else if (getToken.getLexema() == "For")
            {
                List_for();
                BODY();
            }
        }

        void List_If()
        {
            if_get();


            if (getToken.getLexema() == "If")
            {
                List_If();
            }
           
            
        }

        void if_get()
        {
            comparar("If");
            comparar("(");
            compararToken(" Id");
            compararToken(" Operador");
            R();
            comparar(")");
            if (getToken.getLexema() ==  "Then")

            {
                comparar("Then");
                comparar("{");
                BODY();

            }

            
            if (getToken.getLexema() == "Else")
            {
                comparar("Else");
                BODY();

            }

            comparar("}");


        }


        void List_for()
        {
            for_get();


            if (getToken.getLexema() == "For")
            {
                List_for();
            }

            void for_get()
            {
                comparar("For");
                comparar("(");
                comparar("int");
                comparar("i");
                compararToken(" Operador");
                compararToken(" Número Entero");
                comparar(";");
                comparar("i");
                compararToken(" Operador");
                compararToken(" Número Entero");
                comparar(";");
                comparar("i++");
                comparar(")");
                if (getToken.getLexema() == "{")

                {
                    comparar("{");
                    BODY();


                }
                comparar("}");


            }

        }


            void List_Declaracion()  //funcion
        {
            Declaracion();
            
            if (getToken.getLexema() == "Dim")
            {
                List_Declaracion();
            } 
            
        }

        void List_ASIG()  //funcion
        {
            ASIG();

            if (getToken.getIdToken() == " Id")
            {
                List_ASIG();
            }

        }

        void Declaracion()  //funcion
        {
            comparar("Dim");
            Variable();
            comparar("As");
            Tipo();
            comparar(";");
        }

        void Variable()  //funcion
        {
            compararToken(" Id");
            List_ID();
        }

        void List_ID()
        {

            //MessageBox.Show(getToken.getIdToken());
            if (getToken.getIdToken() == " Signo de Puntuación Coma")
            {
                compararToken(" Signo de Puntuación Coma"); //get lexema trae el puro texto
                compararToken(" Id");

                List_ID();
            }
        }
        void Tipo()  //funcion 
        {
            compararToken(" Tipo");
        }
        public void comparar(String tipo)
        {
            if (!tipo.Equals(getToken.getLexema()))
            {
                //MessageBox.Show("Error Sintáctico, se esperaba " + tipo + " Línea: " + getToken.getLinea() + " Columna: " + getToken.getColumna());
                ErrorSintactico = ErrorSintactico+"\n"+ "Error Sintáctico, se esperaba " + tipo + " en Línea: " + getToken.getLinea() + " y Columna: " + getToken.getColumna();
            }
            else
            {
                // MessageBox.Show(getToken.getLexema() + " Pertenece a la gramática");
                AnalisisSintactico = AnalisisSintactico + getToken.getLexema() + "       Pertenece a la gramática" + Environment.NewLine;
            }
            if (!getToken.getIdToken().Equals("UltimoToken")) //valida si existe un token siguiente
            {
                numPreAnalisis++;
                getToken = listaTokens.ElementAt(numPreAnalisis);
            }
            else
            {
                //MessageBox.Show("Fin de la lista");
            }
        }

        public void compararToken(String tipo) //aca si comparamos el tipo de token, es decir el id
        {

            if (!tipo.Equals(getToken.getIdToken()))
            {
                //MessageBox.Show("Error Sintáctico, se esperaba " + tipo + " Línea: " + getToken.getLinea() + " Columna: " + getToken.getColumna());
                ErrorSintactico = ErrorSintactico + "\n" + "Error Sintáctico, se esperaba " + tipo + " en Línea: " + getToken.getLinea() + " y Columna: " + getToken.getColumna();
            }
            else
            {
                // MessageBox.Show(getToken.getLexema() + " Pertenece a la gramática Token");
                AnalisisSintactico = AnalisisSintactico + getToken.getLexema() + "       Pertenece a la gramática" + Environment.NewLine;
            }
            if (!getToken.getIdToken().Equals("UltimoToken")) //valida si existe un token siguiente
            {
                numPreAnalisis++;
                getToken = listaTokens.ElementAt(numPreAnalisis);
            }
            else
            {
                //MessageBox.Show("Fin de la lista");
            }
        }
        public String getErrores()
        {
            return ErrorSintactico;
        }
        public String getGrammar()
        {
            return AnalisisSintactico;
        }
    }
}
