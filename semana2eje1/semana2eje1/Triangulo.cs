using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2eje1
{
    internal class Triangulo:Figura
    {
        protected float q, w;

        public Triangulo(float q, float w)
        {
            this.q = q;
            this.w = w;
        }

        public override float AreaFigura()
        {
            return q * w;
        }
    }
}
