using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_POJO
{
    class Credito
    {
        public Double monto { get; set; }
        public String tasa { get; set; }
        public String nombre { get; set; }
        public String cuota { get; set; }
        public DateTime fechaInicio { get; set; }
        public String estado { get; set; }
        public Double saldoOperacion { get; set; }

        public Credito()
        {

        }

        public Credito(string [] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 7)
            {
                var monto = infoArray[0];
                tasa = infoArray[1];
                nombre = infoArray[2];
                cuota = infoArray[3];
                var fechaInicio = infoArray[4];
                estado = infoArray[5];
                var saldoOperacion = infoArray[6];
            }
            else
            {
                throw new Exception("Debe de ingresar todos los datos[monto, tasa, cuota, fechaInicio, estado, saldoOperacion]");

            }




            }
            {

            }
        }

    }
}
