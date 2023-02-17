namespace Login
{
    public partial class Diseñador : Form
    {
        public Diseñador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "Hola " + textBox2.Text + ", tu correo electrónico es " + textBox1.Text + " y tu contraseña es *top secret* " + textBox3.Text + ".";
            if (checkBox1.Checked && checkBox2.Checked)
            {
                result += Environment.NewLine + Environment.NewLine + "Usted es de género no binario.";
            }
            else if (checkBox1.Checked)
            {
                result += Environment.NewLine + Environment.NewLine + "Usted es un hombre.";
            }
            else if (checkBox2.Checked)
            {
                result += Environment.NewLine + Environment.NewLine + "Usted es una mujer.";
            }
            else 
            {
                result += Environment.NewLine + Environment.NewLine + "Su género no ha sido especificado.";
            }
            result += Environment.NewLine + Environment.NewLine + "Su fecha de nacimiento es " + dateTimePicker1.Value.ToString("dd-MM-yyyy") + ".";
            MessageBox.Show(result);
        }
    }
}