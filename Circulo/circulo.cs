using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class circulo
    {
        private double _a; // _a -> Altura ; _l -> Largura
        public string Raio { set => _a = Convert.ToDouble(value); }
        public string Area => (Math.PI * Math.PI * (_a)).ToString();
        public string Perimetro => (Math.PI * 2 * (_a)).ToString();
        public string Diametro => (_a * 2).ToString();
    }
}
