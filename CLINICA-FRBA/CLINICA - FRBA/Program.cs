using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;

namespace CLINICA___FRBA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new Form1());*/ /*el default, seria el login*/

            
            /*ACA ESPECIFICO CON QUE FORM ARANQUE AL EJECUTAR*/
            //Application.Run(new frmRegLlegada());
            //Application.Run(new frmLogin());
            //Application.Run(new frmRegResultados()); 
            //Application.Run(new frmALTAafiliado()); 
            //Application.Run(new frmCancTurnoAfiliado()); 
            //Application.Run(new frmABMRolInicio());
            //Application.Run(new frmBAJAafiliado()); 
            Application.Run(new frmABMAfiliado()); 
        }
    }
}
