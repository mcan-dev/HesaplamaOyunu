using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatematikOyunu;

namespace Hesaplama_Oyunu
{
    internal static class Program
    {
       
        [STAThread]
        static void Main(string[] args)
        {
            int baslangicSeviyesi = 1; 


            if (args.Length == 2 && args[0].ToLower() == "open")
            {
                string seviyeParametresi = args[1].ToLower();

                if (seviyeParametresi == "all")
                {
                    baslangicSeviyesi = 5; 
                }
                else
                {
                    int.TryParse(seviyeParametresi, out baslangicSeviyesi);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaMenuForm(baslangicSeviyesi));
        }
    }
}
