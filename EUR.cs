using System;
using System.Collections.Generic;
using System.Text;

namespace Classi6
{
    class EUR : Valuta
    {
        double curs = 1.2;
        double x; // кол-во денег
        public EUR(double x)
        {
            X = x;

        }
        public override double Curs()
        {
            return curs;
        }
        public override double Change()
        {
            return x * curs;
        }
        public override double X
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

    }
}
