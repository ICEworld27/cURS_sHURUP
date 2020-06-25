using System;
using System.Collections.Generic;
using System.Text;

namespace Classi6
{
    abstract class Valuta
    {
        public virtual double Curs()
        {
            return 0.0;
        }
        public virtual double X
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
        public virtual double Change()
        {
            return 0.0;
        }
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
