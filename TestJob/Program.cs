using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestZadanie
{
    static class Program
    {
        public static List<ActiveType> m_activeTypes;

        static Program()
        {
            m_activeTypes = new List<ActiveType>();
            m_activeTypes.Add(new ActiveType() { Title = "Деньги", KnownCount = true });
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
