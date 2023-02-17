namespace AnalizadorLexico
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
            this.interpretar_btn = new System.Windows.Forms.Button();
            this.texto_richText = new System.Windows.Forms.RichTextBox();
            this.listBox_variablesEncontradas = new System.Windows.Forms.ListBox();
            this.listBox_variablesOperaciones = new System.Windows.Forms.ListBox();
            this.listBox_variablesDouble = new System.Windows.Forms.ListBox();
            this.listBox_variablesEntero = new System.Windows.Forms.ListBox();
            this.listBox_variablesString = new System.Windows.Forms.ListBox();
            this.listBox_variablesContexto = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_funcionesUtilizadas = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox_lexemas = new System.Windows.Forms.ListBox();
            this.TKN = new System.Windows.Forms.Label();
            this.listBox_tkn = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // interpretar_btn
            // 
            this.interpretar_btn.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interpretar_btn.Location = new System.Drawing.Point(1215, 5);
            this.interpretar_btn.Name = "interpretar_btn";
            this.interpretar_btn.Size = new System.Drawing.Size(185, 43);
            this.interpretar_btn.TabIndex = 1;
            this.interpretar_btn.Text = "ACEPTAR";
            this.interpretar_btn.UseVisualStyleBackColor = true;
            this.interpretar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto_richText
            // 
            this.texto_richText.Location = new System.Drawing.Point(28, 53);
            this.texto_richText.Name = "texto_richText";
            this.texto_richText.Size = new System.Drawing.Size(1372, 287);
            this.texto_richText.TabIndex = 3;
            this.texto_richText.Text = "";
            // 
            // listBox_variablesEncontradas
            // 
            this.listBox_variablesEncontradas.FormattingEnabled = true;
            this.listBox_variablesEncontradas.HorizontalScrollbar = true;
            this.listBox_variablesEncontradas.Location = new System.Drawing.Point(28, 381);
            this.listBox_variablesEncontradas.Name = "listBox_variablesEncontradas";
            this.listBox_variablesEncontradas.Size = new System.Drawing.Size(155, 290);
            this.listBox_variablesEncontradas.TabIndex = 4;
            // 
            // listBox_variablesOperaciones
            // 
            this.listBox_variablesOperaciones.FormattingEnabled = true;
            this.listBox_variablesOperaciones.HorizontalScrollbar = true;
            this.listBox_variablesOperaciones.Location = new System.Drawing.Point(198, 381);
            this.listBox_variablesOperaciones.Name = "listBox_variablesOperaciones";
            this.listBox_variablesOperaciones.Size = new System.Drawing.Size(256, 290);
            this.listBox_variablesOperaciones.TabIndex = 5;
            // 
            // listBox_variablesDouble
            // 
            this.listBox_variablesDouble.FormattingEnabled = true;
            this.listBox_variablesDouble.HorizontalScrollbar = true;
            this.listBox_variablesDouble.Location = new System.Drawing.Point(471, 381);
            this.listBox_variablesDouble.Name = "listBox_variablesDouble";
            this.listBox_variablesDouble.Size = new System.Drawing.Size(140, 290);
            this.listBox_variablesDouble.TabIndex = 6;
            // 
            // listBox_variablesEntero
            // 
            this.listBox_variablesEntero.FormattingEnabled = true;
            this.listBox_variablesEntero.HorizontalScrollbar = true;
            this.listBox_variablesEntero.Location = new System.Drawing.Point(630, 381);
            this.listBox_variablesEntero.Name = "listBox_variablesEntero";
            this.listBox_variablesEntero.Size = new System.Drawing.Size(123, 290);
            this.listBox_variablesEntero.TabIndex = 7;
            // 
            // listBox_variablesString
            // 
            this.listBox_variablesString.FormattingEnabled = true;
            this.listBox_variablesString.HorizontalScrollbar = true;
            this.listBox_variablesString.Location = new System.Drawing.Point(774, 381);
            this.listBox_variablesString.Name = "listBox_variablesString";
            this.listBox_variablesString.Size = new System.Drawing.Size(123, 290);
            this.listBox_variablesString.TabIndex = 8;
            // 
            // listBox_variablesContexto
            // 
            this.listBox_variablesContexto.FormattingEnabled = true;
            this.listBox_variablesContexto.HorizontalScrollbar = true;
            this.listBox_variablesContexto.Location = new System.Drawing.Point(913, 381);
            this.listBox_variablesContexto.Name = "listBox_variablesContexto";
            this.listBox_variablesContexto.Size = new System.Drawing.Size(147, 290);
            this.listBox_variablesContexto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "INGRESA EL CODIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cadenas que coinciden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Variables equivalentes a una operación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Variables decimales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(626, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Variables enteras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(770, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Variables de texto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(909, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Variables de contexto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1074, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Funciones utilizadas:";
            // 
            // listBox_funcionesUtilizadas
            // 
            this.listBox_funcionesUtilizadas.FormattingEnabled = true;
            this.listBox_funcionesUtilizadas.HorizontalScrollbar = true;
            this.listBox_funcionesUtilizadas.Location = new System.Drawing.Point(1078, 381);
            this.listBox_funcionesUtilizadas.Name = "listBox_funcionesUtilizadas";
            this.listBox_funcionesUtilizadas.Size = new System.Drawing.Size(140, 290);
            this.listBox_funcionesUtilizadas.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1238, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Lexema:";
            // 
            // listBox_lexemas
            // 
            this.listBox_lexemas.FormattingEnabled = true;
            this.listBox_lexemas.HorizontalScrollbar = true;
            this.listBox_lexemas.Location = new System.Drawing.Point(1242, 381);
            this.listBox_lexemas.Name = "listBox_lexemas";
            this.listBox_lexemas.Size = new System.Drawing.Size(140, 121);
            this.listBox_lexemas.TabIndex = 19;
            // 
            // TKN
            // 
            this.TKN.AutoSize = true;
            this.TKN.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKN.Location = new System.Drawing.Point(1238, 517);
            this.TKN.Name = "TKN";
            this.TKN.Size = new System.Drawing.Size(35, 20);
            this.TKN.TabIndex = 22;
            this.TKN.Text = "Tkn:";
            // 
            // listBox_tkn
            // 
            this.listBox_tkn.FormattingEnabled = true;
            this.listBox_tkn.HorizontalScrollbar = true;
            this.listBox_tkn.Location = new System.Drawing.Point(1242, 540);
            this.listBox_tkn.Name = "listBox_tkn";
            this.listBox_tkn.Size = new System.Drawing.Size(140, 121);
            this.listBox_tkn.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 788);
            this.Controls.Add(this.TKN);
            this.Controls.Add(this.listBox_tkn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox_lexemas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox_funcionesUtilizadas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_variablesContexto);
            this.Controls.Add(this.listBox_variablesString);
            this.Controls.Add(this.listBox_variablesEntero);
            this.Controls.Add(this.listBox_variablesDouble);
            this.Controls.Add(this.listBox_variablesOperaciones);
            this.Controls.Add(this.listBox_variablesEncontradas);
            this.Controls.Add(this.texto_richText);
            this.Controls.Add(this.interpretar_btn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button interpretar_btn;
        private System.Windows.Forms.RichTextBox texto_richText;
        private System.Windows.Forms.ListBox listBox_variablesEncontradas;
        private System.Windows.Forms.ListBox listBox_variablesOperaciones;
        private System.Windows.Forms.ListBox listBox_variablesDouble;
        private System.Windows.Forms.ListBox listBox_variablesEntero;
        private System.Windows.Forms.ListBox listBox_variablesString;
        private System.Windows.Forms.ListBox listBox_variablesContexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox_funcionesUtilizadas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox_lexemas;
        private System.Windows.Forms.Label TKN;
        private System.Windows.Forms.ListBox listBox_tkn;
    }
}

