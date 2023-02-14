namespace Mi_primera_aplicación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerUsuarioEquipo();
        }

        private void ObtenerUsuarioEquipo() 
        {
            string usuario = SystemInformation.UserName;
            string dominio = SystemInformation.UserDomainName;

            salida.Text = "Usuario: " + usuario + Environment.NewLine + "Dominio o equipo: " + dominio;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}