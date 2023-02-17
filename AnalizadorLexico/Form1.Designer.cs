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
            this.SuspendLayout();
            // 
            // interpretar_btn
            // 
            this.interpretar_btn.Location = new System.Drawing.Point(28, 13);
            this.interpretar_btn.Name = "interpretar_btn";
            this.interpretar_btn.Size = new System.Drawing.Size(75, 23);
            this.interpretar_btn.TabIndex = 1;
            this.interpretar_btn.Text = "Interpretar";
            this.interpretar_btn.UseVisualStyleBackColor = true;
            this.interpretar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // texto_richText
            // 
            this.texto_richText.Location = new System.Drawing.Point(28, 42);
            this.texto_richText.Name = "texto_richText";
            this.texto_richText.Size = new System.Drawing.Size(1372, 313);
            this.texto_richText.TabIndex = 3;
            this.texto_richText.Text = "";
            // 
            // listBox_variablesEncontradas
            // 
            this.listBox_variablesEncontradas.FormattingEnabled = true;
            this.listBox_variablesEncontradas.HorizontalScrollbar = true;
            this.listBox_variablesEncontradas.Location = new System.Drawing.Point(28, 381);
            this.listBox_variablesEncontradas.Name = "listBox_variablesEncontradas";
            this.listBox_variablesEncontradas.Size = new System.Drawing.Size(225, 290);
            this.listBox_variablesEncontradas.TabIndex = 4;
            // 
            // listBox_variablesOperaciones
            // 
            this.listBox_variablesOperaciones.FormattingEnabled = true;
            this.listBox_variablesOperaciones.HorizontalScrollbar = true;
            this.listBox_variablesOperaciones.Location = new System.Drawing.Point(269, 381);
            this.listBox_variablesOperaciones.Name = "listBox_variablesOperaciones";
            this.listBox_variablesOperaciones.Size = new System.Drawing.Size(231, 290);
            this.listBox_variablesOperaciones.TabIndex = 5;
            // 
            // listBox_variablesDouble
            // 
            this.listBox_variablesDouble.FormattingEnabled = true;
            this.listBox_variablesDouble.HorizontalScrollbar = true;
            this.listBox_variablesDouble.Location = new System.Drawing.Point(516, 381);
            this.listBox_variablesDouble.Name = "listBox_variablesDouble";
            this.listBox_variablesDouble.Size = new System.Drawing.Size(209, 290);
            this.listBox_variablesDouble.TabIndex = 6;
            // 
            // listBox_variablesEntero
            // 
            this.listBox_variablesEntero.FormattingEnabled = true;
            this.listBox_variablesEntero.HorizontalScrollbar = true;
            this.listBox_variablesEntero.Location = new System.Drawing.Point(743, 381);
            this.listBox_variablesEntero.Name = "listBox_variablesEntero";
            this.listBox_variablesEntero.Size = new System.Drawing.Size(200, 290);
            this.listBox_variablesEntero.TabIndex = 7;
            // 
            // listBox_variablesString
            // 
            this.listBox_variablesString.FormattingEnabled = true;
            this.listBox_variablesString.HorizontalScrollbar = true;
            this.listBox_variablesString.Location = new System.Drawing.Point(961, 381);
            this.listBox_variablesString.Name = "listBox_variablesString";
            this.listBox_variablesString.Size = new System.Drawing.Size(183, 290);
            this.listBox_variablesString.TabIndex = 8;
            // 
            // listBox_variablesContexto
            // 
            this.listBox_variablesContexto.FormattingEnabled = true;
            this.listBox_variablesContexto.HorizontalScrollbar = true;
            this.listBox_variablesContexto.Location = new System.Drawing.Point(1164, 381);
            this.listBox_variablesContexto.Name = "listBox_variablesContexto";
            this.listBox_variablesContexto.Size = new System.Drawing.Size(209, 290);
            this.listBox_variablesContexto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 788);
            this.Controls.Add(this.listBox_variablesContexto);
            this.Controls.Add(this.listBox_variablesString);
            this.Controls.Add(this.listBox_variablesEntero);
            this.Controls.Add(this.listBox_variablesDouble);
            this.Controls.Add(this.listBox_variablesOperaciones);
            this.Controls.Add(this.listBox_variablesEncontradas);
            this.Controls.Add(this.texto_richText);
            this.Controls.Add(this.interpretar_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
    }
}

