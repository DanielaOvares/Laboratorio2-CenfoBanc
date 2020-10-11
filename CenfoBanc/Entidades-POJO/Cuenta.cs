using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_POJO
{
    class Cuenta
    {
        public String nombre { get; set; }
        public String moneda { get; set; }
        public Double saldo { get; set; }

        public Cuenta()
        {
        }

        public Cuenta(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 3)
            {
                nombre = infoArray[0];
                moneda = infoArray[1];
                var saldo = infoArray[2];
            }
            else
            {
                throw new Exception ("Debe de ingresar todos los datos[nombre, moneda, saldo]" );

            }
        }
    }
}
