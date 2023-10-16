using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiladores
{
    class Token
    {
        private String lexema;
        private String lexema1;
        private String idToken;

        private int linea;
        private int columna;
        private int indice;
        public Token(String lexema, String idToken, int linea, int columna, int indice, string lexema1)
        {

            this.lexema = lexema; //ultimo token

            this.idToken = idToken; //ultimo token

            this.linea = linea;
            this.columna = columna;
            this.indice = indice;
            this.lexema1 = lexema1;
        }

        public int getIndice()
        {
            return this.indice;
        }
        public String getLexema()
        {
            return this.lexema;
        }
        public String getIdToken()
        {
            return this.idToken;
        }
        public int getLinea()
        {
            return this.linea;
        }
        public int getColumna()
        {
            return this.columna;
        }
        public string getLexema1()
        {
            return this.lexema1;
        }
    }

    }

