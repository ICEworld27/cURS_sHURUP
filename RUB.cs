using System;
using System.Collections.Generic;
using System.Text;

namespace Classi6
{
    class RUB : Valuta
    {
        double curs = 1.5;
        double x; // кол-во денег
        public RUB(double x)
        {
            X = x;

        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {

                this.x = value;

            }
        }
        public override double Change()
        {
            return x * curs;
        }
        public override double BackChange(double y)
        {
            //x = y / curs;
            return y / curs;
        }
    }
        
}
