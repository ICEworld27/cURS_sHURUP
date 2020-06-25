using System;
using System.Collections.Generic;
using System.Text;

namespace Classi6
{
    abstract class Valuta
    {
        public abstract double Curs();
        public  abstract double X
        {
            get
            {
                return 0.0;
            }
            set
            {

                Console.WriteLine("?");

            }
        }
        public abstract double Change();
        public double BackChange(double y, Valuta v)
        {
            return y / v.Curs();
        }
        public  void Add(Valuta v)
        {

            X += (v.Change() * v.Curs())*this.Curs();
        }


    }
}
