using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_POJO
{
    class Direccion
    {
        public String provincia { get; set; }
        public String canton { get; set; }
        public String distrito { get; set; }


        public Direccion()
        {

        }

        public Direccion(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 3)
            {
                provincia = infoArray[0];
                canton = infoArray[1];
                distrito = infoArray[2];
            }
            else
            {
                throw new Exception("Debe de ingresar todos los datos[provincia, canton, distroito]");

            }
        }
    }


    }


