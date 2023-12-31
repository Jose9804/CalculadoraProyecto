﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        //propiedades 
        public float Numero1 { get; set; }

        public float Numero2 { get; set; }

        //Métodos para realizar los cálculos
        public float Sumar()
        {
            return (Numero1 + Numero2);
        }

        public float Restar()
        {
            return (Numero1 - Numero2);
        }

        public float Multiplicar()
        {
            return (Numero1 * Numero2);
        }

        public float Dividir()
        {
            return (Numero1 / Numero2);

        }

        public float Ejecutar(int oper)
        {
            float result = 0;

            switch (oper)
            {
                case 0:
                    result = this.Sumar();
                    break;
                case 1:
                    result = this.Restar();
                    break;
                case 2:
                    result = this.Multiplicar();
                    break;
                case 3:
                    result = this.Dividir();
                    break;
            }
            return result;
        }

    }//cierre class
} //cierre namespace