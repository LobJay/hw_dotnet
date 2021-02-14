using System;

namespace HW2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Неявное преобразование
            byte ad = 4;
            int bd = (ad + 70);

            byte da = 30;
            ushort daa;
            daa = da;

            int io = 345;
            long ioo;
            ioo = io;

            // Явное преобразование
            byte a = 4;
            byte b = (byte)(a + 70);

            int ui = 4;
            int ub = 6;
            byte uc = (byte)(ui + ub);

            double op = 4.0;
            decimal ob = (decimal)op;

            //Упаковка
            int i = 123;
            object o = i;

            sbyte id = 123;
            object od = id;

            ushort ib = 123;
            object po = ib;

            //Распаковка
            int c = 123;
            object d = c;
            int j = (int)d;

            sbyte zx = 123;
            object zz = zx;
            sbyte z = (sbyte)zz;

            ushort xz = 123;
            object s = xz;
            ushort f = (ushort)s;






        }
    }
}
