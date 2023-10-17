
namespace Compiladores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Entrada = new System.Windows.Forms.TextBox();
            this.Salida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.limpiarEntrada = new System.Windows.Forms.Button();
            this.limpiarSalida = new System.Windows.Forms.Button();
            this.cargarArchivo = new System.Windows.Forms.Button();
            this.cargarDirectorio = new System.Windows.Forms.Button();
            this.Directorio = new System.Windows.Forms.OpenFileDialog();
            this.btnFlujoC = new System.Windows.Forms.Button();
            this.btnLineasColumnas = new System.Windows.Forms.Button();
            this.token = new System.Windows.Forms.Button();
            this.Errores = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Salida2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DataMostrar = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrada
            // 
            this.Entrada.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrada.Location = new System.Drawing.Point(12, 56);
            this.Entrada.Multiline = true;
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(349, 275);
            this.Entrada.TabIndex = 0;
            // 
            // Salida
            // 
            this.Salida.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salida.Location = new System.Drawing.Point(383, 56);
            this.Salida.Multiline = true;
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(411, 275);
            this.Salida.TabIndex = 1;
            this.Salida.TextChanged += new System.EventHandler(this.Salida_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programa de Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // limpiarEntrada
            // 
            this.limpiarEntrada.Location = new System.Drawing.Point(273, 27);
            this.limpiarEntrada.Name = "limpiarEntrada";
            this.limpiarEntrada.Size = new System.Drawing.Size(88, 23);
            this.limpiarEntrada.TabIndex = 4;
            this.limpiarEntrada.Text = "Limpiar Entrada";
            this.limpiarEntrada.UseVisualStyleBackColor = true;
            this.limpiarEntrada.Click += new System.EventHandler(this.limpiarEntrada_Click);
            // 
            // limpiarSalida
            // 
            this.limpiarSalida.Location = new System.Drawing.Point(706, 27);
            this.limpiarSalida.Name = "limpiarSalida";
            this.limpiarSalida.Size = new System.Drawing.Size(88, 23);
            this.limpiarSalida.TabIndex = 5;
            this.limpiarSalida.Text = "Limpiar Salida";
            this.limpiarSalida.UseVisualStyleBackColor = true;
            this.limpiarSalida.Click += new System.EventHandler(this.limpiarSalida_Click);
            // 
            // cargarArchivo
            // 
            this.cargarArchivo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cargarArchivo.Location = new System.Drawing.Point(800, 169);
            this.cargarArchivo.Name = "cargarArchivo";
            this.cargarArchivo.Size = new System.Drawing.Size(128, 23);
            this.cargarArchivo.TabIndex = 6;
            this.cargarArchivo.Text = "Cargar Archivo";
            this.cargarArchivo.UseVisualStyleBackColor = false;
            this.cargarArchivo.Click += new System.EventHandler(this.cargarArchivo_Click);
            // 
            // cargarDirectorio
            // 
            this.cargarDirectorio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cargarDirectorio.Location = new System.Drawing.Point(800, 111);
            this.cargarDirectorio.Name = "cargarDirectorio";
            this.cargarDirectorio.Size = new System.Drawing.Size(128, 23);
            this.cargarDirectorio.TabIndex = 7;
            this.cargarDirectorio.Text = "Cargar desde Directorio";
            this.cargarDirectorio.UseVisualStyleBackColor = false;
            this.cargarDirectorio.Click += new System.EventHandler(this.cargarDirectorio_Click);
            // 
            // Directorio
            // 
            this.Directorio.FileName = "openFileDialog1";
            // 
            // btnFlujoC
            // 
            this.btnFlujoC.BackColor = System.Drawing.Color.Khaki;
            this.btnFlujoC.Location = new System.Drawing.Point(800, 53);
            this.btnFlujoC.Name = "btnFlujoC";
            this.btnFlujoC.Size = new System.Drawing.Size(128, 23);
            this.btnFlujoC.TabIndex = 9;
            this.btnFlujoC.Text = "Flujo de Caracteres";
            this.btnFlujoC.UseVisualStyleBackColor = false;
            this.btnFlujoC.Click += new System.EventHandler(this.btnFlujoC_Click);
            // 
            // btnLineasColumnas
            // 
            this.btnLineasColumnas.BackColor = System.Drawing.Color.Khaki;
            this.btnLineasColumnas.Location = new System.Drawing.Point(800, 82);
            this.btnLineasColumnas.Name = "btnLineasColumnas";
            this.btnLineasColumnas.Size = new System.Drawing.Size(128, 23);
            this.btnLineasColumnas.TabIndex = 10;
            this.btnLineasColumnas.Text = "Lineas y Columnas";
            this.btnLineasColumnas.UseVisualStyleBackColor = false;
            this.btnLineasColumnas.Click += new System.EventHandler(this.btnLineasColumnas_Click);
            // 
            // token
            // 
            this.token.BackColor = System.Drawing.Color.YellowGreen;
            this.token.Location = new System.Drawing.Point(267, 337);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(94, 23);
            this.token.TabIndex = 11;
            this.token.Text = "scanear";
            this.token.UseVisualStyleBackColor = false;
            this.token.Click += new System.EventHandler(this.token_Click);
            // 
            // Errores
            // 
            this.Errores.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errores.ForeColor = System.Drawing.Color.Maroon;
            this.Errores.Location = new System.Drawing.Point(12, 403);
            this.Errores.Name = "Errores";
            this.Errores.Size = new System.Drawing.Size(488, 158);
            this.Errores.TabIndex = 12;
            this.Errores.Text = "";
            this.Errores.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // btnParser
            // 
            this.btnParser.Location = new System.Drawing.Point(717, 337);
            this.btnParser.Name = "btnParser";
            this.btnParser.Size = new System.Drawing.Size(77, 23);
            this.btnParser.TabIndex = 17;
            this.btnParser.Text = "Parser";
            this.btnParser.UseVisualStyleBackColor = true;
            this.btnParser.Click += new System.EventHandler(this.btnParser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ERRORES";
            // 
            // Salida2
            // 
            this.Salida2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salida2.Location = new System.Drawing.Point(519, 403);
            this.Salida2.Multiline = true;
            this.Salida2.Name = "Salida2";
            this.Salida2.Size = new System.Drawing.Size(349, 352);
            this.Salida2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Parser";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(800, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Descargar archivo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataMostrar
            // 
            this.DataMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexema,
            this.Token1});
            this.DataMostrar.Location = new System.Drawing.Point(12, 567);
            this.DataMostrar.Name = "DataMostrar";
            this.DataMostrar.Size = new System.Drawing.Size(488, 188);
            this.DataMostrar.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Tokens";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(800, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "IDS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(800, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Operadores";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(800, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "Simbolos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // Token1
            // 
            this.Token1.HeaderText = "Token1";
            this.Token1.Name = "Token1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(945, 821);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Salida2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnParser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Errores);
            this.Controls.Add(this.token);
            this.Controls.Add(this.btnLineasColumnas);
            this.Controls.Add(this.btnFlujoC);
            this.Controls.Add(this.cargarDirectorio);
            this.Controls.Add(this.cargarArchivo);
            this.Controls.Add(this.limpiarSalida);
            this.Controls.Add(this.limpiarEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.Entrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Compiladores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Entrada;
        private System.Windows.Forms.TextBox Salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button limpiarEntrada;
        private System.Windows.Forms.Button limpiarSalida;
        private System.Windows.Forms.Button cargarArchivo;
        private System.Windows.Forms.Button cargarDirectorio;
        private System.Windows.Forms.OpenFileDialog Directorio;
        private System.Windows.Forms.Button btnFlujoC;
        private System.Windows.Forms.Button btnLineasColumnas;
        private System.Windows.Forms.Button token;
        private System.Windows.Forms.RichTextBox Errores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Salida2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataMostrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token1;
    }
}

