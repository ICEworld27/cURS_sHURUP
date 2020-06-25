using System;
using System.Collections.Generic;
using System.Text;

namespace Classi6
{
    class USD : Valuta
    {

        double curs = 1;
        double x; // кол-во денег
        public USD(double x)
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


