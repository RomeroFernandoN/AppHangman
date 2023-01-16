using AppAhorcado.AppAhorcadoBackend.Service;
using AppAhorcado.AppAhorcadoFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAhorcado
{
    static class Program
    {
        static public ApplicationContext context;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            context = new ApplicationContext(new Start(new FactoryServiceImp()));
            Application.Run(context);
        }
    }
}
