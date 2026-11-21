using Salam_Database.Data;
using Salam_Database.Forms;
using Salam_Database.Repositories;
using Salam_Database.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salam_Database
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {

            AllocConsole();

            Console.SetOut(new System.IO.StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            });

            Console.SetError(new System.IO.StreamWriter(Console.OpenStandardError())
            {
                AutoFlush = true
            });

            Console.WriteLine("Aplicación iniciada");
            Console.WriteLine("Hora actual: " + DateTime.Now);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Database.Initialize();

            CollectionService collectionService = new CollectionService();

            Application.Run(new FormLogin());
        }
    }
}
