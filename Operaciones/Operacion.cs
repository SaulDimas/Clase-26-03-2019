﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Operacion
    {
        public double v1, v2, resultado;
        public double Calcular()
        {

            resultado = V1 +V2;
            return resultado;
        }

        public double Resultado
        {
            get{return v1;}

            set{v1 = value;}
        }

        public double V1
        {
            get
            {
                return v1;
            }

            set
            {
                v1 = value;

            }
        }

        public double V2
        {
            get
            {
                return v2;
            }

            set
            {
                v2 = value;
            }
        }
    }
}
