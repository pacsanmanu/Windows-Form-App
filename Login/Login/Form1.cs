namespace Login
{
    public partial class Dise�ador : Form
    {
        public Dise�ador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "Hola " + textBox2.Text + ", tu correo electr�nico es " + textBox1.Text + " y tu contrase�a es *top secret* " + textBox3.Text + ".";
            if (checkBox1.Checked && checkBox2.Checked)
            {
                result += Environment.NewLine + Environment.NewLine + "Usted es de g�nero no binario.";
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
                result += Environment.NewLine + Environment.NewLine + "Su g�nero no ha sido especificado.";
            }
            result += Environment.NewLine + Environment.NewLine + "Su fecha de nacimiento es " + dateTimePicker1.Value.ToString("dd-MM-yyyy") + ".";
            MessageBox.Show(result);
        }
    }
}