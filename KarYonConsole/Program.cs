using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarYonSistemi;

namespace KarYonConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GonderiYonetimSistemi gonderiYonetimSistemi = GonderiYonetimSistemi.Temsilci;

            // Örnek verileri kargoya ver
            foreach (var gonderi in gonderiYonetimSistemi.gonderiler)
            {
                await kargoyaver(gonderi);
            }
        }

        private static async Task kargoyaver(Gonderi gonderi)
        {
            await KargoyaVer(gonderi);
        }

        private async static Task KargoyaVer(Gonderi gonderi)
        {
            GonderiYonetimSistemi gonderiYonetimSistemi = GonderiYonetimSistemi.Temsilci;

            await gonderiYonetimSistemi.KargoyaVer(gonderi);
        }
    }
}
