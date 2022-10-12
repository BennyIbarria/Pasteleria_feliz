using System;

namespace Pasteleria
{
    public class Ingredientes
    {
        Pastel chocolate = new Pastel();
       
        //Implicitamente creamos atributos encapsulados mediante los metodos de acceso get y set
        public string NombreIngrediente { get; set; }
        public int Tipo { get; set; }
        public float Calorias { get; set; }
        public float Precio { get; set; }
        public float Peso {get; set;}
        public float MedidaRendimiento {get; set;}

        //Crear metodo que calcule las calorias totales
        public float CaloriasTotales(float Calorias, float Precio)
        {
            return this.Calorias * this.Precio;
        }

        //Crear metodo que calcule la cantidad de un ingrediente
        public float CantidadIngrediente()
        {
            return Calorias * Precio;
        }
        //Metodo que calcula las calorias totales de un pastel

        public string RevisarIngrediente(string NombreIngrediente, float Peso)       
         {
            return NombreIngrediente+Peso;
        }
    }
}