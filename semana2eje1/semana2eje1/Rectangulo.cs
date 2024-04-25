using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2eje1
{
    internal class Rectangulo:Figura
    {
        protected float a, b;

        public Rectangulo(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public override float AreaFigura()
        {
            return b * a;
        }

    }
}
