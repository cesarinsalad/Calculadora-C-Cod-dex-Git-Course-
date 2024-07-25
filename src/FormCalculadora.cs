namespace CalculadoraSimple
{
#pragma warning disable CS8622
#pragma warning disable CS8602
    public partial class Calculadora : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private string operacion = "";
        private TextBox? lastFocused;

        public Calculadora()
        {
            InitializeComponent();
            // Asignar los manejadores de eventos para los eventos Enter y KeyPress de los TextBox
            this.textBoxPrimerValor.Enter += new EventHandler(textBox_Enter);
            this.textBoxSegundoValor.Enter += new EventHandler(textBox_Enter);
            this.textBoxPrimerValor.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            this.textBoxSegundoValor.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            this.Resultado.ReadOnly = true; // Hacer que el TextBox del resultado sea de solo lectura
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e) // Manejador del evento KeyPress para los TextBox
        {
            TextBox? textBox = sender as TextBox;

            if (textBox == null)
            {
                // Si la conversión falló, salir del método
                return;
            }

            // Verificar si la tecla presionada es un número o un punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                // Si no lo es, cancelar el evento
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1 || textBox.Text.Length == 0))
            {
                e.Handled = true;
            }
        }

        private void textBox_Enter(object sender, EventArgs e) // Manejador del evento Enter para los TextBox
        {
            lastFocused = sender as TextBox;
        }

        private void button_Click(object sender, EventArgs e) // Manejador del evento Click para los botones de los números y el punto decimal
        {
            Button btn = (Button)sender;
            if (lastFocused != null)
            {
                // Verificar si el botón es el del punto decimal y si el TextBox ya contiene un punto decimal
                // o si el TextBox está vacío
                if ((btn.Text == "." && lastFocused.Text.Contains(".")) || (btn.Text == "." && lastFocused.Text.Length == 0))
                {
                    // Si es así, no hacer nada y salir del método
                    return;
                }
                lastFocused.Text += btn.Text;
                if (lastFocused == textBoxPrimerValor)
                {
                    valor1 = double.Parse(textBoxPrimerValor.Text);
                }
                else if (lastFocused == textBoxSegundoValor)
                {
                    valor2 = double.Parse(textBoxSegundoValor.Text);
                }
            }
        }

        // Manejadores del evento Click para los botones de las operaciones
        private void buttonSum_Click(object sender, EventArgs e)
        {
            operacion = "+";
            label1.Text = "+";
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            operacion = "-";
            label1.Text = "-";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            operacion = "×";
            label1.Text = "×";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operacion = "÷";
            label1.Text = "÷";
        }

        private void buttonResult_Click(object sender, EventArgs e) // Manejador del evento Click para el botón del resultado
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "×":
                    resultado = valor1 * valor2;
                    break;
                case "÷":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                        MessageBox.Show("No se puede dividir por cero");
                    break;
            }
            Resultado.Text = resultado.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPrimerValor.Clear();
            textBoxSegundoValor.Clear();
            Resultado.Clear();
            valor1 = 0;
            valor2 = 0;
            operacion = "";
            label1.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e) // Manejador del evento Click para el botón de limpiar
        {
            if (lastFocused != null && lastFocused.Text.Length > 0)
            {
                // Eliminar el último carácter del TextBox
                lastFocused.Text = lastFocused.Text.Substring(0, lastFocused.Text.Length - 1);

                // Actualizar valor1 o valor2
                if (lastFocused == textBoxPrimerValor && double.TryParse(textBoxPrimerValor.Text, out double valor))
                {
                    valor1 = valor;
                }
                else if (lastFocused == textBoxSegundoValor && double.TryParse(textBoxSegundoValor.Text, out valor))
                {
                    valor2 = valor;
                }
            }
        }

        private void buttonNegative_Click(object sender, EventArgs e) // Manejador del evento Click para el botón de positivo/negativo
        {
            if (lastFocused != null && lastFocused.Text.Length > 0)
            {
                if (lastFocused.Text[0] == '-')
                {
                    // Si el número es negativo, quitar el signo negativo
                    lastFocused.Text = lastFocused.Text.Substring(1);
                }
                else
                {
                    // Si el número es positivo, agregar el signo negativo
                    lastFocused.Text = "-" + lastFocused.Text;
                }

                // Actualizar valor1 o valor2
                if (lastFocused == textBoxPrimerValor && double.TryParse(textBoxPrimerValor.Text, out double valor))
                {
                    valor1 = valor;
                }
                else if (lastFocused == textBoxSegundoValor && double.TryParse(textBoxSegundoValor.Text, out valor))
                {
                    valor2 = valor;
                }
            }
        }
    }
}
