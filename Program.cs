using System;

namespace Classi6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рубли: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Доллары: ");

            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Евро: ");
            int e = Convert.ToInt32(Console.ReadLine());
            EUR a = new EUR(e);
            RUB b = new RUB(r);
            USD c=  new USD(d);
            Console.WriteLine("Выберите валюту для перевода \n1 - Рубли\n2 - Доллары\n3 - Евро");
            int v = Convert.ToInt32(Console.ReadLine());
            double res;
            if (v == 1)
            {
                b.Add(a); b.Add(c);
                res =b.X;
            }
            else
            {
                if (v == 2)
                {
                    c.Add(a); c.Add(b);
                    res = c.X;
                }
                else
                {
                    if (v == 3)
                    {
                        a.Add(c); a.Add(b);
                        res = a.X;
                    }
                    else
                    {
                        res = 0;
                    }
                }
            }
            Console.WriteLine(res); 
        }
    }
}
