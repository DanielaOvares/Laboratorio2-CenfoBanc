using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades_POJO
{
    class Cliente
    {
        public String id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int edad { get; set; }
        public String estadoCivil { get; set; }
        public String genero { get; set; }

        public Cliente()
        {

        }

        public Cliente(string  [] infoArray)
        {
            if (infoArray!=null && infoArray.Length>= 6) {
               id = infoArray[0];
               nombre = infoArray[1];
               apellido = infoArray[2];
               var FechaNacimiento = infoArray[3];
               estadoCivil = infoArray[4];
               genero = infoArray[5];
               var edad = 0;
               if (Int32.TryParse(infoArray[6], out edad))
                    edad = edad;
                else
                    throw new Exception("La edad debe ser un número");

            }
            else
            {
                throw new Exception("Debe de llenar todos los espacios [id, nombre, apellido, FechaNacimiento, edad, estadoCivil, genero]");
        }
        }

        private class FechaNacimiento
        {
        }
    }
}
