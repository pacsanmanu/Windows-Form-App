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
            salida.Text = string.Empty;

            ObtenerUsuarioEquipo();
            ObtenerUnidades();
        }

        private void ObtenerUsuarioEquipo() 
        {
            string usuario = SystemInformation.UserName;
            string dominio = SystemInformation.UserDomainName;

            salida.Text = "Usuario: " + usuario + Environment.NewLine + "Dominio o equipo: " + dominio;
        }

        private void ObtenerUnidades() 
        {
            DriveInfo[] drives = DriveInfo
                .GetDrives()
                .Where(a => a.DriveType == DriveType.Fixed)
                .ToArray();

            foreach (DriveInfo drive in drives) 
            {
                double espacioLibre = drive.TotalFreeSpace;
                double espacioTotal = drive.TotalSize;

                double espacioLibrePorcentaje = (espacioLibre/ espacioTotal) * 100;
                salida.Text += Environment.NewLine + drive.Name + ": " + espacioLibrePorcentaje + "%" + Environment.NewLine;  
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}