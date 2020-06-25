using System;
using System.Collections.Generic;
using System.Text;

namespace Classi6
{
    class EUR : Valuta
    {
        double curs = 1.5;
        double x; // кол-во денег
        public EUR(double x)
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
            x = y / curs;
            return y / curs;
        }

    }
}
