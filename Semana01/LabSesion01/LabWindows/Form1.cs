using System.Runtime.InteropServices;

namespace LabWindows
{
    public partial class Form1 : Form
    {
        //Constructor de la clase Form1
        public Form1()
        {
            InitializeComponent();
            deshabilitaX();
        }

        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        //Obtener el menu del sistema
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        //Obtener el numero de elementos del menu del sistema
        private static extern int GetMenuItemCount(IntPtr hWnd);
        void deshabilitaX()
        {
            // Código para inhabilitar el botón X para que se
            // salga el usuario usando el botón Cancelar
            //Obtener el manejador del menu de sistema del formulario
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            //Obtener la cuenta de los ítems del menú de sistema.
            //Es el menú que aparece al pulsar sobre el icono a la izquierda
            //de la Barra de título de la ventana, consta de los ítems: Restaurar, Mover,
            //Tamaño,Minimizar, Maximizar, Separador, Cerrar
            int menuItemCount = GetMenuItemCount(hMenu);
            //Quitar el ítem Close (Cerrar), que es el último de ese menú
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
            // Fin código botón X
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cboTrabajador.SelectedIndex == 0)
                MessageBox.Show("Seleccione un trabajador");
            else if (TxtSueldoBasico.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un sueldo básico"); TxtSueldoBasico.Focus();
            }
            else
            {
                double sueldo=double.Parse(TxtSueldoBasico.Text);
                double aumento = 0, nuevosueldo = 0;
                if (sueldo < 2000) {aumento = sueldo * 0.20;}
                else if(sueldo >= 2000 && sueldo <=3000 ) { aumento = sueldo * 0.13;}
                else { aumento = sueldo * 0.09; }
                nuevosueldo = sueldo + aumento;
                TxtAumento.Text = "S/. " + aumento.ToString("0.00");
                TxtNuevoSueldo.Text = "S/. " + nuevosueldo.ToString("0.00");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CArgar trabajadores
            cboTrabajador.Items.Add("Seleccionar"); //0
            cboTrabajador.Items.Add("Camacho Sandoval");//1
            cboTrabajador.Items.Add("Carlos García");//2
            cboTrabajador.Items.Add("Emilia Garcia");//3
            //Establecer una posicion al valor
            cboTrabajador.SelectedIndex = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Ejercicio 01", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();//Cerrar la aplicación
                //this.Close() //Cerrar el formulario actual, si es el único formulario se cierra la aplicación
                //this.Dispose() //Liberar los recursos del formulario actual, si es el único formulario se cierra la aplicación
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TxtAumento.Clear(); TxtNuevoSueldo.Clear(); TxtSueldoBasico.Clear();
            cboTrabajador.SelectedIndex = 0;
            TxtSueldoBasico.Focus(); //Enfocar el cursor en el TextBox del sueldo básico
        }
        private void TxtNuevoSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSueldoBasico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir el ingreso de solo números 
            //e.KeyChar => recuperar el caracter presionado por el usuario
            // 8 retroceso, 32 avance y 13 enter
            errorProvider1.Clear(); //Limpiar el errorProvider para que no se muestre el mensaje de error al ingresar un número después de haber ingresado un carácter no permitido
            if (char.IsNumber(e.KeyChar) || e.KeyChar==8 || e.KeyChar==32 || e.KeyChar == 13 || ((e.KeyChar=='.') && (!TxtSueldoBasico.Text.Contains("."))))
            {
                e.Handled = false; // NO se maneja el evento KeyPress, se permite el ingreso de la tecla, la tecla es válida,
                if (e.KeyChar == 13)
                {
                    btnCalcular.Focus(); //Enfocar el cursor en el botón Calcular
                }
            }
            else
            {
                errorProvider1.SetError(TxtSueldoBasico, "Ingrese solo números"); //Establecer error en un control específico, en este caso el TextBox del sueldo básico
                e.Handled = true; //Se maneja el evento de la tecla porque es invalida, no se permite el ingreso de otras teclas
                MessageBox.Show("Solo se permiten números", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSueldoBasico.Focus(); //Enfocar el cursor en el TextBox del sueldo básico

            }
        }
    }
}
