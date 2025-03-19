using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300018
{
    class PemrosesData
    {
        private object dynamic;

        public void DapatkanNilaiTerbsesar<T>(T nilai1, T nilai2, T nilai3)
        {
            dynamic digit1 = (dynamic)nilai1;
            dynamic digit2 = (dynamic)nilai2;
            dynamic digit3 = (dynamic)nilai3;

            if (digit1 > digit2 && digit1 > digit3)
            {
                Console.WriteLine("Nilai terbesar adalah " + digit1);
            }
            else if (digit2 > digit1 && digit2 > digit3)
            {
                Console.WriteLine("Nilai terbesar adalah " + digit2);
            }
            else
            {
                Console.WriteLine("Nilai terbesar adalah " + digit3);
            }
        }
    }
}
