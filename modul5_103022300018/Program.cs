using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300018
{
    class Program
    {
        static void Main(string[] args)
        {
            PemrosesData proses = new PemrosesData();
            proses.DapatkanNilaiTerbsesar<int>(30, 00, 18);

            SimpleDataBase<int> db = new SimpleDataBase<int>();
            db.AddNewData(30);
            db.AddNewData(00);
            db.AddNewData(18);
            db.PrintAllData();
        }
    }
}