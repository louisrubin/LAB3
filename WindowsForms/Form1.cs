namespace WindowsForms
{
    public partial class Form1 : Form
    {

        //public Zoologico zoologico = new Zoologico();
        public Form1()
        {
            InitializeComponent();
            Zoologico.getListaAnimal().Add(new Animal("pepe", "gato", "ratones"));
            Zoologico.getListaCuidador().Add(new Cuidador("Sgto. Pimienta"));
            //string path = new DirectoryInfo(currentFolderPath).Parent.FullName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_verAnimales_Click(object sender, EventArgs e)
        {
            FichaAnimal fichaAnimal = new FichaAnimal(true);
            fichaAnimal.Show();
        }

        private void btn_verCuidadores_Click(object sender, EventArgs e)
        {
            FichaAnimal fichaAnimal = new FichaAnimal(false);
            fichaAnimal.Show();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
