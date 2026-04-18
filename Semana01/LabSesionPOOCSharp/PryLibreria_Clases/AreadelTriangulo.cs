namespace PryLibreria_Clases
{
    public class AreadelTriangulo
    {
        public double CalcularArea(int a, int b, int c)
        {
            double s = (a + b + c) / 2.0;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c)); //Tambien puede ser: return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        public static bool ValidarNumero(string valor)
        {
            int n = 0;
            return int.TryParse(valor, out n);
        }
        /// <summary>
        /// Valida si un carácter presionado debe ser bloqueado en un campo de entrada.
        /// Retorna true si el carácter DEBE RECHAZARSE (bloquear), false si DEBE PERMITIRSE.
        /// Permite: números (0-9), backspace (8) y espacios en blanco.
        /// Bloquea: cualquier otro carácter.
        /// </summary>
        public static bool SoloNumeros(char tecla)
        {
            // Si es número, backspace(8) o espacio: NO rechazar (retorna false)
            if (char.IsNumber(tecla) || tecla == 8 || char.IsWhiteSpace(tecla))
            {
                return false;  // Permitir el carácter
            }
            // Si es cualquier otro carácter: SÍ rechazar (retorna true)
            else
            {
                return true;   // Bloquear el carácter
            }
        }
    }
}
