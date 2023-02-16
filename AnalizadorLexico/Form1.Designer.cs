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
            this.listBox_variablesEncontradas = new System.Windows.Forms.ListBox();
            this.texto_richText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // interpretar_btn
            // 
            this.interpretar_btn.Location = new System.Drawing.Point(91, 605);
            this.interpretar_btn.Name = "interpretar_btn";
            this.interpretar_btn.Size = new System.Drawing.Size(75, 23);
            this.interpretar_btn.TabIndex = 1;
            this.interpretar_btn.Text = "Interpretar";
            this.interpretar_btn.UseVisualStyleBackColor = true;
            this.interpretar_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_variablesEncontradas
            // 
            this.listBox_variablesEncontradas.FormattingEnabled = true;
            this.listBox_variablesEncontradas.HorizontalScrollbar = true;
            this.listBox_variablesEncontradas.Location = new System.Drawing.Point(568, 404);
            this.listBox_variablesEncontradas.MultiColumn = true;
            this.listBox_variablesEncontradas.Name = "listBox_variablesEncontradas";
            this.listBox_variablesEncontradas.ScrollAlwaysVisible = true;
            this.listBox_variablesEncontradas.Size = new System.Drawing.Size(236, 277);
            this.listBox_variablesEncontradas.TabIndex = 2;
            // 
            // texto_richText
            // 
            this.texto_richText.Location = new System.Drawing.Point(28, 42);
            this.texto_richText.Name = "texto_richText";
            this.texto_richText.Size = new System.Drawing.Size(1372, 313);
            this.texto_richText.TabIndex = 3;
            this.texto_richText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 788);
            this.Controls.Add(this.texto_richText);
            this.Controls.Add(this.listBox_variablesEncontradas);
            this.Controls.Add(this.interpretar_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button interpretar_btn;
        private System.Windows.Forms.ListBox listBox_variablesEncontradas;
        private System.Windows.Forms.RichTextBox texto_richText;
    }
}

