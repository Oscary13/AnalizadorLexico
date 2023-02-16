using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MatchCollection matchsEncontraods;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox_variablesEncontradas.Items.Clear();
            String texto = texto_richText.Text;
            String expresionRegex = @"(const )([a-zA-z][a-zA-Z0-9]+)( *)(=)( *)((\+|\-|\*|\/)?( *)(\.[0-9]+|[0-9]+|[0-9]+\.[0-9]+)(( *)(\+|\-|\*|\/)( *)(\.[0-9]+|[0-9]+\.[0-9]+|[0-9]+))+)+( *)(\;?)";

            Console.WriteLine(texto);
            matchsEncontraods = Regex.Matches(texto, expresionRegex);
            foreach (Match match in matchsEncontraods)
            {
                Console.WriteLine(match.Value);
                listBox_variablesEncontradas.Items.Add(match.Value);
            }

        }
    }
}
