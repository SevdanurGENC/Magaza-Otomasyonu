using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using magaza1.presentation_layer;

namespace magaza1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MerkezAraYuz());
            //Application.Run(new MerkezPanel());
            //Application.Run(new MagazaPanel());
            Application.Run(new PanelGiris());
        }
    }
}
