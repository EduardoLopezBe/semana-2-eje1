using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2eje1
{
   class Circulo : Figura
    {
        protected float cRadio;
        public Circulo(float cRadio)
        {
            this.cRadio = cRadio;
        }
        public override float AreaFigura()
        {
            return cRadio * cRadio * 3.14f;
        }     
   }
}
