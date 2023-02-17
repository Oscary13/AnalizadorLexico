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
            listBox_variablesDouble.Items.Clear();
            listBox_variablesOperaciones.Items.Clear();
            listBox_variablesEntero.Items.Clear();
            listBox_variablesString.Items.Clear();
            listBox_variablesContexto.Items.Clear();
            listBox_funcionesUtilizadas.Items.Clear();
            listBox_lexemas.Items.Clear();
            listBox_tkn.Items.Clear();


            String texto = texto_richText.Text;
            String expresionRegex_variableOperaciones = @"(const |let |var |int |double |float |decimal )([a-zA-z][a-zA-Z0-9]+)( *)(=)( *)((\+|\-|\*|\/)?( *)(\.[0-9]+|[0-9]+|[0-9]+\.[0-9]+)(( *)(\+|\-|\*|\/)( *)(\.[0-9]+|[0-9]+\.[0-9]+|[0-9]+))+)+( *)(\;)";
            String expresionRegex_variablesContexto0 = @"(const |let |var |int |double |float |decimal )([a-zA-z][a-zA-Z0-9]+)( *)(=)( *)([a-zA-z][a-zA-Z0-9]+)(\.)([a-zA-z][a-zA-Z0-9]+)(\(\)|\([a-z]+\)|\("".*\""\))( *)(\;)";
            String expresionRegex_variablesDecimales = @"(const |let |var |double |float |decimal )([a-zA-z][a-zA-Z0-9]+)( *= *)( *)(\.[0-9]+|[0-9]+\.[0-9]+)(\;)";
            String expresionRegex_variablesEnteros = @"(int |var |const )([a-zA-z][a-zA-Z0-9]+)( *= *)( *)([0-9]+)( *)(\;)";
            String expresionRegex_variablesString = @"(const |String |string |var )([a-zA-z][a-zA-Z0-9]+)( *= *)( *)(\"".+\"")( *)(\;)";
            String expresionRegex_variablesContexto = @"(const |let |var |int |double |float |decimal |String |string )([a-zA-z][a-zA-Z0-9]+)( *= *)([a-zA-z][a-zA-Z0-9]+)(\(\"".+\""\)|\(.*\))( *)(\;)";
            String expresionRegex_funcionesUtilizadas = @"([a-zA-z][a-zA-Z0-9]+)(\.)([a-zA-z][a-zA-Z0-9]+)(\(([a-zA-z][a-zA-Z0-9]+|\""(.*)\"")\)|(\(\)))( *)(\;)";
            String expresionRegex_lexemas = @"(const |let |var |int |double |float |decimal |String |string |if |for |while |else |foreach)";
            String expresionRegex_tkn1 = @"([a-zA-z][a-zA-Z0-9]+(\(\)|\(\"".*\""\)))";
            String expresionRegex_tkn2 = @"(\.[0-9]+|[0-9]+\.[0-9]+)";
            String expresionRegex_tkn3 = @"([0-9]+)";
            String expresionRegex_tkn4 = @"((\+|\-|\*|\/)?( *)(\.[0-9]+|[0-9]+|[0-9]+\.[0-9]+)(( *)(\+|\-|\*|\/)( *)(\.[0-9]+|[0-9]+\.[0-9]+|[0-9]+))+)+";
            String expresionRegex_tkn5 = @"(\"".+\"")";
            matchsEncontraods = Regex.Matches(texto, expresionRegex_variablesContexto0);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_variablesContexto.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_variableOperaciones);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_variablesOperaciones.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_variablesDecimales);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_variablesDouble.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_variablesEnteros);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_variablesEntero.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_variablesString);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_variablesString.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_variablesContexto);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_variablesContexto.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_funcionesUtilizadas);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_funcionesUtilizadas.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_lexemas);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_lexemas.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_tkn1);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_tkn.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_tkn2);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_tkn.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_tkn3);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_tkn.Items.Add(match.Value);
            }

            matchsEncontraods = Regex.Matches(texto, expresionRegex_tkn4);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_tkn.Items.Add(match.Value);
            }
            matchsEncontraods = Regex.Matches(texto, expresionRegex_tkn5);
            foreach (Match match in matchsEncontraods)
            {
                listBox_variablesEncontradas.Items.Add(match.Value);
                listBox_tkn.Items.Add(match.Value);
            }

        }
    }
}
