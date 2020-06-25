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
            Valuta a = new EUR(e);
            Valuta b = new RUB(r);
            Valuta c=  new USD(d);
            Console.WriteLine("Выберите валюту для перевода \n1 - Рубли\n2 - Доллары\n3 - Рубли");
            int v = Convert.ToInt32(Console.ReadLine());
            double res;
            if (v == 1)
            {
                res = a.BackChange(a.Change() + b.Change() + c.Change());
            }
            else
            {
                if (v == 2)
                {
                    res = b.BackChange(a.Change() + b.Change() + c.Change());
                }
                else
                {
                    if (v == 3)
                    {
                        res = c.BackChange(a.Change() + b.Change() + c.Change());
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
