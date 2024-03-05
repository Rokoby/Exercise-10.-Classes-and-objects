using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        public int Gradus { 
            get
            { 
                return gradus; 
            } 
            set 
            {
                if (value >0)
                {
                    gradus = value;
                }
                else
                {
                    isCorrect = false;
                }
            } 
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value > 0 )
                {
                    min = value;
                }
                else
                {
                    isCorrect = false;
                }
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value > 0)
                {
                    sec = value;
                }
                else
                {
                    isCorrect = false;
                }
            }
        }


        public Angle(int gradus, int min, int sec)
            {
            this.Sec = sec;
            this.Min = min;
            this.Gradus = gradus;
            }

    public double ToRadians ()
        {
            return (Gradus + (double)Min / 60 + (double)Sec / 3600)*Math.PI/180;
        }
    }
}
