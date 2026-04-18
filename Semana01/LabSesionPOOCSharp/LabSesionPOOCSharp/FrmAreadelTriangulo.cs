using PryLibreria_Clases;

namespace LabSesionPOOCSharp
{
    public partial class FrmAreadelTriangulo : Form
    {
        public FrmAreadelTriangulo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();//cierra la ventana actual
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtLadoA.Clear(); txtLadoB.Clear(); txtLadoC.Clear(); txtArea.Clear(); txtLadoC.Focus();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(!AreadelTriangulo.ValidarNumero(txtLadoA.Text) || 
                !AreadelTriangulo.ValidarNumero(txtLadoB.Text) || 
                !AreadelTriangulo.ValidarNumero(txtLadoC.Text))
            {
                MessageBox.Show("Ingrese los datos para el calculo");
            }
            else
            {
                AreadelTriangulo obj = new AreadelTriangulo();
                txtArea.Text = obj.CalcularArea(int.Parse(txtLadoA.Text), int.Parse(txtLadoB.Text), int.Parse(txtLadoC.Text)).ToString();
            }
        }
    }
}
