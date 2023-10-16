using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Compiladores
{
    class Analizer
    {
        ArrayList tokensTipo;
        ArrayList tokens;
        ArrayList Lista_Operaciones;
        static private List<Token> listaTokens;
        public List<Lineas_Ejecutar> lin_ejecutar;
        //public List<Graficas_Ejecutar> graf_ejecutar;
        private String retorno;
        public int estado_token;

        //errores tokens
        static private List<ErroresToken> listaErrores;

        public Analizer()
        {
            //this.listaTokens = new List<Token>();
            listaTokens = new List<Token>();
            tokens = new ArrayList();
            tokensTipo = new ArrayList();
            tokens.Add("Main"); tokens.Add("Dim"); tokens.Add("As"); tokens.Add("If"); tokens.Add("Then"); tokens.Add("Else"); tokens.Add("main"); tokens.Add("dim"); tokens.Add("as");  tokens.Add("if"); tokens.Add("then"); tokens.Add("else"); tokens.Add("For"); tokens.Add("for"); 
            tokensTipo.Add("Integer"); tokensTipo.Add("Decimal"); tokensTipo.Add("String");
            Lista_Operaciones = new ArrayList();
            lin_ejecutar = new List<Lineas_Ejecutar>();

            //errores toks
            listaErrores = new List<ErroresToken>();
        }

        public void addToken(String lexema, String idToken, int linea, int columna, int indice, string lexema1)
        {
            //MessageBox.Show("*" + lexema + "* lin: " + linea + " col: " + columna, "Lexema_final");
            Token nuevo = new Token(lexema, idToken, linea, columna, indice, lexema1);
            listaTokens.Add(nuevo);
        }

        public void addError(String lexema, String idToken, int linea, int columna)
        {
            ErroresToken errtok = new ErroresToken(lexema, idToken, linea, columna);
            listaErrores.Add(errtok);

        }

        public void Analizador_cadena(String entrada)
        {
            int estado = 0;
            int columna = 0;
            int fila = 1;
            string lexema = "";
            string lexema1 = "";
            Char c;
            //MessageBox.Show(entrada, "111 entrada");
            entrada = entrada + " ";
            //entrada = entrada;
            //MessageBox.Show(entrada, "222 entrada");
            for (int i = 0; i < entrada.Length; i++)
            {
                c = entrada[i];
                columna++;
                //MessageBox.Show(c.ToString(), i.ToString() );
                //MessageBox.Show(estado.ToString(), "estado");
                switch (estado)
                {
                    case 0:
                        //columna++;

                        if (Char.IsLetter(c))
                        {
                            estado = 1;
                            lexema += c;
                        }
                        else if (Char.IsDigit(c))
                        {
                            estado = 2;
                            lexema += c;
                        }
                        else if (c == '+' && i < entrada.Length - 1 && entrada[i + 1] == '+')
                        {
                            addToken("++", " Operador Incremento", fila, columna, i, lexema1);
                            i++; // Saltar el siguiente '+'
                            estado = 0;
                        }
                        else if (c == '<' && i < entrada.Length - 1 && entrada[i + 1] == '=')
                        {
                            addToken("<=", " Operador", fila, columna, i, lexema1);
                            i++; // Saltar el siguiente '+'
                            estado = 0;
                        }
                        else if (c == '=' && i < entrada.Length - 1 && entrada[i + 1] == '>')
                        {
                            addToken("=>", " Operador", fila, columna, i, lexema1);
                            i++; // Saltar el siguiente '+'
                            estado = 0;
                        }

                        else if (c == '"' || c == '“')
                        {
                            estado = 4;
                            i--;
                            columna--;
                        }
                        else if (c == ',')
                        {
                            estado = 6;
                            i--;
                            columna--;
                        }
                        else if (c == ' ')
                        {
                            estado = 0;
                        }
                        else if (c == '\n')
                        {
                            columna = 0;
                            fila++;
                            estado = 0;
                        }
                        else if (c == '\r')
                        {
                            columna = 0;
                            estado = 0;
                        }
                        /*nuevos*/
                        else if (c == '\t')
                        {
                            lexema += c;
                            lexema = "";
                        }
                        else if (c == '{')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                        }
                        else if (c == '}')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                        }
                        else if (c == '(')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                        }
                        else if (c == ')')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                        }
                        else if (c == '[')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                        }
                        else if (c == ']')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                        }
                        else if (c == ';')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                        }


                        /*fin nuevos*/

                        /*operadores mat*/
                        


                        else if (c == '-')
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i, lexema1);
                            lexema = "";
                        }
                        else if (c == '*')
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i, lexema1);
                            lexema = "";
                        }
                        else if (c == '=')
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i, lexema1);
                            lexema = "";
                        }
                       
                        else if (c == '>')
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i, lexema1);
                            lexema = "";
                        }
                        else if (c == '<')
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i, lexema1);
                            lexema = "";
                        }

                        else if (c == '/')
                        {
                            estado = 10;
                        }
                        else if (c == ':' || c == '<' || c == '&' || c == '|')
                        {
                            estado = 13;
                            lexema += c;
                        }
                        /*fin operadors mat*/
                        else
                        {
                            estado = -99;
                            i--;
                            columna--;
                        }
                        break;


                    case 1:
                        if (Char.IsLetterOrDigit(c) || c == '_')
                        {
                            lexema += c;
                            estado = 1;
                        }
                        else if (lexema == "i" && c == '+' && i < entrada.Length - 1 && entrada[i + 1] == '+')
                        {
                            addToken("i++", " Operador Incremento", fila, columna, i, lexema1);
                            lexema = ""; // Reiniciar lexema después de procesar "i++"
                            i++;
                            estado = 0;
                        }
                        else
                        {
                            bool encontrado = Macht_enReser(lexema);
                            if (encontrado)
                            {
                                addToken(lexema, " Palabra Reservada", fila, columna, i - lexema.Length, lexema1);
                            }
                            else
                            {
                                bool encontradoTipo = Macht_Tipo(lexema);
                                if (encontradoTipo)
                                {
                                    addToken(lexema, " Tipo", fila, columna, i - lexema.Length, lexema1);
                                }
                                else
                                {
                                    addToken(lexema, " Id", fila, columna, i - lexema.Length, lexema1);
                                }

                            }


                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }

                        break;


                    case 2:
                        if (Char.IsDigit(c))
                        {
                            lexema += c;
                            estado = 2;
                        }
                        else if (c == '.')
                        {
                            estado = 8;
                            lexema += c;
                        }
                        else
                        {
                            addToken(lexema, " Número Entero", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        break;

                    case 3:
                        if (Char.IsDigit(c))
                        {
                            lexema += c;
                            estado = 2;
                        }
                        else
                        {
                            estado = -99;
                            i = i - 2;
                            columna = columna - 2;
                            lexema = "";
                        }
                        break;

                    case 4:
                        if (c == '"' || c == '“')
                        {
                            //addToken("\"", " Signo de Puntuación", fila, columna, i - lexema.Length);
                            estado = 5;
                        }
                        break;

                    case 5:
                        if (c == '"' || c == '"')
                        {
                            estado = 6;
                            i--;
                            columna--;
                        }
                        else
                        {
                            lexema += c;
                            estado = 5;
                        }
                        break;

                    case 6:
                        if (c == '"' || c == '"')
                        {

                            addToken("\"" + lexema + "\"", " Cadena", fila, columna, i - lexema.Length, lexema1);
                            estado = 0;
                            lexema = "";
                        }

                        else if (c == ',')
                        {
                            lexema += c;
                            addToken(lexema, " Signo de Puntuación Coma", fila, columna, i - lexema.Length, lexema1);
                            estado = 0;
                            lexema = "";
                        }
                        break;
                    /**inicio nuevo**/
                    case 8:
                        if (Char.IsDigit(c))
                        {
                            estado = 9;
                            lexema += c;
                        }
                        else
                        {
                            addError(lexema, " Se esperaba un digito [" + lexema + "]", fila, columna);
                            estado = 0;
                            lexema = "";
                        }
                        break;
                    case 9:
                        if (Char.IsDigit(c))
                        {
                            estado = 9;
                            lexema += c;
                        }
                        else
                        {
                            addToken(lexema, " Número Decimal", fila, columna, i - lexema.Length, lexema1);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        break;
                    /*fin nuevo*/
                    case 10:
                        if (c == '*')
                        {

                            //addToken("/*", " Inicia Comentarios", fila, columna, i);
                            estado = 11;
                        }
                        else
                        {
                            addToken("/", " Operador", fila, columna, i, lexema1);
                            estado = 0;
                            i--;
                        }
                        break;
                    case 11:
                        if (c == '*')
                        {
                            lexema += c;
                            estado = 12;
                        }
                        else if (c == '\n')
                        {
                            lexema += c;
                            columna = 0;
                            fila++;
                        }
                        else if (c == '\r')
                        {
                            columna = 0;
                        }
                        else if (i == entrada.Length - 1)
                        {
                            addError(lexema, " No se cerro el comentario", fila, columna);
                            i--;
                            estado = 0;
                        }
                        else
                        {
                            lexema += c;
                        }
                        break;

                    case 12:
                        if (c == '/')
                        {
                            //addToken(lexema.Substring(0, lexema.Length - 1), " Comentario", fila, columna-2, i);
                            //addToken("*/", " Termina Comentarios", fila, columna, i);
                            lexema = "";
                            estado = 0;
                        }
                        else
                        {
                            estado = 11;
                            lexema += c;
                        }
                        break;


                    case 13:
                        if (c == '=' && lexema == ":")
                        {
                            lexema += c;
                            if (entrada[i + 1] == '=')
                            {
                                lexema += '=';
                                i++;
                                addError(lexema, " Error Sintaxis", fila, columna);
                            }
                            else
                            {
                                addToken(lexema, " Operador Asignacion", fila, columna, i - lexema.Length, lexema1);
                            }
                        }



                        else if (c == '>' && lexema == "<")
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i - lexema.Length, lexema1);
                        }

                        else if (c == '&' && lexema == "&")
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i - lexema.Length, lexema1);
                        }
                        else if (c == '|' && lexema == "|")
                        {
                            lexema += c;
                            addToken(lexema, " Operador", fila, columna, i - lexema.Length, lexema1);
                        }
                        else if (lexema == "<")
                        {
                            addToken(lexema, " Operador", fila, columna, i, lexema1);
                            i--;
                        }
                        else
                        {
                            addError(lexema, " Error Sintaxis", fila, columna);
                            i--;
                        }

                        lexema = "";
                        estado = 0;
                        break;




                    case -99:
                        lexema += c;
                        addError(lexema, " Error Sintaxis", fila, columna);
                        estado = 0;
                        lexema = "";
                        break;
                }
            }
        }
       

        public Boolean Macht_enReser(String sente)
        {
            Boolean enco = false;
            for (int i = 0; i < tokens.Count; ++i)
            {
                //MessageBox.Show(tokens[i].ToString(), sente);
                //(reservadas[i].Lexema.Equals(lexema)) a = reservadas[i].Id;
                if (sente.ToString() == tokens[i].ToString())
                {
                    enco = true;
                    estado_token = i;
                    return enco;
                }
                else { enco = false; }
            }
            return enco;
        }
        public Boolean Macht_Tipo(String sente)
        {
            Boolean enco = false;
            for (int i = 0; i < tokensTipo.Count; ++i)
            {
                //MessageBox.Show(tokens[i].ToString(), sente);
                //(reservadas[i].Lexema.Equals(lexema)) a = reservadas[i].Id;
                if (sente.ToString() == tokensTipo[i].ToString())
                {
                    enco = true;
                    estado_token = i;
                    return enco;
                }
                else { enco = false; }

            }
            return enco;
        }

        /*verifica si es tipo*/
        public void generarLista()
        {
          for (int i = 0; i < listaTokens.Count; i++)
        {
          Token actual = listaTokens.ElementAt(i);
        retorno += actual.getLexema() + ", " + actual.getIdToken() + Environment.NewLine;

        /*if (actual.getLexema() == "Main")
        {
            MessageBox.Show("Programa Válido");
        }
        else
        {
            MessageBox.Show("Programa inválido");
        }*/
         }
         }

        



        public String getRetorno()
        {
            return this.retorno;
        }
        public List<Token> getListaTokens()
        {
            return listaTokens;
        }
        public List<ErroresToken> getListaErrores()
        {
            return listaErrores;
        }
    }
}

