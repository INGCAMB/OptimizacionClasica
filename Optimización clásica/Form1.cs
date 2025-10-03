using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimización_clásica
{
    public partial class FormaOptimizacion : Form
    {
        // Constante de delimitadores para separar los factores
        static readonly char[] delimitadores = { '+' };

        public FormaOptimizacion()
        {
            InitializeComponent();
        }

        // Clase para guardar la función entera
        class Funcion
        {
            // Arreglo de factores para separar la funcion por factores
            public Factor[] Factores;
            // Variable que guarda el máximo o mínimo.
            float MaxMin;

            // Procedimiento que declara la longitud del arreglo de factores
            public void DeclararFactores(int Cantidad)
            {
                Factores = new Factor[Cantidad];
            }

            // Procedimiento para capturar la funcion y separando por factores
            public void Capturar(string tex)
            {
                // Split convierte en arreglo de string un string separando por el delimitador
                string[] separados = tex.Split(delimitadores);
                // Se manda a llamar el procedimiento
                DeclararFactores(separados.Count());

                // Ciclo para separar los factores de la función
                for (int c = 0; c < separados.Count(); c++)
                {
                    // ToCharArray separa un string y lo convierte en un arreglo de caracteres
                    char[] caracteres = separados[c].ToCharArray();
                    Factores[c] = new Factor();

                    string num = "", exp = "";
                    bool xp = false;
                    foreach (char caracter in caracteres)
                    {
                        if (char.IsDigit(caracter) || caracter == '-' || caracter == '.')
                        {
                            if (xp)
                                exp += caracter;
                            else
                                num += caracter;
                        }
                        else if (caracter == 'x')
                            Factores[c].Potencia = 1;
                        else if (caracter == '^')
                            xp = true;
                    }

                    // Si no había números en el factor se deja su valor predeterminado
                    if (num != "")
                        Factores[c].Veces = float.Parse(num);
                    // Si no había números en el exponente se deja su valor predeterminado
                    if (exp != "")
                        Factores[c].Potencia = float.Parse(exp);
                }
            }

            // Función que regresar el valor del maximo o mínimo calculado
            public float CalcularMaximo()
            {
                MaxMin = -Factores[1].Veces / Factores[0].Veces;
                return MaxMin;
            }

            // Procedimiento que deriva la función
            public void Derivar()
            {
                // Ciclo que deriva factor por factor
                foreach(Factor fact in Factores)
                {
                    fact.Veces *= fact.Potencia;
                    // Compara si el exponente es 0 para no restarlo de ser así
                    if (fact.Potencia != 0)
                        fact.Potencia--;
                }
            }

            // Función que despliega la función en el Textbox donde regresa el string
            public string MostrarDerivada()
            {
                string texto = "";

                Factor primero = Factores.First();
                foreach (Factor fact in Factores)
                {
                    if (fact.Veces != 0)
                    {
                        if (fact != primero)
                        {
                            if (fact.Veces > 0)
                                texto += " + ";
                            else
                                texto += " - ";
                        }

                        if (fact == primero)
                            texto += fact.Veces;
                        else
                            texto += Math.Abs(fact.Veces);
                        if (fact.Potencia != 0)
                        {
                            texto += "x";
                            if (fact.Potencia != 1)
                                texto += "^" + fact.Potencia;
                        }
                    }
                }

                return texto;
            }

            // Función que calcula la rentabilidad reemplazando el máximo o mínimo en la función
            public float Rentabilidad()
            {
                float Resultado = 0;

                foreach (Factor fac in Factores)
                {
                    Resultado+= fac.Veces * (float)Math.Pow(MaxMin, fac.Potencia);
                }

                return Resultado;
            }
        }

        // Clase factor que guarda las veces que se repite una variable y su potencial
        class Factor
        {
            public float Veces, Potencia;

            // Constructor que inicia el factor con 1 veces que se repite la variable y con potencia de 0
            public Factor()
            {
                Veces = 1;
                Potencia = 0;
            }
        }

        // Procedimiento que se ejecuta al momento de presionar el botón de calcular
        private void Calcular_Click(object sender, EventArgs e)
        {
            // Crea una instancia de la clase función
            Funcion funcion = new Funcion();

            // Captura la función ingresada en el textbox
            funcion.Capturar(txtfuncion.Text);
            
            // Se llama al procedimiento para derivar la función
            funcion.Derivar();
            // Se despliega la primera derivada
            txtPrimeraDerivada.Text = funcion.MostrarDerivada();

            // Se despliega el máximo o el mínimo
            txtM.Text = funcion.CalcularMaximo().ToString();

            // Se deriva por segunda vez
            funcion.Derivar();
            // Se despliega la segunda derivada
            txtSegundaDerivada.Text = funcion.MostrarDerivada();

            // Se compara el resultado para desplegar si es un máximo o un mínimo
            if (float.Parse(txtSegundaDerivada.Text) < 0)
                lblM.Text = "Máximo";
            else
                lblM.Text = "Mínimo";

            funcion.Capturar(txtfuncion.Text);

            // Se manda a llamar y se despliega la rentabilidad
            txtRentabilidad.Text = funcion.Rentabilidad().ToString();
        }

        // Procedimiento que limpia los textbox de la forma y hace foco en el textbox de entrada
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtfuncion.Clear();
            txtPrimeraDerivada.Clear();
            txtSegundaDerivada.Clear();
            txtM.Clear();
            txtRentabilidad.Clear();

            txtfuncion.Focus();
        }
    }
}
