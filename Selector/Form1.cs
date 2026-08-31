namespace Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //========================
            //1.- VALIDAR EL NOMBRE
            //========================
            if(string.IsNullOrWhiteSpace(Txtnombre.Text))
            {
                MessageBox.Show(
                    "Por favor, escribe tu nombre.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Txtnombre.Focus();
            }
            //==========================================
            //2.- OBTENER LAS ACTIVIDADES SELECCIONADAS
            //==========================================

            List<string> actividades= new List<string>();

            if(ChkDeportes.Checked )
            {
                actividades.Add("Deportes");
            }

            if (ChkMusica.Checked)
            {
                actividades.Add("Musica");
            }
            if (ChkArte.Checked)
            {
                actividades.Add("Arte");
            }
            if (ChkProgramacion.Checked)
            {
                actividades.Add("Programacion");
            }
            if (ChkLectura.Checked)
            {
                actividades.Add("Lectura");
            }

            //===============================
            // 3.- COMPROBAR QUE SELECCIONÓ
            // AL MENOS UNA ACTIVIDAD
            //===============================
            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona al menos una actividad",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }

        }
    }
}
