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
            if (string.IsNullOrWhiteSpace(Txtnombre.Text))
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

            List<string> actividades = new List<string>();

            if (ChkDeportes.Checked)
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
            //===============================
            // 4.- OBTENER LA MODALIDAD SELECIIONADA
            //===============================
            string modalidad = "";
            if (RbPresencial.Checked)
            {
                modalidad = "Presencial";
            }
            else if (RbHibrida.Checked)
            {
                modalidad = "Híbrida";
            }
            else if (RbEnLinea.Checked)
            {
                modalidad = "En línea";
            }
            else
            {
                MessageBox.Show(
                    "Selecciona una modalidad",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //===============================
            // 5.- CREAR EL RESUMEN 
            //===============================
            string resumen =
                "RESUMEN DE PREFERENCIAS\r\n" +
                "___________________________\r\n" +
                "Nombre: " + Txtnombre.Text + "\r\n" +
                "Actividades: " + string.Join(", ", actividades) + "\r\n" +
                "Modalidad: " + modalidad;
            TxtResumen.Text = resumen;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar el nombre
            Txtnombre.Clear();
            //Desmarcamos el CheckBox
            ChkDeportes.Checked = false;
            ChkMusica.Checked = false;
            ChkArte.Checked = false;
            ChkProgramacion.Checked = false;
            ChkLectura.Checked = false;
            //Desmarcamos el RadioButton
            RbPresencial.Checked = false;
            RbHibrida.Checked = false;
            RbEnLinea.Checked = false;
            //Limpiar el resumen
            TxtResumen.Clear();
            //Regresamos el curosor al nombre
            Txtnombre.Focus();
        }
    }
}
