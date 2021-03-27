using System;
using System.Collections.Generic;
using System.Text;

namespace example_oop
{
    class Raqueta : Provedor, Marca
    {

        public float PesoGr { get; set; }

        public string Tipo { get; set; }
        public int Precio { get; set; }
        public Raqueta()
        {
            PesoGr = 175;
            Tipo = "Aerodinamica";
            Precio = 216;
            paisOrigen = "USA";
            Descripcion = "Esta empresa a nivel de envios internacion cell:+1 46889984";
        }
        public string informacion()
        {
            return Descripcion;
        }
        public string Descripcion_Raquet(){
            return "Origen: " + paisOrigen + ",Tipo: " + Tipo + ",Peso: " + PesoGr.ToString() + "Precio: " + Precio.ToString() + "$" + " ,Informacion: Esta es una raqueta que es en forma de T de Gota"; 
        }
        public string nombre()
        {
            return "Gearbox";
        }
    }
}
