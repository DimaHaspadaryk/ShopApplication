using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
            DataBase data = new DataBase();
           
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainMenuForm());
            
            
          
        }
    }
}
