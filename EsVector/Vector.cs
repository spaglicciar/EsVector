using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVector
{
    struct SVector
    {
        public double vx, vy;

        public SVector(double vx, double vy)
        {
            this.vx = vx;
            this.vy = vy;
        }

        public double CalculateNorm()
        {
            return Math.Sqrt(vx * vx + vy * vy);
        }

        public override string ToString()
        {
            string result = "vx: " + vx + ", vy: " + vy;
            return result;
        }
    }

    class CVector
    {
        public double vx, vy;

        public CVector(double vx, double vy)
        {
            this.vx = vx;
            this.vy = vy;
        }

        public double CalculateNorm()
        {
            return Math.Sqrt(vx * vx + vy * vy);
        }

        public override string ToString()
        {
            string result = "vx: " + vx + ", vy: " + vy;
            return result;
        }
    }
}
